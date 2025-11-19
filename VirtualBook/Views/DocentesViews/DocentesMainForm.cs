using VirtualBook.Controller;

namespace VirtualBook.Views.DocentesViews
{
    public partial class DocentesMainForm : Form, IMainForm
    {
        private readonly ApiClient _apiClient;
        private MenuPrincipalFormcs mPf;
        private Form? activeForm = null;
        public DocentesMainForm()
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
            mPf = new MenuPrincipalFormcs(this);
            OpenForm(new MenuPrincipalFormcs(this));
            CargarUsuario();
        }

        private void BtnSwitchTheme_Click(object sender, EventArgs e)
        {
            CambiarTema();
        }

        private void CambiarTema()
        {
            bool activarModoOscuro = !TemaManager.ModoOscuroActivo;
            TemaManager.AplicarTema(this, activarModoOscuro);
            BtnSwitchTheme.IconChar = activarModoOscuro ? FontAwesome.Sharp.IconChar.Sun : FontAwesome.Sharp.IconChar.Moon;
            BtnSwitchTheme.IconColor = activarModoOscuro ? Color.White : Color.Black;
        }

        public void OpenForm(Form ChildForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            TemaManager.AplicarTema(ChildForm, TemaManager.ModoOscuroActivo);
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

        public async void CargarUsuario()
        {
            try
            {
                PcbCargandoUser.Visible = true;
                var usuario = await _apiClient.LoginUsers.GetMyProfileAsync();
                if (usuario != null)
                {
                    PcbCargandoUser.Visible = false;
                    LblNombreUsuario.Text = $"{usuario.Nombres} {usuario.Apellidos}";
                    LblCorreoUsuario.Text = usuario.Correo_Electronico;

                    if (!string.IsNullOrEmpty(usuario.FotoPerfil))
                    {
                        string fullImageUrl = _apiClient.RootUrl + usuario.FotoPerfil.TrimStart('/');
                        PcbFotoUsuario.LoadAsync(fullImageUrl);
                    }
                    else
                    {
                        PcbFotoUsuario.Image = Properties.Resources.avatar;
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

        private void BtnVerLibros_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(DocentesViews))) return;
            OpenForm(new DocentesViews(this));
        }

        private void MostraMenuPrincipalForms_Click(object sender, EventArgs e)
        {
            MostrarMenuPrincipal();
        }

        private void MostrarMenuPrincipal()
        {
            if (IsFormOpen(typeof(MenuPrincipalFormcs))) return;
            OpenForm(new MenuPrincipalFormcs(this));
        }

        private void BtnMiperfil_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ProfileForm))) return;
            OpenForm(new ProfileForm());
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
    }
}
