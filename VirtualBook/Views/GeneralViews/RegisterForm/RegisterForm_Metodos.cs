using System.Windows.Media;

namespace VirtualBook.Views
{
    public partial class RegisterForm:Form
    {
        private bool ValidarCamposVacios()
        {
            if(string.IsNullOrEmpty(TxtCorreo.Text))
            {
                ErrorValidaciones.SetError(TxtCorreo, "Rellene este campo");
                PanelCorreoElectronico.BorderColor = System.Drawing.Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(TxtContraseña.Text)){
                ErrorValidaciones.SetError(TxtContraseña, "Rellene este campo");
                BtnVerContraseña.Visible = false;
                PanelContraseña.BorderColor = System.Drawing.Color.Red;
                return false;
            }

            if (string.IsNullOrEmpty(TxtConfirmarContraseña.Text))
            {
                ErrorValidaciones.SetError(TxtConfirmarContraseña, "Rellene este campo");
                BtnVerConfirmarContraseña.Visible = false;
                PanelConfirmarContraseña.BorderColor = System.Drawing.Color.Red;
                return false;
            }

            PanelContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
            return true;
        }

        private bool ValidarCorreo()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtCorreo.Text, @"[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*@[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*[.][a-zA-Z]{2,5}"))
            {
                ErrorValidaciones.SetError(TxtCorreo, "El correo no es valido");
                PanelCorreoElectronico.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                ErrorValidaciones.SetError(TxtCorreo, "");
                PanelContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
                return true;
            }
        }

        private bool ValidarContraseña()
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(TxtContraseña.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[.$@$!%*?&])[A-Za-z\d.$@$!%*?&]{8,15}$"))
            {
                ErrorValidaciones.SetError(TxtContraseña, "La contraseña debe contener al menos una mayuscula, una minuscula, no espacios en blanco, al menos un digito, y al menos un caracter especial, maximo 15, minimo 8");
                PanelContraseña.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                ErrorValidaciones.SetError(TxtContraseña, "");
                PanelContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
                return true;
            }
        }

        private bool ValidarConfirmarContraseña()
        {
            if (TxtContraseña.Text != TxtConfirmarContraseña.Text)
            {
                ErrorValidaciones.SetError(TxtConfirmarContraseña, "Las contraseñas no coinciden");
                PanelConfirmarContraseña.BorderColor = System.Drawing.Color.Red;
                return false;
            }
            else
            {
                ErrorValidaciones.SetError(TxtConfirmarContraseña, "");
                PanelContraseña.BorderColor = System.Drawing.Color.FromArgb(113, 113, 122);
                return true;
            }
        }
    }
}
