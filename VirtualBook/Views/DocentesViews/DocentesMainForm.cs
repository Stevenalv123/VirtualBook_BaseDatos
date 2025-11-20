using VirtualBook.Controller;

namespace VirtualBook.Views.DocentesViews
{
    public partial class DocentesMainForm : Form, IMainForm
    {
        private readonly ApiClient _apiClient;
        private Form? activeForm = null;

        public DocentesMainForm()
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
            MostrarMenuPrincipal();
            CargarUsuario();
        }

        public void OpenForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

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

        private bool IsMenuPrincipalAbierto()
        {
            return activeForm is MenuPrincipalFormcs;
        }

        private void MostrarMenuPrincipal()
        {
            if (IsMenuPrincipalAbierto()) return;

            OpenForm(new MenuPrincipalFormcs(this));
        }

        private void MostraMenuPrincipalForms_Click(object sender, EventArgs e)
        {
            MostrarMenuPrincipal();
        }

        private void BtnVerLibros_Click(object sender, EventArgs e)
        {
            if (activeForm is DocentesViews) return;

            OpenForm(new DocentesViews(this));
        }

        private void BtnMiperfil_Click(object sender, EventArgs e)
        {
            if (activeForm is ProfileForm) return;
            OpenForm(new ProfileForm());
        }

        private async void TxtBucarLibros_TextChanged(object sender, EventArgs e)
        {
            string termino = TxtBucarLibros.Text.Trim();
            if (!IsMenuPrincipalAbierto())
            {
                MostrarMenuPrincipal();
                await Task.Delay(50);
            }

            if (activeForm is MenuPrincipalFormcs menuActual)
            {
                try
                {
                    if (string.IsNullOrEmpty(termino))
                    {
                        await menuActual.CargarLibros();
                        return;
                    }

                    PcbCargandoUser.Visible = true;
                    var resultados = await _apiClient.Libros.BuscarLibrosAsync(termino);

                    menuActual.MostrarLibrosEnPantalla(resultados);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Error búsqueda: " + ex.Message);
                }
                finally
                {
                    PcbCargandoUser.Visible = false;
                }
            }
        }

        private void BtnSwitchTheme_Click(object sender, EventArgs e)
        {
            bool activarModoOscuro = !TemaManager.ModoOscuroActivo;
            TemaManager.AplicarTema(this, activarModoOscuro);
            BtnSwitchTheme.IconChar = activarModoOscuro ? FontAwesome.Sharp.IconChar.Sun : FontAwesome.Sharp.IconChar.Moon;
            BtnSwitchTheme.IconColor = activarModoOscuro ? Color.White : Color.Black;

            if (activeForm != null) TemaManager.AplicarTema(activeForm, activarModoOscuro);
        }

        public async void CargarUsuario()
        {
            try
            {
                PcbCargandoUser.Visible = true;
                var usuario = await _apiClient.LoginUsers.GetMyProfileAsync();
                if (usuario != null)
                {
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
            }
            catch {  }
            finally
            {
                PcbCargandoUser.Visible = false;
            }
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            PanelConfiguracion.Visible = !PanelConfiguracion.Visible;
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que quieres cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                VirtualBook.Properties.Settings.Default.UserToken = "";
                VirtualBook.Properties.Settings.Default.Save();

                var loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        public bool IsFormOpen(Type formType) => false;
        public void Mostrarsubmenu(Panel submenu) { }
        public void ocultarsubmenu() { }
    }
}