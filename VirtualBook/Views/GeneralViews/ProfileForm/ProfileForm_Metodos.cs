using VirtualBook.Controller;

namespace VirtualBook.Views
{
    public partial class ProfileForm:Form
    {
        private async Task CargarDataUsuario()
        {
            try
            {
                var usuario = await apiClient.LoginUsers.GetMyProfileAsync();
                if (usuario != null)
                {
                    LblNombre.Text = usuario.Nombres.ToString().Trim() + " " + usuario.Apellidos.ToString().Trim();
                    TxtNombres.Text = usuario.Nombres.ToString().Trim();
                    TxtApellidos.Text = usuario.Apellidos.ToString().Trim();
                    LblEmail.Text = usuario.Correo_Electronico.ToString().Trim();
                    LblRol.Text = usuario.NombreRol.ToString().Trim();
                    LblFechaNacimiento.Text = usuario.FechaNacimiento.ToString().Trim();
                    dtmfechanacimiento.Value = usuario.FechaNacimiento;
                    CmbGenero.SelectedItem = usuario.Genero.ToString().Trim();
                    LblGenero.Text = usuario.Genero.ToString().Trim();
                    if (!string.IsNullOrEmpty(usuario.FotoPerfil))
                    {
                        string fullImageUrl = apiClient.RootUrl + usuario.FotoPerfil.TrimStart('/');
                        PcbFotoPerfil.LoadAsync(fullImageUrl);
                    }
                    else
                    {
                        PcbFotoPerfil.Image = Properties.Resources.avatar;
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Error al cargar la data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
