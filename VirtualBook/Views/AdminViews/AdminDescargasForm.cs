using Newtonsoft.Json;
using System.Data;
using System.Net.Http.Json;
using VirtualBook.DTOs;

namespace VirtualBook.Views.AdminViews
{
    public partial class AdminDescargasForm : Form
    {
        string baseUrl = "https://localhost:7014/api/Descargas";
        HttpClient cliente = new HttpClient();
        public AdminDescargasForm()
        {
            InitializeComponent();
            MostrarDescargas();
            CargarDescargas();
        }

        private async void MostrarDescargas()
        {
            try
            {
                var response = await cliente.GetFromJsonAsync<List<ReadDescargaDTO>>(baseUrl);

                dgvDescargas.DataSource = response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar descarags: " + ex.Message);
            }
        }

        private List<ReadDescargaDTO> todasLasDescargas = new List<ReadDescargaDTO>();

        private async Task CargarDescargas()
        {
            try
            {
                var response = await cliente.GetAsync(baseUrl);
                response.EnsureSuccessStatusCode();
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    todasLasDescargas = JsonConvert.DeserializeObject<List<ReadDescargaDTO>>(json);
                    dgvDescargas.DataSource = null; // Limpiar el DataSource antes de asignar uno nuevo
                    dgvDescargas.DataSource = todasLasDescargas;
                    ActualizarContadorDescargas(todasLasDescargas.Count);
                    lblTotalDescargas.Text = todasLasDescargas.Count.ToString();
                }
                else
                {
                    MessageBox.Show("Error cargando descargas: " + response.ReasonPhrase);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando descargas: " + ex.Message);
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            string libro = txtBuscar.Text.Trim();

            var filtradas = todasLasDescargas
                    .Where(d => d.Libro == libro)
                    .ToList();

                dgvDescargas.DataSource = filtradas;
                ActualizarContadorDescargas(filtradas.Count);

            if (string.IsNullOrWhiteSpace(texto))
            {
                dgvDescargas.DataSource = todasLasDescargas;
                ActualizarContadorDescargas(todasLasDescargas.Count);
            }
            else
            {
                dgvDescargas.DataSource = new List<ReadDescargaDTO>();
                ActualizarContadorDescargas(0);
            }
        }

        private void ActualizarContadorDescargas(int total)
        {
            lblTotalDescargas.Text = total.ToString();
        }

    }
}
