using System.Net.Http.Json;
using VirtualBook.Controller;
//using VirtualBook.DTOs;
//using VirtualBook_WebAPI.Models;

namespace VirtualBook.Views
{
    public partial class BookInfoForms : Form
    {
        // Campos de clase
        private readonly int _idlibro;
        private readonly IMainForm _mf;
        private readonly ApiClient _apiClient;

        // Datos del libro
        private int _idPublicador;
        private string? _rutaPdfRelativa; // La RUTA que viene de la API

        public BookInfoForms(int id, IMainForm mf)
        {
            InitializeComponent();

            _idlibro = id;
            _mf = mf;
            _apiClient = ApiClient.Instance;

            // Estilos
            BtnLeer.BackColor = Color.FromArgb(45, 154, 134);
            BtnSeguir.BackColor = Color.FromArgb(45, 154, 134);

            // Llama al método de carga (fíjate en el `_ =`)
            _ = CargarInfoLibro();
        }

        private async Task CargarInfoLibro()
        {
            try
            {
                // Llama al repositorio
                var libro = await _apiClient.Libros.GetLibroDetalleAsync(_idlibro);

                if (libro == null)
                {
                    MessageBox.Show("Libro no encontrado o error al cargar.");
                    PcbCargando.Visible = false;
                    return;
                }

                LblTitulo.Text = libro.Titulo;
                LblAutor.Text = libro.Autores;
                LblCategoria.Text = libro.NombreCategoria;
                LblPublicadoPor.Text = libro.PublicadorNombre;
                _idPublicador = libro.PublicadorId;
                LblDescripcion.Text = libro.Descripcion;
                LblFormato.Text = libro.NombreFormato;
                LblIdioma.Text = libro.NombreIdioma;
                LblNumeroPaginas.Text = libro.NumeroPaginas.HasValue ? libro.NumeroPaginas.Value.ToString() + " Paginas" : "N/A";
                LblAñoPublicacion.Text = libro.FechaPublicacion.ToString("yyyy");

                // Guardar la ruta del PDF
                _rutaPdfRelativa = libro.ArchivoPDF;

                // Cargar la foto del publicador
                if (!string.IsNullOrEmpty(libro.PublicadorFotoPerfil))
                {
                    PcbFotoPerfilPublicador.LoadAsync(_apiClient.RootUrl + libro.PublicadorFotoPerfil.TrimStart('/'));
                }
                else
                {
                    PcbFotoPerfilPublicador.Image = Properties.Resources.avatar;
                }

                // 5. Cargar la portada del libro
                if (!string.IsNullOrEmpty(libro.Portada))
                {
                    PcbPortada.LoadAsync(_apiClient.RootUrl + libro.Portada.TrimStart('/'));
                    PcbPortada.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    PcbPortada.Image = Properties.Resources.placeholder;
                }

                // (Lógica futura)
                // VerificarSiSigue(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la información del libro: {ex.Message}");
            }
            finally
            {
                PcbCargando.Visible = false;
            }
        }
        private void BtnLeer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_rutaPdfRelativa))
            {
                MessageBox.Show("El archivo PDF no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Esta es la URL completa al archivo en el servidor
                string urlPdf = _apiClient.RootUrl + _rutaPdfRelativa.TrimStart('/');

                var visor = new PdfVisorForm(urlPdf);
                visor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el visor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnDescargar_Click(object sender, EventArgs e)
        {
            /*if (_archivoPdf == null || _archivoPdf.Length == 0)
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

                
            }*/
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            var menu = new MenuPrincipalFormcs(_mf);
            _mf.OpenForm(menu);
        }

        private async void VerificarSiSigue()
        {
            /*var response = await client.GetAsync($"{baseUrl}Seguimientoes/Existe?seguidor={Cookies.GetId()}&seguido={_idPublicador}");
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
            }*/
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
