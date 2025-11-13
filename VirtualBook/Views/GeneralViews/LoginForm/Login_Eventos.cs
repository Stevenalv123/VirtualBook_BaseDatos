using System.Net.Http.Json;
//using VirtualBook.Model;
using VirtualBook.Views;
using VirtualBook.Views.AdminViews;
using VirtualBook.Views.DocentesViews;
//using VirtualBook_WebAPI.DTOs;

namespace VirtualBook
{
    public partial class LoginForm:Form
    {
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void BtnContinuar_Click(object sender, EventArgs e)
        {
            ErrorValidaciones.Clear();

            if (string.IsNullOrEmpty(TxtCorreo.Text))
            {
                ErrorValidaciones.SetError(TxtCorreo, "Ingrese su correo");
                return;
            }

            if (string.IsNullOrEmpty(TxtContraseña.Text))
            {
                ErrorValidaciones.SetError(TxtContraseña, "Ingrese una contraseña");
                return;
            }

            var loginData = new 
            {
                CorreoElectronico = TxtCorreo.Text,
                Contraseña = TxtContraseña.Text.Trim()
            };

            try
            {
                await LoginAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
