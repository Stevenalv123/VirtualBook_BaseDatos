using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.Controller;
using VirtualBook.Helpers; // IMPORTANTE: Necesario para usar PdfHelper
using VirtualBook.Models.DTO;
using VirtualBook.Views.UploadBookForm;

namespace VirtualBook.Views
{
    public partial class AdminDashboardForm : Form
    {
        Panel PanelCentral;
        private Form ActiveForm;
        private int _idUsuario;
        IMainForm mf;
        private readonly ApiClient _apiClient;
        private List<LibroDto> _listaLibrosCompleta;

        public AdminDashboardForm(IMainForm _mf)
        {
            InitializeComponent();
            mf = _mf;
            _apiClient = ApiClient.Instance;
            _listaLibrosCompleta = new List<LibroDto>();
        }

        private async void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            await CargarDatosDashboard();
        }

        private async Task CargarDatosDashboard()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var libros = await _apiClient.Libros.GetLibrosAsync();

                if (libros != null)
                {
                    _listaLibrosCompleta = libros;

                    dgvShowBooks.DataSource = _listaLibrosCompleta;
                    PersonalizarColumnas();

                    lblTotalLibros.Text = _listaLibrosCompleta.Count.ToString();
                    lblDescargas.Text = _listaLibrosCompleta.Sum(l => l.Descargas).ToString();
                }

                var usuarios = await _apiClient.LoginUsers.GetUsuariosAsync();

                if (usuarios != null)
                {
                    lblTotalUsuarios.Text = usuarios.Count.ToString();
                }
                else
                {
                    lblTotalUsuarios.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos del dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void PersonalizarColumnas()
        {
            if (dgvShowBooks.Columns.Count == 0) return;

            OcultarColumna("IdLibro");
            OcultarColumna("Portada");
            OcultarColumna("Descripcion");
            OcultarColumna("FechaPublicacion");

            RenombrarColumna("NumeroPaginas", "Páginas");
            RenombrarColumna("NombreCategoria", "Categoría");
            RenombrarColumna("NombreFormato", "Formato");
            RenombrarColumna("NombreIdioma", "Idioma");
            RenombrarColumna("Publicador", "Publicado Por");

            dgvShowBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShowBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShowBooks.ReadOnly = true;
        }

        private void OcultarColumna(string nombreColumna)
        {
            if (dgvShowBooks.Columns.Contains(nombreColumna))
                dgvShowBooks.Columns[nombreColumna].Visible = false;
        }

        private void RenombrarColumna(string nombreColumna, string nuevoTexto)
        {
            if (dgvShowBooks.Columns.Contains(nombreColumna))
                dgvShowBooks.Columns[nombreColumna].HeaderText = nuevoTexto;
        }

        private void BucarLibros_Click(object sender, EventArgs e)
        {
            FiltrarLibros(TxtBucarLibros.Text);
        }

        private void TxtBucarLibros_TextChanged(object sender, EventArgs e)
        {
            FiltrarLibros(TxtBucarLibros.Text);
        }

        private void FiltrarLibros(string filtro)
        {
            if (_listaLibrosCompleta == null || !_listaLibrosCompleta.Any()) return;

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvShowBooks.DataSource = _listaLibrosCompleta;
            }
            else
            {
                var listaFiltrada = _listaLibrosCompleta.Where(l =>
                    (l.Titulo != null && l.Titulo.Contains(filtro, StringComparison.OrdinalIgnoreCase)) ||
                    (l.Autores != null && l.Autores.Contains(filtro, StringComparison.OrdinalIgnoreCase)) ||
                    (l.NombreCategoria != null && l.NombreCategoria.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                ).ToList();

                dgvShowBooks.DataSource = listaFiltrada;
            }
            PersonalizarColumnas();
        }

        private void BtnAgregarNuevoLibro_Click(object sender, EventArgs e)
        {
            mf.OpenForm(new UploadBookForm.UploadBookForm(mf));
        }

        private void OpenForm(Form ChildForm)
        {
            if (ActiveForm != null) ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            TemaManager.AplicarTema(ChildForm, TemaManager.ModoOscuroActivo);
            if (PanelCentral != null)
            {
                PanelCentral.Controls.Add(ChildForm);
                PanelCentral.Tag = ChildForm;
                ChildForm.BringToFront();
                ChildForm.Show();
            }
        }

        private void dgvShowBooks_SelectionChanged(object sender, EventArgs e)
        {
            // BtnEliminar.Enabled = dgvShowBooks.SelectedRows.Count > 0;
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvShowBooks.SelectedRows.Count == 0) return;

            var libro = (LibroDto)dgvShowBooks.SelectedRows[0].DataBoundItem;

            var confirm = MessageBox.Show(
                $"¿Estás seguro de eliminar '{libro.Titulo}'?\nEsta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    // NOTA: Asegúrate de que tu repositorio tenga este método implementado
                    // string resultado = await _apiClient.Libros.EliminarLibroAsync(libro.IdLibro);

                    // Como no veo el método EliminarLibroAsync en tu repo compartido anteriormente,
                    // dejo esto comentado para que no te de error de compilación si no existe.
                    // Si ya lo creaste, descoméntalo.
                    MessageBox.Show("Funcionalidad de eliminar pendiente de implementación en Repositorio.");

                    /*
                    if (resultado == "OK")
                    {
                        MessageBox.Show("Libro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarDatosDashboard();
                    }
                    else
                    {
                        MessageBox.Show($"No se pudo eliminar: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    */
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error crítico: " + ex.Message);
                }
            }
        }

        // --- CÓDIGO DEL BOTÓN DE EXPORTAR A PDF ---
        private void btnExportarLibrosASC_Click(object sender, EventArgs e)
        {
            if (dgvShowBooks.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamada al Helper para generar el PDF
            PdfHelper.ExportarDataGridView(dgvShowBooks, "Inventario de Libros - VirtualBook");
        }
    }
}