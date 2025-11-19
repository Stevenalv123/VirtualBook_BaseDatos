using FontAwesome.Sharp;
using VirtualBook.Controller;
using VirtualBook.Views.GeneralViews.UserControls;

namespace VirtualBook.Views
{
    public partial class BookInfoForms : Form
    {
        private readonly int _idlibro;
        private readonly IMainForm _mf;
        private readonly ApiClient _apiClient;
        private int _idPublicador;
        private string? _rutaPdfRelativa;
        private bool _esFavorito = false;
        private bool _esSeguidor = false;

        public BookInfoForms(int id, IMainForm mf)
        {
            InitializeComponent();

            _idlibro = id;
            _mf = mf;
            _apiClient = ApiClient.Instance;
            _ = VerificarEstadoSeguimiento();

            ConfigurarEstilos();

            _ = CargarInfoLibro();
            _ = CargarResenas();
        }

        private void ConfigurarEstilos()
        {
            BtnLeer.BackColor = Color.FromArgb(45, 154, 134);
            BtnSeguir.BackColor = Color.FromArgb(45, 154, 134);
            btnEnviarResena.BackColor = Color.FromArgb(45, 154, 134); 
            BtnAgregarFavoritos.BackColor = Color.White;
            BtnAgregarFavoritos.ForeColor = Color.Black;
            BtnAgregarFavoritos.FlatStyle = FlatStyle.Flat;
            BtnAgregarFavoritos.FlatAppearance.BorderSize = 0;


            flpReseñas.AutoScroll = true;
            flpReseñas.WrapContents = false;
            flpReseñas.FlowDirection = FlowDirection.TopDown;
        }

        private async Task CargarInfoLibro()
        {
            PcbCargando.Visible = true;
            PcbCargando.BringToFront();

            try
            {
                var libro = await _apiClient.Libros.GetLibroDetalleAsync(_idlibro);

                if (libro == null)
                {
                    MessageBox.Show("Libro no encontrado.");
                    this.Close();
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
                LblDescargas.Text = libro.Descargas + " Descargas";
                LblNumeroPaginas.Text = libro.NumeroPaginas + " Páginas";
                LblAñoPublicacion.Text = libro.FechaPublicacion.ToString("yyyy");
                _rutaPdfRelativa = libro.ArchivoPDF;

                if (!string.IsNullOrEmpty(libro.PublicadorFotoPerfil))
                    PcbFotoPerfilPublicador.LoadAsync(_apiClient.RootUrl + libro.PublicadorFotoPerfil.TrimStart('/'));
                else
                    PcbFotoPerfilPublicador.Image = Properties.Resources.avatar;

                if (!string.IsNullOrEmpty(libro.Portada))
                {
                    PcbPortada.LoadAsync(_apiClient.RootUrl + libro.Portada.TrimStart('/'));
                    PcbPortada.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                    PcbPortada.Image = Properties.Resources.placeholder;

                await ActualizarEstadoFavorito();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar: {ex.Message}");
            }
            finally
            {
                PcbCargando.Visible = false;
            }
        }


        private async Task CargarResenas()
        {
            try
            {
                flpReseñas.Controls.Clear();

                var resenas = await _apiClient.Libros.GetReseñasPorLibroAsync(_idlibro);

                if (resenas != null && resenas.Count > 0)
                {
                    foreach (var r in resenas)
                    {
                        var card = new ReseñasCard();
                        string urlFoto = string.IsNullOrEmpty(r.FotoPerfil) ? null :
                                         _apiClient.RootUrl + r.FotoPerfil.TrimStart('/');

                        card.ConfigurarDatos(r.NombreUsuario, r.Comentario, urlFoto);

                        card.Width = flpReseñas.Width - 25;
                        card.Margin = new Padding(0, 0, 0, 10);
                        flpReseñas.Controls.Add(card);
                    }
                }
                else
                {
                    Label lbl = new Label();
                    lbl.Text = "No hay reseñas para este libro aún.";
                    lbl.AutoSize = true;
                    lbl.ForeColor = Color.Gray;
                    lbl.Font = new Font("Segoe UI", 12, FontStyle.Italic);
                    lbl.Margin = new Padding(20);
                    flpReseñas.Controls.Add(lbl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando reseñas: {ex.Message}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task VerificarEstadoSeguimiento()
        {
            try
            {
                if (_idPublicador > 0)
                {
                    _esSeguidor = await _apiClient.LoginUsers.VerificarSiSigueAsync(_idPublicador);
                    ActualizarBotonSeguirUI();
                }
            }
            catch {  }
        }

        private void ActualizarBotonSeguirUI()
        {
            if (_esSeguidor)
            {
                BtnSeguir.Text = "Siguiendo";
                BtnSeguir.BackColor = Color.Gray; 
                //BtnSeguir.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            }
            else
            {
                BtnSeguir.Text = "Seguir";
                BtnSeguir.BackColor = Color.FromArgb(45, 154, 134); 
                //BtnSeguir.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            }
        }

        private async void btnEnviarResena_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReseña.Text))
            {
                MessageBox.Show("Escribe un comentario primero.");
                return;
            }

            btnEnviarResena.Enabled = false;
            txtReseña.Enabled = false;

            try
            {
                bool exito = await _apiClient.Libros.PublicarReseñaAsync(_idlibro, txtReseña.Text.Trim());

                if (exito)
                {
                    MessageBox.Show("Reseña publicada correctamente.");
                    txtReseña.Text = "";
              
                    await CargarResenas();
                }
                else
                {
                    MessageBox.Show("No se pudo publicar la reseña.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                btnEnviarResena.Enabled = true;
                txtReseña.Enabled = true;
            }
        }


        private async Task ActualizarEstadoFavorito()
        {
            try
            {
                _esFavorito = await _apiClient.Libros.VerificarFavoritoAsync(_idlibro);
                ActualizarBotonUI();
            }
            catch { }
        }

        private void ActualizarBotonUI()
        {
            if (_esFavorito)
            {
                BtnAgregarFavoritos.Text = "Quitar de Favoritos";
                BtnAgregarFavoritos.IconChar = MaterialIcons.Heart;
                BtnAgregarFavoritos.IconColor = Color.Crimson;
            }
            else
            {
                BtnAgregarFavoritos.Text = "Agregar a Favoritos";
                BtnAgregarFavoritos.IconChar = MaterialIcons.HeartOutline;
                BtnAgregarFavoritos.IconColor = Color.Black;
            }
        }

        private async void BtnAgregarFavoritos_Click(object sender, EventArgs e)
        {
            BtnAgregarFavoritos.Enabled = false;
            try
            {
                bool exito = false;
                if (_esFavorito)
                {
                    exito = await _apiClient.Libros.EliminarFavoritoAsync(_idlibro);
                    if (exito) { _esFavorito = false; MessageBox.Show("Eliminado de favoritos."); }
                }
                else
                {
                    exito = await _apiClient.Libros.AgregarFavoritoAsync(_idlibro);
                    if (exito) { _esFavorito = true; MessageBox.Show("Agregado a favoritos."); }
                }
                if (exito) ActualizarBotonUI();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { BtnAgregarFavoritos.Enabled = true; }
        }


        private async void BtnLeer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_rutaPdfRelativa)) return;
            try
            {
                byte[] pdfBytes = await _apiClient.Libros.DescargarArchivoLibroAsync(_idlibro);
                string tempPath = Path.Combine(Path.GetTempPath(), $"Lectura_{_idlibro}_{DateTime.Now.Ticks}.pdf");
                await File.WriteAllBytesAsync(tempPath, pdfBytes);
                new PdfVisorForm(tempPath).Show();
            }
            catch (Exception ex) { MessageBox.Show($"Error: {ex.Message}"); }
        }

        private async void BtnDescargar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_rutaPdfRelativa)) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF Files|*.pdf";
                sfd.FileName = $"{LblTitulo.Text}.pdf";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        byte[] pdfBytes = await _apiClient.Libros.DescargarArchivoLibroAsync(_idlibro);
                        await File.WriteAllBytesAsync(sfd.FileName, pdfBytes);
                        MessageBox.Show("Descargado correctamente.");
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            _mf.OpenForm(new MenuPrincipalFormcs(_mf));
        }

        private async void BtnSeguir_Click(object sender, EventArgs e) 
        {
            if (_idPublicador <= 0) return;

            BtnSeguir.Enabled = false; 

            try
            {
                _esSeguidor = await _apiClient.LoginUsers.ToggleSeguirUsuarioAsync(_idPublicador);

                ActualizarBotonSeguirUI();

                string mensaje = _esSeguidor ? "¡Ahora sigues a este usuario!" : "Dejaste de seguir a este usuario.";
                MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BtnSeguir.Enabled = true;
            }
        }
    }
}