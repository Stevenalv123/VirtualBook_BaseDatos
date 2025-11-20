using System.Configuration;
using System.Drawing.Drawing2D;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;
using VirtualBook.UserControls;

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
            _apiRootUrl = ConfigurationManager.AppSettings["ApiRootURL"]!;

            pnlTabs.BackColor = Color.White;
            pnlTabs.Padding = new Padding(15, 10, 0, 10); 
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

        public void MostrarLibrosEnPantalla(List<LibroDto> listaLibros)
        {
            flpLibros.Controls.Clear();

            if (listaLibros == null || listaLibros.Count == 0)
            {
                Label LblnoResults = new Label
                {
                    Text = "No se encontraron libros.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14F, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                return;
            }

            foreach (var libro in listaLibros)
            {
                var tarjeta = new LibroCard();
                tarjeta.Titulo = libro.Titulo;
                tarjeta.Autor = libro.Autores;
                tarjeta.Sinopsis = libro.NombreCategoria;

                if (!string.IsNullOrEmpty(libro.Portada))
                {
                    tarjeta.UrlPortada = _apiRootUrl + libro.Portada;
                }

                tarjeta.DetallesClick += (s, e) => AbrirDetallesLibro(libro.IdLibro);

                flpLibros.Controls.Add(tarjeta);
            }
        }

        public async Task CargarLibros()
        {
            PcbCargando.Visible = true;
            try
            {
                var libros = await _apiClient.Libros.GetLibrosAsync();
                MostrarLibrosEnPantalla(libros);
            }
            catch (Exception ex)
            {
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
