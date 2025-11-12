namespace VirtualBook.Views
{
    public partial class MainForm:Form
    {
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            LblDerechosReservados.Left = (PanelBottom.Width - LblDerechosReservados.Width) / 2;
        }

        private void BtnMiperfil_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }
        private void PcbFotoPerfil_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }

        private void LblNombre_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }

        private void LblStudentId_Click(object sender, EventArgs e)
        {
            MostrarInformacionPerfilForm();
        }

        private void MostraMenuPrincipalForms_Click(object sender, EventArgs e)
        {
            MostrarMenuPrincipal();
        }
    }
}
