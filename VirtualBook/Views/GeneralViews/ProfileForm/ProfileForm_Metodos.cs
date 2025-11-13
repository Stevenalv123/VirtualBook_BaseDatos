using Newtonsoft.Json;
//using VirtualBook.DTOs;

namespace VirtualBook.Views
{
    public partial class ProfileForm:Form
    {
        private async void CargarDataUsuario()
        {
            //try
            //{
            //    var respuesta = await cliente.GetAsync($"{baseUrl}/{idUsuario}");
            //    if (respuesta != null && respuesta.IsSuccessStatusCode)
            //    {
            //        var json = await respuesta.Content.ReadAsStringAsync();
            //        var usuario = JsonConvert.DeserializeObject<ReadFullUserDTO>(json);

            //        if (usuario != null)
            //        {
            //            LblNombre.Text = $"{usuario.Nombres} {usuario.Apellidos}";
            //            LblRol.Text = usuario.Rol == 3 ? "Estudiante" : "Docente";
            //            LblEmail.Text = usuario.CorreoElectronico;
            //            LblFechaNacimiento.Text = usuario.FechaNacimiento?.ToString("dd/MM/yyyy") ?? "N/A";
            //            LblGenero.Text = usuario.Genero ?? "N/A";
            //            PcbFotoPerfil.Image = usuario.FotoPerfil != null ? Image.FromStream(new MemoryStream(usuario.FotoPerfil)) : Properties.Resources.avatar;

            //            //Rellenar los textboxes con la informacion del usuario
            //            TxtNombres.Text = usuario.Nombres;
            //            TxtApellidos.Text = usuario.Apellidos;
            //            TxtEmail.Text = usuario.CorreoElectronico;
            //            dtmfechanacimiento.Value = usuario.FechaNacimiento ?? DateTime.Today;
            //            CmbGenero.SelectedItem = usuario.Genero ?? "N/A";
            //        }
            //    }
            //}
            //catch (HttpRequestException ex)
            //{
            //    MessageBox.Show($"Error al cargar la data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
