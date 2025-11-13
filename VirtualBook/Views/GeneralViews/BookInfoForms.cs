using System.Net.Http.Json;
//using VirtualBook.DTOs;
//using VirtualBook_WebAPI.Models;

namespace VirtualBook.Views
{
    public partial class BookInfoForms : Form
    {
        int idlibro;
        string baseUrl = "https://localhost:7014/api/";
        int _idPublicador;
        string? _rutaPdf;
        byte[] _archivoPdf;
        HttpClient client = new();
        IMainForm _mf;
        public BookInfoForms(int id, IMainForm mf)
        {
            InitializeComponent();
            idlibro = id;
            CargarInfoLibro();
            _mf = mf;
            BtnLeer.BackColor = Color.FromArgb(45, 154, 134);
            BtnSeguir.BackColor = Color.FromArgb(45, 154, 134);
        }

        private async void CargarInfoLibro()
        {
            //try
            //{
            //    var libro = await client.GetFromJsonAsync<ReadLibroDTO>($"{baseUrl}Libroes/{idlibro}");
            //    if (libro == null)
            //    {
            //        MessageBox.Show("Libro no encontrado");
            //        return;
            //    }
            //    if (libro != null)
            //    {
            //        LblTitulo.Text = libro.Titulo;
            //        LblAutor.Text = libro.Autor;
            //        LblCategoria.Text = libro.Categoria;
            //        LblPublicadoPor.Text = libro.Publicador;
            //        _idPublicador = libro.PublicadorId; // Asigna el ID del publicador para usarlo al seguir
            //        LblDescripcion.Text = libro.Descripcion;
            //        LblFormato.Text = libro.Formato;
            //        LblIdioma.Text = libro.Idioma;
            //        LblNumeroPaginas.Text = libro.NumeroPaginas.HasValue ? libro.NumeroPaginas.Value.ToString() + " Paginas" : "N/A";
            //        LblAñoPublicacion.Text = libro.FechaPublicacion.ToString("yyyy");
            //        VerificarSiSigue();
            //        PcbFotoPerfilPublicador.Image = null; // Limpia la imagen antes de cargar una nueva
            //        PcbFotoPerfilPublicador.Image = libro.FotoPublicador != null && libro.FotoPublicador.Length > 0
            //            ? Image.FromStream(new MemoryStream(libro.FotoPublicador))
            //            : Properties.Resources.avatar; // Usa una imagen por defecto si no hay foto
            //        if (libro.Portada != null && libro.Portada.Length > 0)
            //        {
            //            using (var ms = new MemoryStream(libro.Portada))
            //            {
            //                PcbPortada.Image = Image.FromStream(ms);
            //                PcbPortada.SizeMode = PictureBoxSizeMode.Zoom;
            //            }
            //        }
            //        else
            //        {
            //            PcbPortada.Image = null;
            //        }

            //        if (libro.ArchivoPdf != null && libro.ArchivoPdf.Length > 0)
            //        {
            //            string rutaTemporal = Path.Combine(Path.GetTempPath(), $"libro_{idlibro}.pdf");
            //            File.WriteAllBytes(rutaTemporal, libro.ArchivoPdf);
            //            _rutaPdf = rutaTemporal; // Guarda la ruta para usarla al leer
            //            _archivoPdf = libro.ArchivoPdf; // Guarda el archivo PDF en memoria
            //        }
            //        PcbCargando.Visible = false; // Oculta el icono de carga una vez que la información se ha cargado
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error al cargar la información del libro: {ex.Message}");
            //}
        }

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_rutaPdf) && File.Exists(_rutaPdf))
            {
                var visor = new PdfVisorForm(_rutaPdf);
                visor.Show();
            }
            else
            {
                MessageBox.Show("El archivo PDF no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnDescargar_Click(object sender, EventArgs e)
        {
            if (_archivoPdf == null || _archivoPdf.Length == 0)
            {
                MessageBox.Show("El archivo PDF no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar libro como...";
                saveFileDialog.FileName = LblTitulo.Text + ".pdf"; // Usa el título del libro

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        //File.WriteAllBytes(saveFileDialog.FileName, _archivoPdf);
                        //MessageBox.Show("Libro descargado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //var response = await client.PostAsJsonAsync($"{baseUrl}Descargas", new CreateDescargaDTO
                        //{
                        //    Usuario = Cookies.GetId(),
                        //    Libro = idlibro,
                        //    FechaDescarga = DateTime.Now
                        //});
                        //if (!response.IsSuccessStatusCode)
                        //{
                        //    string error = await response.Content.ReadAsStringAsync();
                        //    MessageBox.Show($"Error al registrar la descarga: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            var menu = new MenuPrincipalFormcs(_mf);
            _mf.OpenForm(menu);
        }

        private async void VerificarSiSigue()
        {
            var response = await client.GetAsync($"{baseUrl}Seguimientoes/Existe?seguidor={Cookies.GetId()}&seguido={_idPublicador}");
            if (response.IsSuccessStatusCode)
            {
                bool yaSigue = bool.Parse(await response.Content.ReadAsStringAsync());
                if (yaSigue)
                {
                    BtnSeguir.BackColor = Color.LightGray;
                    BtnSeguir.Text = "Siguiendo";
                    BtnSeguir.Enabled = false;
                }
            }
            else
            {
                var error = response.Content.ReadAsStringAsync().Result;
                MessageBox.Show($"Error al verificar seguimiento: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnSeguir_Click(object sender, EventArgs e)
        {
            //var seguimiento = new CreateSeguimientoDTO
            //{
            //    IdSeguidor = Cookies.GetId(), // O como tengas el ID guardado
            //    IdSeguido = _idPublicador
            //};

            //try
            //{
            //    var response = await client.PostAsJsonAsync($"{baseUrl}Seguimientoes", seguimiento);

            //    if (response.IsSuccessStatusCode)
            //    {
            //        BtnSeguir.BackColor = Color.LightGray; // Cambia el color del botón para indicar que se ha seguido
            //        BtnSeguir.Text = "Siguiendo"; // Cambia el texto del botón
            //        BtnSeguir.Enabled = false; // Deshabilita el botón para evitar seguir varias veces
            //    }
            //    else
            //    {
            //        string error = await response.Content.ReadAsStringAsync();
            //        MessageBox.Show($"Error al seguir: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error de conexión: {ex.Message}");
            //}
        }

        private void BtnAgregarFavoritos_Click(object sender, EventArgs e)
        {
            //var favorito = new CreateFavoritoDTO
            //{
            //    IdUsuario = Cookies.GetId(),
            //    IdLibro = idlibro
            //};

            //try
            //{
            //    var response = client.PostAsJsonAsync($"{baseUrl}Favoritos", favorito).Result;
            //    if (response.IsSuccessStatusCode)
            //    {
            //        BtnAgregarFavoritos.Text = "Quitar de favoritos";
            //        BtnAgregarFavoritos.IconChar = (FontAwesome.Sharp.MaterialIcons)FontAwesome.Sharp.IconChar.HeartBroken; // Cambia el icono para indicar que ahora es un favorito
            //        BtnAgregarFavoritos.Enabled = false; // Deshabilita el botón para evitar agregar varias veces
            //    }
            //    else
            //    {
            //        string error = response.Content.ReadAsStringAsync().Result;
            //        MessageBox.Show($"Error al agregar a favoritos: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Error de conexión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
