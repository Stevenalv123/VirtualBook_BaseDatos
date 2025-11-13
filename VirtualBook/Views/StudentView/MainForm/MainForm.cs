using System.Net.Http.Json;
using VirtualBook.Controller;

namespace VirtualBook.Views
{
    public partial class MainForm : Form, IMainForm
    {
        private ApiClient _apiClient;
        private MenuPrincipalFormcs mPf; // Declare without initialization
        private Form? activeForm = null;
        


        public MainForm(ApiClient apiClient)
        {
            InitializeComponent();
            _apiClient = apiClient;

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
        }
    }
}
