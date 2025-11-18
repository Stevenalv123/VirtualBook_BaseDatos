using VirtualBook.Controller;
using VirtualBook.Models.DTO;

namespace VirtualBook.Views
{
    public partial class ProfileForm : Form
    {
        private readonly ApiClient apiClient;
        private string? rutaImagenSeleccionada = null;
        public ProfileForm()
        {
            InitializeComponent();
            apiClient = ApiClient.Instance;
        }

        private async void ProfileForm_Load(object sender, EventArgs e)
        {
            await CargarDataUsuario();
        }

        private async void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombres.Text) || string.IsNullOrWhiteSpace(TxtApellidos.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.");
                return;
            }

            BtnGuardar.Enabled = false;

            try
            {
                var updateData = new UpdateUserDTO
                {
                    Nombres = TxtNombres.Text.Trim(),
                    Apellidos = TxtApellidos.Text.Trim(),
                    FechaNacimiento = dtmfechanacimiento.Value,
                    Genero = CmbGenero.SelectedItem?.ToString() ?? "",
                    RutaNuevaFoto = rutaImagenSeleccionada
                };

                bool exito = await apiClient.LoginUsers.UpdateProfileAsync(updateData);

                if (exito)
                {
                    MessageBox.Show("Perfil actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    await CargarDataUsuario();

                    rutaImagenSeleccionada = null;
                    PanelLateral.Visible = false;
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el perfil. Intenta más tarde.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
            finally
            {
                BtnGuardar.Enabled = true;
            }
        }
    }
}
