using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualBook.Views
{
    public partial class AdminFormUsers : Form
    {
        public string BaseUrl = "https://localhost:7014/api/Usuarios";
        private int _idUsuario;
        public AdminFormUsers(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;

        }

        private void PersonalizarDataGrid()
        {

        }
        private async void CargarUsuarios()
        {
            //string TotalUrl = "https://localhost:7014/api/Usuarios/total";
            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        var response = await client.GetAsync(BaseUrl + "/dataUser");
            //        var nusuarios = await client.GetAsync(TotalUrl);

            //        if (response.IsSuccessStatusCode)
            //        {
            //            var usuarios = await response.Content.ReadFromJsonAsync<List<DTOs.ReadDataUserDTO>>();
            //            int totalUsuarios = Convert.ToInt32(await nusuarios.Content.ReadAsStringAsync());

            //            lblusuariosregistrados.Text = totalUsuarios.ToString();
            //            dgvUsuarios.DataSource = usuarios;
            //        }
            //        else
            //        {
            //            MessageBox.Show(Text = $"Error al cargar los usuarios: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    };
            //}
        }

        private void AdminFormUsers_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

       

        private async void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string letra = TxtBucarUsuarios.Text;
            string apiUrl = $"https://localhost:7014/api/Usuarios/buscar?startsWith={letra}";


            using (HttpClient client = new HttpClient())
            {
                //try
                //{
                //    var response = await client.GetAsync(apiUrl);


                //    if (response.IsSuccessStatusCode)
                //    {
                //        var usuarios = await response.Content.ReadFromJsonAsync<List<DTOs.ReadDataUserDTO>>();

                //        dgvUsuarios.DataSource = usuarios;

                //    }
                //    else
                //    {
                //        MessageBox.Show($"Error al cargar los usuarios: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Error al cargar los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }


    }
}
