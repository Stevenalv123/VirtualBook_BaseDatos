using Newtonsoft.Json;
using VirtualBook.Controller;
//using VirtualBook.DTOs;

namespace VirtualBook.Views.AdminViews
{
    public partial class AdministradorMainForm : Form, IMainForm
    {
        private Form? ActiveForm;
        private readonly ApiClient _apiClient;

        public AdministradorMainForm()
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
            CargarUsuario();
            MostrarBookInfoForms();
        }

        public void OpenForm(Form ChildForm)
        {
            if (ActiveForm != null) ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            TemaManager.AplicarTema(ChildForm, TemaManager.ModoOscuroActivo);
            PanelCentral.Controls.Add(ChildForm);
            PanelCentral.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
        }

        private void MostrarBookInfoForms()
        {
            if (IsFormOpen(typeof(AdminDashboardForm))) return;
            OpenForm(new AdminDashboardForm(this));
        }

        private void BtnVerUsuarios_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(AdminFormUsers))) return;
            OpenForm(new AdminFormUsers());

        }

        private void MostraMenuPrincipalForms_Click(object sender, EventArgs e)
        {
            MostrarBookInfoForms();
        }

        public async void CargarUsuario()
        {
            try
            {
                var usuario = await _apiClient.LoginUsers.GetMyProfileAsync();
                if (usuario != null)
                {
                    PcbCargandoUser.Visible = false;
                    LblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
                    LblCorreo.Text = usuario.Correo_Electronico;

                    if (!string.IsNullOrEmpty(usuario.FotoPerfil))
                    {
                        string fullImageUrl = _apiClient.RootUrl + usuario.FotoPerfil.TrimStart('/');
                        PcbPerfilFoto.LoadAsync(fullImageUrl);
                    }
                    else
                    {
                        PcbPerfilFoto.Image = Properties.Resources.avatar1;
                    }
                }
                else
                {
                    PcbCargandoUser.Visible = true;
                    MessageBox.Show("No se pudo cargar la información del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                PcbCargandoUser.Visible = false;
                MessageBox.Show($"Error al cargar el usuario: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            Mostrarsubmenu(PanelConfiguracion);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void BtnVerReportesDescargas_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(AdminDescargasForm))) return;
            OpenForm(new AdminDescargasForm());
        }

        private void BtnCambiarTema_Click(object sender, EventArgs e)
        {
            CambiarTema();
        }

        private void CambiarTema()
        {
            bool activarModoOscuro = !TemaManager.ModoOscuroActivo;
            TemaManager.AplicarTema(this, activarModoOscuro);
            BtnCambiarTema.IconChar = activarModoOscuro ? FontAwesome.Sharp.IconChar.Sun : FontAwesome.Sharp.IconChar.Moon;
            BtnCambiarTema.IconColor = activarModoOscuro ? Color.White : Color.Black;
        }

        void IMainForm.OpenForm(Form child)
        {
            OpenForm(child);
        }
    }
}
