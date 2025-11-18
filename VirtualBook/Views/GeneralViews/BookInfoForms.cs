using VirtualBook.Controller;

namespace VirtualBook.Views
{
    public partial class BookInfoForms : Form
    {
        // Campos de clase
        private readonly int _idlibro;
        private readonly IMainForm _mf;
        private readonly ApiClient _apiClient;

        private int _idPublicador;
        private string? _rutaPdfRelativa;

        public BookInfoForms(int id, IMainForm mf)
        {
            InitializeComponent();

            _idlibro = id;
            _mf = mf;
            _apiClient = ApiClient.Instance;

            // Estilos
            BtnLeer.BackColor = Color.FromArgb(45, 154, 134);
            BtnSeguir.BackColor = Color.FromArgb(45, 154, 134);
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
                LblDescargas.Text = libro.Descargas.ToString() + " Descargas";
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
        private async void BtnLeer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_rutaPdfRelativa))
            {
                MessageBox.Show("Este libro no tiene un archivo PDF asociado.", "Aviso");
                return;
            }

            PcbCargando.Visible = true;
            BtnLeer.Enabled = false;

            try
            {
                byte[] pdfBytes = await _apiClient.Libros.DescargarArchivoLibroAsync(_idlibro);
                string tempPath = Path.Combine(Path.GetTempPath(), $"Lectura_{_idlibro}.pdf");
                await File.WriteAllBytesAsync(tempPath, pdfBytes);
                var visor = new PdfVisorForm(tempPath);
                visor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el libro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BtnLeer.Enabled = true;
                PcbCargando.Visible = false;
            }
        }

        private async void BtnDescargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_rutaPdfRelativa))
            {
                MessageBox.Show("Este libro no tiene archivo disponible para descargar.");
                return;
            }
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar libro como...";
                // Limpiamos el título de caracteres inválidos para nombre de archivo
                string nombreLimpio = string.Join("_", LblTitulo.Text.Split(Path.GetInvalidFileNameChars()));
                saveFileDialog.FileName = $"{nombreLimpio}.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        this.Cursor = Cursors.WaitCursor;
                        byte[] pdfBytes = await _apiClient.Libros.DescargarArchivoLibroAsync(_idlibro);

                        await File.WriteAllBytesAsync(saveFileDialog.FileName, pdfBytes);

                        MessageBox.Show("Libro descargado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al descargar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Cursor = Cursors.Default;
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
