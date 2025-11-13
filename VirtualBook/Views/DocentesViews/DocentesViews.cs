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
//using VirtualBook.DTOs;

namespace VirtualBook.Views.DocentesViews
{
    public partial class DocentesViews : Form
    {
        int _idDocente;
        IMainForm mf;
        string baseUrl = "https://localhost:7014/api/Libroes";
        HttpClient cliente = new();
        public DocentesViews(int idUsuario, IMainForm _mf)
        {
            InitializeComponent();
            _idDocente = idUsuario;
            mf = _mf;
            CargarLibros();
        }

        private void BtnUploadNewBook_Click(object sender, EventArgs e)
        {
            var uploadBookForm = new VirtualBook.Views.UploadBookForm.UploadBookForm(_idDocente, mf);
            mf.OpenForm(uploadBookForm);
        }

        private async void CargarLibros()
        {
            //var response=await cliente.GetAsync($"{baseUrl}/usuario/{_idDocente}");
            //response.EnsureSuccessStatusCode();
            //if(response.IsSuccessStatusCode)
            //{
            //    var json = await response.Content.ReadAsStringAsync();
            //    var libros=JsonConvert.DeserializeObject<List<ReadDataLibroDTO>>(json);
            //    if (libros != null && libros.Count > 0)
            //    {
            //        DgvLibros.DataSource = null;
            //        DgvLibros.DataSource = libros;
            //        LblTotalBooks.Text = $"{libros.Count} libros";
            //        await CargarCantidadSeguidores(_idDocente);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Error al cargar los libros.");
            //}
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
    }
}
