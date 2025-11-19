using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;
//using VirtualBook.DTOs;

namespace VirtualBook.Views.DocentesViews
{
    public partial class DocentesViews : Form
    {
        private readonly IMainForm _mf;
        private readonly ApiClient _apiClient;
        private int _idDocente;
        IMainForm mf;
        public DocentesViews(IMainForm _mf, int idDocente)
        {
            InitializeComponent();
            _mf = mf;
            _idDocente = idDocente;
            _apiClient = ApiClient.Instance;

            ConfigurarGrid();

            _ = CargarMisLibros();
        }

        private void BtnUploadNewBook_Click(object sender, EventArgs e)
        {
            var uploadBookForm = new VirtualBook.Views.UploadBookForm.UploadBookForm(_idDocente, _mf);
            _mf.OpenForm(uploadBookForm);
        }

        private async Task CargarCantidadSeguidores(int idUsuario)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"https://localhost:7014/api/Seguimientoes/cantidadSeguidores/{idUsuario}");
                    if (response.IsSuccessStatusCode)
                    {
                        var cantidad = await response.Content.ReadAsStringAsync();
                        LblFollowers.Text = $"{cantidad} seguidores";
                    }
                    else
                    {
                        LblFollowers.Text = "0";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener seguidores: {ex.Message}");
                }
            }
        }
        private async Task CargarMisLibros()
        {
            try
            {
                List<LibroDto> libros = await _apiClient.Libros.GetMisLibrosAsync();

                DgvLibros.DataSource = libros;

                LblTotalBooks.Text = $"{libros.Count} libros";

                // 4. Cargar seguidores (Opcional: esto debería ir en un repositorio también)
                // _ = CargarCantidadSeguidores(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar libros: {ex.Message}");
            }
        }
        private void ConfigurarGrid()
        {
            DgvLibros.AutoGenerateColumns = true;
        }
    }
}
