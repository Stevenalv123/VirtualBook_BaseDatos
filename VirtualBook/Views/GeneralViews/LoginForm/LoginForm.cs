using System.Text;
using System.Text.Json;
using VirtualBook.DTOs;
using VirtualBook.Views;

namespace VirtualBook
{
    public partial class LoginForm : Form
    {
        bool visible = false;
        public string baseUrl = "https://localhost:7014/api/Usuarios";
        public HttpClient http = new();
        public LoginForm()
        {
            InitializeComponent();
            BtnVerContraseña.Visible = true;
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
