using System.Net.Http.Json;
using VirtualBook.Controller;
using VirtualBook.Views.GeneralViews;

namespace VirtualBook.Views
{
    public partial class MainForm : Form, IMainForm
    {
        private ApiClient _apiClient;
        private MenuPrincipalFormcs mPf;
        private Form? activeForm = null;

        public MainForm()
        {
            InitializeComponent();

            _apiClient = ApiClient.Instance;

            mPf = new MenuPrincipalFormcs(this);
            OpenForm(mPf);
            _ = CargarUsuario();
            tmrNotificaciones.Tick += TmrNotificaciones_Tick;
            tmrNotificaciones.Start();
            _ = VerificarNotificaciones();
        }

        private async void TmrNotificaciones_Tick(object sender, EventArgs e)
        {
            await VerificarNotificaciones();
        }

        private async Task VerificarNotificaciones()
        {
            int cantidad = await ApiClient.Instance.Notificaciones.ObtenerConteoNoLeidasAsync();

            ActualizarIconoCampana(cantidad);
        }

        private void ActualizarIconoCampana(int cantidad)
        {
            if (cantidad > 0)
            {
                BtnNotificaciones.IconChar = FontAwesome.Sharp.IconChar.Bell;

                BtnNotificaciones.IconColor = Color.OrangeRed;

                BtnNotificaciones.Text = $"   {cantidad}";
                BtnNotificaciones.ForeColor = Color.OrangeRed;
            }
            else
            {
                BtnNotificaciones.IconChar = FontAwesome.Sharp.IconChar.Bell;
                BtnNotificaciones.IconColor = Color.Black;
                BtnNotificaciones.Text = "";
                BtnNotificaciones.ForeColor = Color.Black;
            }
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
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private async void btnBuscarlibro_Click(object sender, EventArgs e)
        {

        }

        // Metodos
        public void OpenForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Hide();

            activeForm = ChildForm;

            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;

            TemaManager.AplicarTema(ChildForm, TemaManager.ModoOscuroActivo);

            PanelCentral.Controls.Clear();
            PanelCentral.Controls.Add(ChildForm);
            PanelCentral.Tag = ChildForm;

            ChildForm.BringToFront();
            ChildForm.Show();
        }

        public bool IsFormOpen(Type formType)
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

        private void MostrarInformacionPerfilForm()
        {
            OpenForm(new ProfileForm());
        }

        private void MostrarMenuPrincipal()
        {
            if (!IsFormOpen(typeof(MenuPrincipalFormcs)))
            {
                OpenForm(mPf);
            }
            else
            {

                OpenForm(mPf);
            }
        }
        private void CambiarTema()
        {
            bool activarModoOscuro = !TemaManager.ModoOscuroActivo;
            TemaManager.AplicarTema(this, activarModoOscuro);
            BtnSwitchTheme.IconChar = activarModoOscuro ? FontAwesome.Sharp.IconChar.Sun : FontAwesome.Sharp.IconChar.Moon;
            BtnSwitchTheme.IconColor = activarModoOscuro ? Color.White : Color.Black;
        }

        public async Task CargarUsuario()
        {
            try
            {
                PcbCargandoUser.Visible = true;
                var usuario = await _apiClient.LoginUsers.GetMyProfileAsync();
                if (usuario != null)
                {
                    PcbCargandoUser.Visible = false;
                    LblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
                    LblCorreo.Text = usuario.Correo_Electronico;

                    if (!string.IsNullOrEmpty(usuario.FotoPerfil))
                    {
                        string fullImageUrl = _apiClient.RootUrl + usuario.FotoPerfil.TrimStart('/');
                        PcbFotoPerfil.LoadAsync(fullImageUrl);
                    }
                    else
                    {
                        PcbFotoPerfil.Image = Properties.Resources.avatar;
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
                PcbCargandoUser.Visible = true;
                MessageBox.Show($"Error al cargar el usuario: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eventos
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            LblDerechosReservados.Left = (PanelBottom.Width - LblDerechosReservados.Width) / 2;
        }

        private void BtnMiperfil_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }
        private void PcbFotoPerfil_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }

        private void LblNombre_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }

        private void LblStudentId_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }

        private void MostraMenuPrincipalForms_Click(object sender, EventArgs e)
        {
            MostrarMenuPrincipal();
        }

        private async void TxtBucarLibros_TextChanged(object sender, EventArgs e)
        {
            string termino = TxtBucarLibros.Text.Trim();

            if (string.IsNullOrEmpty(termino))
            {
                MostrarMenuPrincipal();
                await mPf.CargarLibros();
                return;
            }

            if (!IsFormOpen(typeof(MenuPrincipalFormcs)))
            {
                OpenForm(mPf);
            }
            else
            {
                mPf.BringToFront();
            }

            try
            {
                var resultados = await _apiClient.Libros.BuscarLibrosAsync(termino);
                mPf.MostrarLibrosEnPantalla(resultados);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la búsqueda: " + ex.Message);
            }
            finally
            {
                PcbCargandoUser.Visible = false;
            }
        }

        private void BtnNotificaciones_Click_1(object sender, EventArgs e)
        {
            var formNotif = new NotificationsListForm();
            formNotif.ShowDialog();
            _ = VerificarNotificaciones();
        }
    }
}
