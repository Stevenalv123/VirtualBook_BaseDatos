using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.DTOs;
using VirtualBook.UserControls;

namespace VirtualBook.Views
{
    public partial class FavoritosForm : Form
    {
        private string baseUrl = "https://localhost:7014/api/favoritos/";
        private HttpClient cliente = new();
        private IMainForm mainform;
        public FavoritosForm(IMainForm mf)
        {
            InitializeComponent();
            mainform = mf;
            GetFavoritos();
        }

        private async void GetFavoritos()
        {
            var response = await cliente.GetAsync($"{baseUrl}{Cookies.GetId()}");
            response.EnsureSuccessStatusCode();
            if (response.IsSuccessStatusCode)
            {
                var json=await response.Content.ReadAsStringAsync();
                var favoritos=JsonConvert.DeserializeObject<List<ReadVistaPreviaLibro>>(json);
                if (favoritos != null && favoritos.Count > 0)
                {
                    foreach (var libro in favoritos)
                    {
                        var card = new LibroCard(libro, mainform);
                        flpLibros.Controls.Add(card);
                    }
                }
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error al cargar los libros favoritos. {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
    }
}
