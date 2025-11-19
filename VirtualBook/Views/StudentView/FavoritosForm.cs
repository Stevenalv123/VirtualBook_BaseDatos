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

//using VirtualBook.DTOs;
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

            // Configurar el FlowLayoutPanel para que se comporte bien
            flpLibros.AutoScroll = true;

            // Cargar los datos al iniciar
            _ = CargarFavoritos();
        }

        private async void GetFavoritos()
        {
           
        }

        private async Task CargarFavoritos()
        {
            // Mostrar algún indicador de carga si tienes (opcional)
            this.Cursor = Cursors.WaitCursor;
            flpLibros.Controls.Clear(); // Limpiar lista anterior

            try
            {
                // 1. Obtener datos del repositorio
                var librosFavoritos = await _apiClient.Libros.GetFavoritosAsync();

                if (librosFavoritos != null && librosFavoritos.Count > 0)
                {
                    foreach (var libro in librosFavoritos)
                    {
                        // 2. Crear y configurar la LibroCard (Igual que en MenuPrincipal)
                        var tarjeta = new LibroCard();
                        tarjeta.Titulo = libro.Titulo;
                        tarjeta.Autor = libro.Autores;
                        tarjeta.Sinopsis = libro.NombreCategoria; // Usamos categoría como sinopsis visual rápida

                        // Cargar imagen usando la URL base del ApiClient
                        if (!string.IsNullOrEmpty(libro.Portada))
                        {
                            tarjeta.UrlPortada = _apiClient.RootUrl + libro.Portada.TrimStart('/');
                        }

                        // 3. Vincular evento click para ver detalles
                        tarjeta.DetallesClick += (s, e) => AbrirDetallesLibro(libro.IdLibro);

                        // 4. Agregar al panel
                        flpLibros.Controls.Add(tarjeta);
                    }
                }
                else
                {
                    // Mensaje opcional si no hay favoritos
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
            // Navegar al formulario de detalles usando el MainForm
            // Asegúrate de que el namespace de BookInfoForms sea correcto
            var detallesForm = new BookInfoForms(libroId, _mainForm);
            _mainForm.OpenForm(detallesForm);
        }
    }
}
