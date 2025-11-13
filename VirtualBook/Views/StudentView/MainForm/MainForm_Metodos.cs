using Newtonsoft.Json;

namespace VirtualBook.Views
{
    public partial class MainForm:Form
    {
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
            //OpenForm(new ProfileForm(_apiClient)); 

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
            //try
            //{
            //    var respuesta = await _apiClient.GetAsync($"{baseUrl}/{idUsuario}");
            //    if (respuesta != null && respuesta.IsSuccessStatusCode)
            //    {
            //        var json = await respuesta.Content.ReadAsStringAsync();
            //        var usuario = JsonConvert.DeserializeObject<ReadUsuarioDTO>(json);

            //        if(usuario!= null)
            //        {
            //            PcbCargandoUser.Visible = false;
            //            LblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
            //            LblCorreo.Text = usuario.CorreoElectronico;
            //            PcbFotoPerfil.Image = usuario.FotoPerfil != null ? Image.FromStream(new MemoryStream(usuario.FotoPerfil)) : Properties.Resources.avatar;
            //        }
            //        else
            //        {
            //            PcbCargandoUser.Visible = true;
            //        }

            //    }
            //}
            //catch (HttpRequestException ex)
            //{
            //    MessageBox.Show($"Error al cargar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
