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
        private readonly IMainForm mf;
        private readonly ApiClient _apiClient;
        public DocentesViews(IMainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
            _apiClient = ApiClient.Instance;

            ConfigurarGrid();

            _ = CargarMisLibros();
        }

        private void BtnUploadNewBook_Click(object sender, EventArgs e)
        {
            var uploadBookForm = new VirtualBook.Views.UploadBookForm.UploadBookForm(mf);
            mf.OpenForm(uploadBookForm);
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

        // EVENTO SELECCION CAMBIO EN EL DATAGRIDVIEW
        private void dgvShowBooks_SelectionChanged(object sender, EventArgs e)
        {
            BtnEliminar.Enabled = DgvLibros.SelectedRows.Count > 0;
        }

        // MAE AQUI VOY ASIGNAR EL EVENTO CLICK DEL BOTON ELIMINAR
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvLibros.SelectedRows.Count == 0) return;

            var libro = (LibroDto)DgvLibros.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show(
                $"¿Estás seguro de eliminar '{libro.Titulo}'?\nEsta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string resultado = await _apiClient.Libros.EliminarLibroAsync(libro.IdLibro);

                    if (resultado == "OK")
                    {
                        MessageBox.Show("Libro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarMisLibros();
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo eliminar: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error crítico: " + ex.Message);
                }
            }
        }

    }
}
