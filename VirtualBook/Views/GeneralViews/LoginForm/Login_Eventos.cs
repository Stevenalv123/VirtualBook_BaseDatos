using System.Net.Http.Json;
using VirtualBook.Model;
using VirtualBook.Views;
using VirtualBook.Views.AdminViews;
using VirtualBook.Views.DocentesViews;
//using VirtualBook_WebAPI.DTOs;

namespace VirtualBook
{
    public partial class LoginForm:Form
    {
        //Evento que le asigna al boton de cerrar que cierre el formulario
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Aplico logica para poder ver y ocultar la contraseña

        //Validamos antes de continuar que los campos esten correctos
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
                var response = await http.PostAsJsonAsync($"{baseUrl}/login", loginData);
                

                if (response.IsSuccessStatusCode)
                {
                    var usuario = await response.Content.ReadFromJsonAsync<Usuario>();
                    Cookies.GuardarCookie(usuario.IdUsuario, usuario.Rol);

                    if (usuario.Rol == 1)
                    {
                        var adminForm = new AdministradorMainForm(usuario.IdUsuario);
                        adminForm.Show();
                        this.Hide();
                    }
                    else if (usuario.Rol == 2)
                    {
                        var userForm = new DocentesMainForm(usuario.IdUsuario);
                        userForm.Show();
                        this.Hide();
                    }
                    else if (usuario.Rol == 3)
                    {
                        var mainform = new MainForm(usuario.IdUsuario);
                        mainform.Show();
                        this.Hide();
                    }
                }
                else
                {
                    var statusCode = (int)response.StatusCode;
                    var content = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error {statusCode}: {content}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al conectar con el servidor: {ex.Message}");
            }

        }
    }
}
