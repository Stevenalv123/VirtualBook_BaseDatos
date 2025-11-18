using FontAwesome.Sharp.Material; // Importante para los iconos Material
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.Controller;

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
        private string? _rutaPdfRelativa;

        // Estado de favorito
        private bool _esFavorito = false;

        public BookInfoForms(int id, IMainForm mf)
        {
            InitializeComponent();

            _idlibro = id;
            _mf = mf;
            _apiClient = ApiClient.Instance;

            // Estilos iniciales
            ConfigurarBotones();

            // Cargar datos (sin bloquear la UI)
            _ = CargarInfoLibro();
        }

        private void ConfigurarBotones()
        {
            BtnLeer.BackColor = Color.FromArgb(45, 154, 134);
            BtnSeguir.BackColor = Color.FromArgb(45, 154, 134);

            // Configuración base del botón de favoritos
            BtnAgregarFavoritos.BackColor = Color.White;
            BtnAgregarFavoritos.ForeColor = Color.Black;
            BtnAgregarFavoritos.FlatStyle = FlatStyle.Flat;
            BtnAgregarFavoritos.FlatAppearance.BorderSize = 0;
        }

        private async Task CargarInfoLibro()
        {
            // Mostrar cargando
            PcbCargando.Visible = true;
            PcbCargando.BringToFront();

            try
            {
                // 1. Cargar detalles del libro
                var libro = await _apiClient.Libros.GetLibroDetalleAsync(_idlibro);

                if (libro == null)
                {
                    MessageBox.Show("Libro no encontrado o error al cargar.");
                    this.Close();
                    return;
                }

                // 2. Llenar la UI con los datos
                LlenarDatosLibro(libro);

                // 3. Verificar si es favorito para pintar el botón correctamente
                await ActualizarEstadoFavorito();
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

        private void LlenarDatosLibro(Models.DTO.LibroDetalleDTO libro)
        {
            LblTitulo.Text = libro.Titulo;
            LblAutor.Text = libro.Autores;
            LblCategoria.Text = libro.NombreCategoria;
            LblPublicadoPor.Text = libro.PublicadorNombre;
            _idPublicador = libro.PublicadorId;
            LblDescripcion.Text = libro.Descripcion;
            LblFormato.Text = libro.NombreFormato;
            LblIdioma.Text = libro.NombreIdioma;
            LblNumeroPaginas.Text = libro.NumeroPaginas.HasValue ? libro.NumeroPaginas.Value.ToString() + " Páginas" : "N/A";
            LblAñoPublicacion.Text = libro.FechaPublicacion.ToString("yyyy");

            _rutaPdfRelativa = libro.ArchivoPDF;

            // Cargar foto publicador
            if (!string.IsNullOrEmpty(libro.PublicadorFotoPerfil))
                PcbFotoPerfilPublicador.LoadAsync(_apiClient.RootUrl + libro.PublicadorFotoPerfil.TrimStart('/'));
            else
                PcbFotoPerfilPublicador.Image = Properties.Resources.avatar;

            // Cargar portada
            if (!string.IsNullOrEmpty(libro.Portada))
            {
                PcbPortada.LoadAsync(_apiClient.RootUrl + libro.Portada.TrimStart('/'));
                PcbPortada.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                PcbPortada.Image = Properties.Resources.placeholder;
            }
        }

        // --- LÓGICA DE FAVORITOS ---

        private async Task ActualizarEstadoFavorito()
        {
            // Consulta a la API si este libro es favorito del usuario actual
            _esFavorito = await _apiClient.Libros.VerificarFavoritoAsync(_idlibro);
            ActualizarBotonFavoritoUI();
        }



        private void ActualizarBotonFavoritoUI()
        {
            if (_esFavorito)
            {
                BtnAgregarFavoritos.Text = "Eliminar de Favoritos";
           
            }
            else
            {
                BtnAgregarFavoritos.Text = "Agregar a Favoritos";
         
            }
        }


        private async void BtnAgregarFavoritos_Click(object sender, EventArgs e)
        {
            BtnAgregarFavoritos.Enabled = false; // Evitar doble clic

            try
            {
                bool exito;

                if (_esFavorito)
                {
                    // Si ya es favorito -> Eliminar
                    exito = await _apiClient.Libros.EliminarFavoritoAsync(_idlibro);
                    if (exito)
                    {
                        _esFavorito = false;
                        MessageBox.Show("Libro eliminado de tus favoritos.", "Favoritos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    // Si no es favorito -> Agregar
                    exito = await _apiClient.Libros.AgregarFavoritoAsync(_idlibro);
                    if (exito)
                    {
                        _esFavorito = true;
                        MessageBox.Show("¡Libro agregado a tus favoritos!", "Favoritos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                // Actualizar el icono y texto si hubo éxito
                if (exito) ActualizarBotonFavoritoUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar favoritos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                BtnAgregarFavoritos.Enabled = true;
            }
        }

        // --- OTROS EVENTOS ---

        private void BtnLeer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_rutaPdfRelativa))
            {
                MessageBox.Show("El archivo PDF no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string urlPdf = _apiClient.RootUrl + _rutaPdfRelativa.TrimStart('/');
                var visor = new PdfVisorForm(urlPdf);
                visor.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el visor: {ex.Message}");
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            // Regresar al menú principal
            var menu = new MenuPrincipalFormcs(_mf);
            _mf.OpenForm(menu);
        }

        // Implementación futura para descargas
        private void BtnDescargar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Función de descarga próximamente.");
        }

        // Implementación futura para seguir usuario
        private void BtnSeguir_Click(object sender, EventArgs e)
        {
            // Lógica de seguimiento...
        }
    }
}