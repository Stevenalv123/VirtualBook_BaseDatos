using System.Net.Http.Json;
using VirtualBook.DTOs;

namespace VirtualBook.Views
{
    public partial class MainForm : Form, IMainForm
    {
        private string baseUrl = "https://localhost:7014/api/Usuarios";
        private string base_Url = "https://localhost:7014/api/";
        private HttpClient cliente = new();
        private MenuPrincipalFormcs mPf; // Declare without initialization
        private Form? activeForm = null;
        int idUsuario = 0;


        public MainForm(int IdUsuario)
        {
            InitializeComponent();
            idUsuario = IdUsuario;

            mPf = new MenuPrincipalFormcs(this); 
            OpenForm(mPf); 
            CargarUsuario();
        }

        private void BtnSwitchTheme_Click(object sender, EventArgs e)
        {
            CambiarTema();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            OpenForm(new FavoritosForm(this));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(PanelConfiguracion);
        }

        public void Mostrarsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                ocultarsubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        public void ocultarsubmenu()
        {
            if (PanelConfiguracion.Visible == true)
            {
                PanelConfiguracion.Visible = false;
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Cookies.EliminarCookie();
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private async void btnBuscarlibro_Click(object sender, EventArgs e)
        {
            string searchTerm = TxtBucarLibros.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                // Si no hay nada que buscar, mostramos todos los libros otra vez
                await mPf.CargarLibros();
                return;
            }

            var response = await cliente.GetAsync($"{base_Url}Libroes");
            response.EnsureSuccessStatusCode();

            var libros = await response.Content.ReadFromJsonAsync<List<ReadVistaPreviaLibro>>();

            var librosFiltrados = libros
        .Where(libro => libro.Titulo.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase))
        .ToList();

            if (mPf != null)
            {
                mPf.MostrarLibrosFiltrados(librosFiltrados);
            }


        }
    }
}
