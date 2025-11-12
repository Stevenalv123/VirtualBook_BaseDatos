using System.Net.Http.Json;
//using VirtualBook_WebAPI.DTOs;

namespace VirtualBook.Views
{
    public partial class ProfileForm:Form
    {
        private void LblEditarPerfil_Click(object sender, EventArgs e)
        {
            PanelLateral.Visible = true;
        }

        private async void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {

            //OpenFileDialog dlgImagenPerfil = new OpenFileDialog();
            //dlgImagenPerfil.InitialDirectory = "";
            //dlgImagenPerfil.Filter = "Imagenes|*.jpg;*.png;*.JPEG";
            //dlgImagenPerfil.FilterIndex = 1;
            //dlgImagenPerfil.Title = "Cargar Imagen";

            //if (dlgImagenPerfil.ShowDialog() != DialogResult.OK)
            //    return;

            //PcbFotoPerfil.BackgroundImage = null;
            //PcbFotoPerfil.Image = new Bitmap(dlgImagenPerfil.FileName);

            //var newUserImage = new EditProfilePictureUserDTO
            //{
            //    IdUsuario = idUsuario,
            //    FotoPerfil = File.ReadAllBytes(dlgImagenPerfil.FileName)
            //};

            //var responseUpdate = await cliente.PutAsJsonAsync($"{baseUrl}/{idUsuario}/EditImage", newUserImage);
            //if (responseUpdate.IsSuccessStatusCode)
            //{
            //    MessageBox.Show("Imagen actualizada correctamente, veras tus cambios cuando reinicies la aplicacion.","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    CargarDataUsuario();

            //    if (Cookies.GetRol() == 2)
            //    {
            //        docentesMainForm.CargarUsuario();
            //    }
            //    else
            //    {
            //        await mainForm.CargarUsuario();
            //    }

                
            //}
            //else
            //{
            //    var error = await responseUpdate.Content.ReadAsStringAsync();
            //    MessageBox.Show($"Error al actualizar la imagen: {responseUpdate.ReasonPhrase}\n{error}");
            //}
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            PanelLateral.Visible = false;
        }
    }
}
