using System.Net.Http.Json;
//using VirtualBook.DTOs;
using VirtualBook.Views.GeneralViews;

namespace VirtualBook.Views.UploadBookForm
{
    public partial class UploadBookForm : Form
    {
        Label lblSoltarAqui;
        string baseUrl = "https://localhost:7014/api/";
        HttpClient cliente = new();
        int _idUsuario;
        private string portada { get; set; }
        private string archivoPdf { get; set; }
        IMainForm _mf;

        public UploadBookForm(int idUsuario, IMainForm mf)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            PcbLibroPortada.AllowDrop = true;
            lblSoltarAqui = new Label();
            _mf = mf;
            CrearLabel(lblSoltarAqui);
            CargarAutores();
            CargarCategorias();
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

        private async void BtnAgregarLibro_Click(object sender, EventArgs e)
        {
            SubirLibro(archivoPdf, portada);
        }

        private async Task SubirLibro(string archivoPdf, string archivoPortada)
        {
            //var autorSeleccionado = LstAutores.SelectedItem as ReadAutorDTO;
            //var categoriaSeleccionada = CmbCategoria.SelectedItem as ReadCategoriaDTO;

            //var form = new MultipartFormDataContent();

            ////Leer archivo pdf
            //var pdfBytes = File.ReadAllBytes(archivoPdf);
            //var contenidoPdf = new ByteArrayContent(pdfBytes);
            //contenidoPdf.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/pdf");

            ////Leer portada
            //var portadaBytes = File.ReadAllBytes(archivoPortada);
            //var contenidoPortada = new ByteArrayContent(portadaBytes);
            //contenidoPortada.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("image/jpeg");

            ////Agregar contenido al formulario
            //form.Add(new StringContent(TxtTitulo.Text), "Titulo");
            //form.Add(new StringContent(autorSeleccionado.IdAutor.ToString()), "Autor");
            //form.Add(new StringContent(_idUsuario.ToString()), "Publicador");
            //form.Add(new StringContent(categoriaSeleccionada.IdCategoria.ToString()), "IdCategoria");
            //form.Add(new StringContent(TxtFormato.Text), "Formato");
            //form.Add(new StringContent(CmbIdioma.Text), "Idioma");
            //form.Add(new StringContent(TxtNumeroPaginas.Text), "NumeroPaginas");
            //form.Add(new StringContent(DateTime.Now.ToString("yyyy-MM-dd")), "FechaPublicacion");
            //form.Add(new StringContent(TxtDescripcion.Text), "Descripcion");

            ////Agregar archivos
            //form.Add(contenidoPdf, "ArchivoPdf", "libro.pdf");
            //form.Add(contenidoPortada, "Portada", "portada.jpg");

            //try
            //{
            //    var respuesta = await cliente.PostAsync($"{baseUrl}Libroes", form);
            //    if (respuesta.IsSuccessStatusCode)
            //    {
            //        MessageBox.Show("Libro subido correctamente.");
            //        var menu = new AdminDashboardForm(_mf, _idUsuario);
            //        _mf.OpenForm(menu);
            //    }
            //    else
            //    {
            //        MessageBox.Show($"Error en la API: {respuesta.StatusCode}");
            //    }
            //}
            //catch (HttpRequestException ex)
            //{
            //    MessageBox.Show("Error de conexión con la API: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Otro error: " + ex.Message);
            //}
        }

        private async void CargarAutores()
        {
            //var response = await cliente.GetAsync($"{baseUrl}Autores");
            //if (response.IsSuccessStatusCode)
            //{
            //    var autores = await response.Content.ReadFromJsonAsync<List<ReadAutorDTO>>();
            //    LstAutores.DataSource = autores;
            //    LstAutores.DisplayMember = "NombreAutor";
            //    LstAutores.ValueMember = "IdAutor";
            //}
            //else
            //{
            //    var error = await response.Content.ReadAsStringAsync();
            //    MessageBox.Show($"Error al cargar los autores.{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private async void CargarCategorias()
        {
            //try
            //{
            //    var response = await cliente.GetAsync($"{baseUrl}Categorias");
            //    response.EnsureSuccessStatusCode();

            //    var categorias = await response.Content.ReadFromJsonAsync<List<ReadCategoriaDTO>>();
            //    if (categorias != null)
            //    {
            //        CmbCategoria.DataSource = categorias;
            //        CmbCategoria.DisplayMember = "NombreCategoria";
            //        CmbCategoria.ValueMember = "IdCategoria";
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al cargar las categorias.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void LstAutores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (LstAutores.SelectedItem is ReadAutorDTO autorSeleccionado)
            //{
            //    TxtAutor.Text = autorSeleccionado.NombreAutor;
            //    LstAutores.Visible = false;
            //}
        }

        private void TxtAutor_Enter(object sender, EventArgs e)
        {
            LstAutores.Visible = true;
        }

        private void TxtAutor_Leave(object sender, EventArgs e)
        {
            //if (!LstAutores.Bounds.Contains(PointToClient(Cursor.Position)))
            //    LstAutores.Visible = false;
        }

        private void BtnAgregarAutor_Click(object sender, EventArgs e)
        {
            var nuevoAutorForm = new NuevoAutorForm();
            nuevoAutorForm.FormClosed += (s, e) => CargarAutores();
            nuevoAutorForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int rol=Cookies.GetRol();

            if (rol == 1)
            {
                var menu = new AdminDashboardForm(_mf, _idUsuario);
                _mf.OpenForm(menu);
            }
            else
            {
                var menu = new DocentesViews.DocentesViews(_idUsuario, _mf);
                _mf.OpenForm(menu);
            }
        }
    }
}
