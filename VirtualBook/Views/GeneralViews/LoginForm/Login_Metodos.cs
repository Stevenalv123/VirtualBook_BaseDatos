using VirtualBook.Views;

namespace VirtualBook
{
    public partial class LoginForm:Form
    {
        // En LoginForm.cs (archivo de LoginAsync)
        private async Task LoginAsync()
        {
            string email = TxtCorreo.Text;
            string password = TxtContraseña.Text;

            var loginResponse = await _apiClient.LoginUsers.ValidateCredentialsAsync(email, password);

            if (!string.IsNullOrEmpty(loginResponse.Token))
            {
                MessageBox.Show($"¡Bienvenido {loginResponse.Nombres}!", "Login Exitoso");
                _apiClient.SetAuthToken(loginResponse.Token);

                this.Hide();

                switch (loginResponse.IdRol)
                {
                    case 1: // Administrador
                            // var adminForm = new AdministradorMainForm(_apiClient); // Pasa el apiClient
                            // adminForm.Show();
                        MessageBox.Show("Abriendo formulario de Administrador (descomentar línea)");
                        break;
                    case 2: // Docente
                            // var docenForm = new DocentesMainForm(_apiClient);
                            // docenForm.Show();
                        MessageBox.Show("Abriendo formulario de Docente (descomentar línea)");
                        break;
                    case 3:
                        var mainForm = new MainForm(_apiClient);
                        mainForm.Show();
                        MessageBox.Show("Abriendo formulario de Estudiante (descomentar línea)");
                        break;
                    default:
                        MessageBox.Show("Rol desconocido. Contacte a soporte.");
                        this.Show();
                        break;
                }
            }
        }
    }
}
