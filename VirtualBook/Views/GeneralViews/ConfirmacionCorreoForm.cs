namespace VirtualBook.Views
{
    public partial class ConfirmacionCorreoForm : Form
    {
        private string _codigo;
        private string _correo;
        private string _contrasena;
        private RegisterForm _registerForm;
        public ConfirmacionCorreoForm(string codigo, string correo, string contrasena)
        {
            InitializeComponent();
            _codigo = codigo;
            _correo = correo;
            _contrasena = contrasena;
            LblCorreo.Text = _correo;
            LblCorreo.Location = new Point(((this.Width - LblCorreo.Width) / 2), 200);
        }
        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox? current = sender as TextBox;

            if (e.KeyCode != Keys.Back && current.Text.Length == 1)
            {
                this.SelectNextControl(current, true, true, true, true); // Salta al siguiente
            }
            else if (e.KeyCode == Keys.Back && current.Text.Length == 0)
            {
                this.SelectNextControl(current, false, true, true, true); // Regresa al anterior
            }
        }

        private void lblReenviarCorreo_Click(object sender, EventArgs e)
        {
            _registerForm.EnviarCodigo();
            LblCodigoEstatus.Visible = true;
            LblCodigoEstatus.Text = "Código reenviado. Por favor, revisa tu correo electrónico.";
            LblCodigoEstatus.ForeColor = Color.Green;
            LblCodigoEstatus.Location = new Point(((this.Width - LblCodigoEstatus.Width) / 2), 200); // Ajusta la posición según sea necesario
        }

        private string CodigoDigitado()
        {
            string codigo = $"{TxtN1.Text}{TxtN2.Text}{TxtN3.Text}{TxtN4.Text}{TxtN5.Text}{TxtN6.Text}";
            return codigo;
        }

        private void BtnVerificarCodigo_Click(object sender, EventArgs e)
        {
            string codigo = CodigoDigitado();

            if (codigo == _codigo)
            {
                this.Hide();
                var userInformationform = new UserInformationForm(_correo, _contrasena);
                userInformationform.Show();
            }
            else
            {
                MessageBox.Show("El código ingresado es incorrecto. Por favor, inténtalo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                LblCodigoEstatus.Visible = true;
                LblCodigoEstatus.Text = "El código ingresado es incorrecto. Por favor, inténtalo de nuevo.";
                LblCodigoEstatus.ForeColor = Color.Red;
                LblCodigoEstatus.Location = new Point(((this.Width - LblCodigoEstatus.Width) / 2), 200); // Ajusta la posición según sea necesario

                // Limpiar los campos de entrada
                TxtN1.Clear();
                TxtN2.Clear();
                TxtN3.Clear();
                TxtN4.Clear();
                TxtN5.Clear();
                TxtN6.Clear();
            }
        }

        private void BtnRegresarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
            _registerForm.Show();
        }

        private void TxtN6_TextChanged(object sender, EventArgs e)
        {
            BtnVerificarCodigo.BackColor = Color.Green;
            BtnVerificarCodigo.Enabled = true;
        }
    }
}
