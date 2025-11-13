using VirtualBook.Controller;
using VirtualBook.Views;

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
            _apiClient = new ApiClient();
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
    }
}
