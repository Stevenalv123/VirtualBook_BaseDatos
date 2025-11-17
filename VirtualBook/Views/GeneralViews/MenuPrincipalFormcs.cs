using System.Configuration;
using System.Drawing.Drawing2D;
using VirtualBook.Controller;
using VirtualBook.UserControls;
//using VirtualBook.DTOs;

namespace VirtualBook.Views
{
    public partial class MenuPrincipalFormcs : Form
    {
        private readonly ApiClient _apiClient;
        private readonly string _apiRootUrl;

        IMainForm mainform;
        public MenuPrincipalFormcs(IMainForm mf)
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
            _apiRootUrl = ConfigurationManager.AppSettings["ApiRootURL"]!; // URL raíz del App.config

            pnlTabs.BackColor = Color.White;
            pnlTabs.Padding = new Padding(15, 10, 0, 10); // Espacio interno
            pnlTabs.BorderStyle = BorderStyle.None;

            RedondearBoton(btnBrowseBooks, 30);
            RedondearBoton(btnRecommended, 30);
            RedondearBoton(btnRecentlyViewed, 30);

            _ = CargarLibros();
            mainform = mf;
        }

        private void EstilizarBotonesTab()
        {
            Button[] botones = { btnBrowseBooks, btnRecentlyViewed, btnRecommended };

            foreach (var btn in botones)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                btn.Height = 35;
                btn.Margin = new Padding(10);
                btn.Padding = new Padding(10, 5, 10, 5);
            }

            // Opción activa destacada
            btnBrowseBooks.BackColor = Color.LightGray;
        }

        private void btnBrowseBooks_Click(object sender, EventArgs e)
        {
            SetActiveTab(btnBrowseBooks);
        }

        private void SetActiveTab(Button active)
        {
            Button[] botones = { btnBrowseBooks, btnRecentlyViewed, btnRecommended };

            foreach (var btn in botones)
            {
                btn.BackColor = Color.White;
            }

            active.BackColor = Color.LightGray;
        }

        private void btnRecentlyViewed_Click(object sender, EventArgs e)
        {
            SetActiveTab(btnRecentlyViewed);
        }

        private void btnRecommended_Click(object sender, EventArgs e)
        {
            SetActiveTab(btnRecommended);
        }

        private void RedondearBoton(Button boton, int radio)
        {
            Rectangle bounds = new Rectangle(0, 0, boton.Width, boton.Height);
            GraphicsPath path = new GraphicsPath();

            float r = radio;
            path.StartFigure();
            path.AddArc(bounds.X, bounds.Y, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Y, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            boton.Region = new Region(path);
        }

        public async Task CargarLibros()
        {
            flpLibros.Controls.Clear();
            PcbCargando.Visible = true;
            PcbCargando.BringToFront();
            try
            {
                var libros = await _apiClient.Libros.GetLibrosAsync();

                if (libros != null)
                {
                    foreach (var libro in libros)
                    {
                        var tarjeta = new LibroCard();
                        tarjeta.Titulo = libro.Titulo;
                        tarjeta.Autor = libro.Autores;
                        tarjeta.Sinopsis = libro.NombreCategoria;

                        if (!string.IsNullOrEmpty(libro.Portada))
                        {
                            tarjeta.UrlPortada = _apiRootUrl + libro.Portada;
                        }

                        // MAEEEEE este evento hay que descomentarlo para abrir el Form BookInfoForms
                        tarjeta.Click += (s, e) => AbrirDetallesLibro(libro.IdLibro);
                        foreach (Control c in tarjeta.Controls)
                        {
                            c.Click += (s, e) => AbrirDetallesLibro(libro.IdLibro);
                        }

                        flpLibros.Controls.Add(tarjeta);
                    }
                }
                PcbCargando.Visible = false;
            }
            catch (Exception ex)
            {
                PcbCargando.Visible = false;
                MessageBox.Show("Error al cargar libros: " + ex.Message);
            }
            finally
            {
                PcbCargando.Visible = false;
            }
        }

        private void AbrirDetallesLibro(int libroId)
        {
            var detallesForm = new BookInfoForms(libroId, mainform);
            mainform.OpenForm(detallesForm);
        }
    }
}
