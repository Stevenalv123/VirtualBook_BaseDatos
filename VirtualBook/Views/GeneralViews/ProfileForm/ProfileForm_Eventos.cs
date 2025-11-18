namespace VirtualBook.Views
{
    public partial class ProfileForm:Form
    {
        private void LblEditarPerfil_Click(object sender, EventArgs e)
        {
            PanelLateral.Visible = true;
        }

        private async void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            PanelLateral.Visible = true;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Imágenes|*.jpg;*.jpeg;*.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rutaImagenSeleccionada = openFile.FileName;
                PcbFotoPerfil.Image = Image.FromFile(rutaImagenSeleccionada);
                MessageBox.Show("Presione el boton de Guardar para actualizar su foto de perfil.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            PanelLateral.Visible = false;
        }
    }
}
