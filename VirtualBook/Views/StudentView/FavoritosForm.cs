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
using VirtualBook.Controller;
using VirtualBook.UserControls;

namespace VirtualBook.Views
{
    public partial class FavoritosForm : Form
    {
        private readonly ApiClient _apiClient;
        private readonly IMainForm _mainForm;
        public FavoritosForm(IMainForm mf)
        {
            InitializeComponent();
            _mainForm = mf;
            _apiClient = ApiClient.Instance;
            flpLibros.AutoScroll = true;
            _ = CargarFavoritos();
        }

        private async void GetFavoritos()
        {
           
        }

        private async Task CargarFavoritos()
        {
            this.Cursor = Cursors.WaitCursor;
            flpLibros.Controls.Clear();

            try
            {
                var librosFavoritos = await _apiClient.Libros.GetFavoritosAsync();

                if (librosFavoritos != null && librosFavoritos.Count > 0)
                {
                    foreach (var libro in librosFavoritos)
                    {
                        var tarjeta = new LibroCard();
                        tarjeta.Titulo = libro.Titulo;
                        tarjeta.Autor = libro.Autores;
                        tarjeta.Sinopsis = libro.NombreCategoria; 

                        if (!string.IsNullOrEmpty(libro.Portada))
                        {
                            tarjeta.UrlPortada = _apiClient.RootUrl + libro.Portada.TrimStart('/');
                        }

                        tarjeta.DetallesClick += (s, e) => AbrirDetallesLibro(libro.IdLibro);

                        flpLibros.Controls.Add(tarjeta);
                    }
                }
                else
                {
                    Label lblVacio = new Label();
                    lblVacio.Text = "Aún no tienes libros favoritos.";
                    lblVacio.AutoSize = true;
                    lblVacio.Font = new Font("Segoe UI", 12);
                    lblVacio.ForeColor = Color.Gray;
                    flpLibros.Controls.Add(lblVacio);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar favoritos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void AbrirDetallesLibro(int libroId)
        {
            var detallesForm = new BookInfoForms(libroId, _mainForm);
            _mainForm.OpenForm(detallesForm);
        }
    }
}
