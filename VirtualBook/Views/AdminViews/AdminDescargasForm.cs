using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;

namespace VirtualBook.Views.AdminViews
{
    public partial class AdminDescargasForm : Form
    {
        private readonly ApiClient _apiClient;
        private List<ReporteDescargaDto> _listaReporte;

        public AdminDescargasForm()
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
            _listaReporte = new List<ReporteDescargaDto>();
        }

        private async void AdminDescargasForm_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            await CargarReporte();
        }

        private void ConfigurarGrid()
        {
            dgvDescargas.AutoGenerateColumns = true;
            dgvDescargas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescargas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDescargas.ReadOnly = true;
            dgvDescargas.AllowUserToAddRows = false;

            dgvDescargas.CellFormatting += DgvDescargas_CellFormatting;
        }

        private async Task CargarReporte()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var reporte = await _apiClient.Libros.GetReporteDescargasAsync();

                if (reporte != null)
                {
                    _listaReporte = reporte;
                    dgvDescargas.DataSource = _listaReporte;

                    if (dgvDescargas.Columns.Contains("IdLibro"))
                        dgvDescargas.Columns["IdLibro"].Visible = false;

                    int total = _listaReporte.Sum(x => x.TotalDescargas);
                    if (lblTotalDescargas != null) lblTotalDescargas.Text = total.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar reporte: {ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void DgvDescargas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDescargas.Columns[e.ColumnIndex].Name == "TotalDescargas" && e.Value != null)
            {
                if (int.TryParse(e.Value.ToString(), out int descargas))
                {
                    if (descargas > 0)
                    {
                        e.CellStyle.ForeColor = Color.Green;
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                    }
                    else
                    {
                        e.CellStyle.ForeColor = Color.Gray;
                    }
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarReporte(txtBuscar.Text);
        }

        public void FiltrarReporte(string filtro)
        {
            if (_listaReporte == null) return;

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvDescargas.DataSource = _listaReporte;
            }
            else
            {
                var filtrado = _listaReporte.Where(x =>
                    x.Titulo.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    x.Categoria.Contains(filtro, StringComparison.OrdinalIgnoreCase) ||
                    x.Autores.Contains(filtro, StringComparison.OrdinalIgnoreCase)
                ).ToList();
                dgvDescargas.DataSource = filtrado;
            }
        }
    }
}