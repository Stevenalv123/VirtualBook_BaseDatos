using System.Net.Http.Json;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;


//using VirtualBook.DTOs;
using VirtualBook.Views.GeneralViews;

namespace VirtualBook.Views.UploadBookForm
{
    public partial class UploadBookForm : Form
    {
        Label lblSoltarAqui;

        private readonly ApiClient _apiClient;

        int _idUsuario;
        private string? portada { get; set; }
        private string? archivoPdf { get; set; }
        IMainForm _mf;

        public UploadBookForm(IMainForm mf)
        {
            InitializeComponent();

            _mf = mf;
            _apiClient = ApiClient.Instance;

            PcbLibroPortada.AllowDrop = true;
            lblSoltarAqui = new Label();
            _mf = mf;
            CrearLabel(lblSoltarAqui);

            _ = CargarDatosFormulario();
        }

        //DragEnter
        private void ArrastrarArchivo(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);
            string extension = Path.GetExtension(archivos[0]).ToLower();

            // Verifica si es una imagen con extensión válida
            if (extension == ".jpg" || extension == ".jpeg" || extension == ".png" || extension == ".bmp" || extension == ".gif")
            {
                e.Effect = DragDropEffects.Copy;
                lblSoltarAqui.Visible = true;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        //DragDrop
        private void SoltarArchivo(object sender, DragEventArgs e)
        {
            string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (archivos.Length > 0)
            {
                PcbLibroPortada.Image = Image.FromFile(archivos[0]);
                lblSoltarAqui.Visible = false;
            }
        }

        private void CargarPortadaLibro(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdImg = new OpenFileDialog())
            {
                ofdImg.Title = "Selecciona la imagen de portada";
                ofdImg.Filter = "Imágenes (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";

                if (ofdImg.ShowDialog() == DialogResult.OK)
                {
                    PcbLibroPortada.Image = Image.FromFile(ofdImg.FileName);
                    PcbLibroPortada.SizeMode = PictureBoxSizeMode.Zoom;
                    portada = ofdImg.FileName;
                    LblStatus.Text = "✓ Portada cargada correctamente.";
                    LblStatus.ForeColor = Color.Green;
                    LblStatus.Visible = true;
                }
                else
                {
                    LblStatus.Text = "✗ No se seleccionó ninguna portada.";
                    LblStatus.ForeColor = Color.Red;
                    LblStatus.Visible = true;
                }
            }
        }

        private void CargarLibro_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdPdf = new OpenFileDialog())
            {
                ofdPdf.Title = "Selecciona el PDF del libro";
                ofdPdf.Filter = "Archivos PDF (*.pdf)|*.pdf";

                if (ofdPdf.ShowDialog() == DialogResult.OK)
                {
                    archivoPdf = ofdPdf.FileName;
                    LblStatusArchivo.Text = "✓ PDF cargado correctamente.";
                    LblStatusArchivo.ForeColor = Color.Green;
                    LblStatusArchivo.Visible = true;
                }
                else
                {
                    LblStatusArchivo.Text = "✗ No se seleccionó ningún PDF.";
                    LblStatusArchivo.ForeColor = Color.Red;
                    LblStatusArchivo.Visible = true;
                }
            }
        }

        //Dejar de soltar
        private void pcboUploadCover_DragLeave(object sender, EventArgs e)
        {
            lblSoltarAqui.Visible = false;
        }

        private void CrearLabel(Label lblSuelteAqui)
        {
            lblSuelteAqui.Text = "¡Suelte aquí!";
            lblSuelteAqui.TextAlign = ContentAlignment.MiddleCenter;
            lblSuelteAqui.ForeColor = Color.White;
            lblSuelteAqui.BackColor = Color.FromArgb(150, Color.Black);
            lblSuelteAqui.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblSuelteAqui.Dock = DockStyle.Fill;
            lblSuelteAqui.Visible = false;

            PcbLibroPortada.Controls.Add(lblSuelteAqui);
            lblSuelteAqui.BringToFront(); // Asegura que el texto esté arriba
        }
        private void TxtAutor_Leave(object sender, EventArgs e)
        {
            //if (!LstAutores.Bounds.Contains(PointToClient(Cursor.Position)))
            //    LstAutores.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private async Task CargarDatosFormulario()
        {
            try
            {
                await RecargarAutores();
                var autores = await _apiClient.Data.GetAutoresAsync();

                CmbAutor.DataSource = autores;
                CmbAutor.DisplayMember = "Nombre";
                CmbAutor.ValueMember = "Id";
                CmbAutor.SelectedItem = null;

                var categorias = await _apiClient.Data.GetCategoriasAsync();
                CmbCategoria.DataSource = categorias;
                CmbCategoria.DisplayMember = "Nombre";
                CmbCategoria.ValueMember = "Id";

                var formatos = await _apiClient.Data.GetFormatosAsync();
                CmbFormato.DataSource = formatos;
                CmbFormato.DisplayMember = "Nombre";
                CmbFormato.ValueMember = "Id";

                var idiomas = await _apiClient.Data.GetIdiomasAsync();
                CmbIdioma.DataSource = idiomas;
                CmbIdioma.DisplayMember = "Nombre";
                CmbIdioma.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(archivoPdf) || string.IsNullOrEmpty(portada))
            {
                MessageBox.Show("La portada y el archivo PDF son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbAutor.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar al menos un autor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (CmbCategoria.SelectedValue == null || CmbFormato.SelectedValue == null || CmbIdioma.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar Categoría, Formato e Idioma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var modelo = new LibroUploadModel
            {
                Titulo = TxtTitulo.Text,
                Descripcion = TxtDescripcion.Text,
                RutaArchivoPDF = this.archivoPdf,
                RutaArchivoPortada = this.portada,

                IdCategoria = (int)CmbCategoria.SelectedValue,
                IdFormato = (int)CmbFormato.SelectedValue,
                IdIdioma = (int)CmbIdioma.SelectedValue,

                IdsAutores = new List<int> { (int)CmbAutor.SelectedValue },

                NumeroPaginas = int.TryParse(TxtNumeroPaginas.Text, out int paginas) ? paginas : null
            };

            try
            {
                //PcbCargando.Visible = true;
                bool exito = await _apiClient.Libros.SubirLibroAsync(modelo);
                //PcbCargando.Visible = false;

                if (exito)
                {
                    MessageBox.Show("¡Libro subido exitosamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnCancel_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("La API rechazó la subida. Revise los datos (ej: ¿IDs de FK correctos?).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //PcbCargando.Visible = false;
                MessageBox.Show($"Error fatal al conectar con la API: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnAgregarAutor_Click(object sender, EventArgs e)
        {
            using (var formAutor = new NuevoAutorForm())
            {
                var resultado = formAutor.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    int idNuevoAutor = formAutor.NuevoAutorId;

                    await RecargarAutores(idNuevoAutor);
                }
            }
        }
        private async Task RecargarAutores(int idSeleccionar = 0)
        {
            try
            {
                var autores = await _apiClient.Data.GetAutoresAsync();
                CmbAutor.DataSource = autores;
                CmbAutor.DisplayMember = "Nombre";
                CmbAutor.ValueMember = "Id";

                if (idSeleccionar > 0)
                {
                    CmbAutor.SelectedValue = idSeleccionar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar autores: " + ex.Message);
            }
        }
    }
}
