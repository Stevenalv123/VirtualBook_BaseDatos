using System.Net.Http.Json;
//using VirtualBook_WebAPI.DTOs;
using System.Text.RegularExpressions;

namespace VirtualBook.Views
{
    public partial class ProfileForm : Form
    {
        int idUsuario = 0;
        private string baseUrl = "https://localhost:7014/api/Usuarios";
        private HttpClient cliente = new();
        private MainForm mainForm;
        private DocentesViews.DocentesMainForm docentesMainForm;

        public ProfileForm(int IdUsuario)
        {
            InitializeComponent();
            this.idUsuario = IdUsuario;
            CargarDataUsuario();
            mainForm = new MainForm();
            docentesMainForm = new DocentesViews.DocentesMainForm(idUsuario);
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private async void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            //var editUser = new EditUsuarioDTO
            //{
            //    IdUsuario = idUsuario,
            //    Nombres = TxtNombres.Text,
            //    Apellidos = TxtApellidos.Text,
            //    CorreoElectronico = TxtEmail.Text,
            //    FechaNacimiento = dtmfechanacimiento.Value,
            //    Genero = CmbGenero.SelectedItem?.ToString()
            //};
           

            //using (HttpClient client = new HttpClient())
            //{

            //    var response = await client.PutAsJsonAsync($"{baseUrl}/{idUsuario}", editUser);

            //    if (response.IsSuccessStatusCode)
            //    {
            //        MessageBox.Show("Usuario Actualizado Correctamente");
            //        CargarDataUsuario();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Error al actualizar el usuario: " + response.ReasonPhrase);
            //    }
            //}
        }
    }
}
