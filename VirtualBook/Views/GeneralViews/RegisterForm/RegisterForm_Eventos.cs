using System.Net.Http.Json;
using System.Printing;
using System.Text.RegularExpressions;
using VirtualBook.Controller;
using VirtualBook_API.DTO;
//using VirtualBook.DTOs;

namespace VirtualBook.Views
{
    public partial class RegisterForm:Form
    {
        public string _Correo { get; set; }
        public string _Contraseña { get; set; }
        public string codigo;

        private void BtnIrLoginForm_Click(object sender, EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CerrarVentana(object sender, EventArgs e)
        {
            var form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void BtnContinuar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposVacios())
            {
                if (ValidarCorreo() == true && ValidarContraseña() == true && ValidarConfirmarContraseña() == true)
                {
                    PanelCorreoElectronico.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
                    PanelContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
                    PanelConfirmarContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
                    Continuar();
                }
                else
                {
                    MessageBox.Show("Por favor, corrija los errores antes de continuar.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
            }
        }

        private void TxtContraseña_Enter(object sender, EventArgs e)
        {
            PanelContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
            BtnVerContraseña.Visible = true;
            ErrorValidaciones.Clear();
        }

        private void TxtConfirmarContraseña_Enter(object sender, EventArgs e)
        {
            PanelContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
            BtnVerConfirmarContraseña.Visible = true;
            ErrorValidaciones.Clear();
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

        private void BtnVerConfirmarContraseña_Click(object sender, EventArgs e)
        {
            if (visible == true)
            {
                TxtConfirmarContraseña.UseSystemPasswordChar = false;
                BtnVerConfirmarContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
                visible = false;
            }
            else
            {
                TxtConfirmarContraseña.UseSystemPasswordChar = true;
                BtnVerConfirmarContraseña.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                visible = true;
            }
        }
        private async void Continuar()
        {
            if (string.IsNullOrEmpty(TxtContraseña.Text) || string.IsNullOrEmpty(TxtCorreo.Text) || string.IsNullOrEmpty(TxtConfirmarContraseña.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            if (!EsCorreoValido(TxtCorreo.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.");
                return;
            }

            if (TxtContraseña.Text != TxtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            this.Cursor = Cursors.WaitCursor;
            BtnContinuar.Enabled = false;

            try
            {
                string correo = TxtCorreo.Text.Trim();

                var existe = await _apiClient.LoginUsers.VerificarCorreoExiste(correo);
                if (existe)
                {
                    MessageBox.Show("Este correo electrónico ya está registrado. Por favor, usa uno diferente.", "Correo duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _Contraseña = TxtContraseña.Text;
                _Correo = correo;

                bool correoEnviado = await EnviarCodigo();

                if (correoEnviado)
                {
                    this.Hide();

                    var confirmarCorreo = new ConfirmacionCorreoForm(codigo, _Correo, _Contraseña);

                    confirmarCorreo.FormClosed += (s, args) =>
                    {
                        this.Show();
                        this.Cursor = Cursors.Default;
                        BtnContinuar.Enabled = true;
                    };

                    confirmarCorreo.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error inesperado: " + ex.Message);
            }
            finally
            {
                if (this.Visible)
                {
                    this.Cursor = Cursors.Default;
                    BtnContinuar.Enabled = true;
                }
            }
        }

        public bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }
        public string GetCorreo()
        {
            return _Correo;
        }
        public string GetContraseña()
        {
            return _Contraseña;
        }

        public async Task<bool> EnviarCodigo()
        {
            try
            {
                codigo = GenerarCodigo();

                var emailReceptor = TxtCorreo.Text.Trim();
                var tema = "Código de Verificación - VirtualBook";

                var cuerpo = $@"
                    <html>
                      <body style='font-family: Arial, sans-serif; background-color: #f4f4f4; padding: 30px;'>
                        <div style='max-width: 600px; margin: auto; background-color: white; padding: 30px; border-radius: 10px; box-shadow: 0 0 10px rgba(0,0,0,0.1);'>
                          <h2 style='text-align: center; color: #2c3e50;'>¡Bienvenido a VirtualBook!</h2>
                          <p>Hola,</p>
                          <p>Estamos encantados de que hayas decidido unirte a nuestra comunidad de lectores, estudiantes y autores. VirtualBook es una plataforma educativa digital donde puedes compartir y descubrir libros, seguir a tus autores favoritos, y disfrutar de una experiencia de lectura personalizada.</p>
                          <p>Para completar tu registro, necesitamos que confirmes tu dirección de correo electrónico. Por favor, ingresa el siguiente código en el formulario de verificación:</p>

                          <div style='text-align: center; margin: 40px 0;'>
                            <span style='font-size: 36px; font-weight: bold; color: #2980b9;'>{codigo}</span>
                          </div>

                          <p>Este código es válido por un tiempo limitado. Si no fuiste tú quien inició este registro, puedes ignorar este mensaje y no se tomará ninguna acción.</p>

                          <p>Gracias por confiar en nosotros. Si tienes alguna pregunta o necesitas ayuda, no dudes en contactarnos.</p>

                          <br/>

                          <p>Saludos cordiales,</p>
                          <p><strong>Equipo de VirtualBook</strong></p>

                          <hr style='margin-top: 40px; border: none; border-top: 1px solid #ccc;'/>
                          <p style='font-size: 12px; color: gray; text-align: center;'>
                            Este mensaje fue enviado automáticamente por VirtualBook. Por favor, no respondas a este correo.
                          </p>
                        </div>
                      </body>
                    </html>";

                var email = new CreateEmailRequest
                {
                    EmailReceptor = emailReceptor,
                    Tema = tema,
                    Cuerpo = cuerpo
                };

                bool enviado = await ApiClient.Instance.LoginUsers.EnviarCorreo(emailReceptor, tema, cuerpo);

                if (enviado)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El servidor indicó que no se pudo enviar el correo.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar enviar el correo: " + ex.Message);
                return false;
            }
        }

        private string GenerarCodigo()
        {
            Random random = new Random();
            int codigo = random.Next(100000, 1000000);
            string codigoStr = codigo.ToString();
            return codigoStr;
        }
    }
}
