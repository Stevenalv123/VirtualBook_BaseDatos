using VirtualBook.Controller;
using VirtualBook.Views;
using VirtualBook.Views.AdminViews;
using VirtualBook.Views.DocentesViews;

namespace VirtualBook
{
    public partial class LoginForm : Form
    {
        bool visible = false;
        private readonly ApiClient _apiClient;
        public LoginForm()
        {
            InitializeComponent();
            BtnVerContraseña.Visible = true;
            _apiClient = ApiClient.Instance;
        }

        private void BtnIrRegistrarmeForm_Click(object sender, EventArgs e)
        {
            var form = new RegisterForm();
            form.Show();
            this.Hide();
        }

        private void BtnVerContraseña_Click(object sender, EventArgs e)
        {
            if (visible == true)
            {
                TxtContraseña.UseSystemPasswordChar = false;
                BtnVerContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
                visible = false;
            }
            else
            {
                TxtContraseña.UseSystemPasswordChar = true;
                BtnVerContraseña.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                visible = true;
            }
        }
        private async Task LoginAsync()
        {
            string email = TxtCorreo.Text;
            string password = TxtContraseña.Text;

            var loginResponse = await _apiClient.LoginUsers.ValidateCredentialsAsync(email, password);

            if (!string.IsNullOrEmpty(loginResponse.Token))
            {
                _apiClient.SetAuthToken(loginResponse.Token);

                this.Hide();

                switch (loginResponse.IdRol)
                {
                    case 1:
                        var adminForm = new AdministradorMainForm(loginResponse.IdUsuario);
                        adminForm.Show();
                        break;
                    case 2:
                        var docenForm = new DocentesMainForm();
                        docenForm.Show();
                        break;
                    case 3:
                        var mainForm = new MainForm();
                        mainForm.Show();
                        break;
                    default:
                        MessageBox.Show("Rol desconocido. Contacte a soporte.");
                        this.Show();
                        break;
                }
            }
        }
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
                this.Cursor = Cursors.WaitCursor;
                BtnContinuar.Enabled = false;
                await LoginAsync();
            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                BtnContinuar.Enabled = true;
                MessageBox.Show($"Error: {ex.Message}", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
