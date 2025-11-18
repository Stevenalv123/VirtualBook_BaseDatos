using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;

namespace VirtualBook.Views
{
    public partial class AdminFormUsers : Form
    {
        private int _idUsuario;
        private readonly ApiClient _apiClient;
        private List<UsuarioDto> _listaUsuariosCompleta; // Para filtrado local rápido

        public AdminFormUsers(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;
            _apiClient = ApiClient.Instance;
            _listaUsuariosCompleta = new List<UsuarioDto>();
        }

        private async void AdminFormUsers_Load(object sender, EventArgs e)
        {
            await CargarUsuarios();
        }

        private async Task CargarUsuarios()
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                var usuarios = await _apiClient.LoginUsers.GetUsuariosAsync();

                if (usuarios != null)
                {
                    _listaUsuariosCompleta = usuarios;
                    dgvUsuarios.DataSource = _listaUsuariosCompleta;

                    // Actualizar el contador (etiqueta que mencionaste en el código comentado)
                    if (lblusuariosregistrados != null)
                        lblusuariosregistrados.Text = _listaUsuariosCompleta.Count.ToString();

                    PersonalizarDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar usuarios: {ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void PersonalizarDataGrid()
        {
            if (dgvUsuarios.Columns.Count == 0) return;

            // Ocultar columnas técnicas
            if (dgvUsuarios.Columns.Contains("IdUsuario")) dgvUsuarios.Columns["IdUsuario"].Visible = false;
            if (dgvUsuarios.Columns.Contains("FotoPerfil")) dgvUsuarios.Columns["FotoPerfil"].Visible = false;

            // Renombrar columnas
            if (dgvUsuarios.Columns.Contains("Correo_Electronico")) dgvUsuarios.Columns["Correo_Electronico"].HeaderText = "Correo";
            if (dgvUsuarios.Columns.Contains("NombreRol")) dgvUsuarios.Columns["NombreRol"].HeaderText = "Rol";

            // Estilos
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.ReadOnly = true;
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            // Búsqueda local rápida
            string filtro = TxtBucarUsuarios.Text;
            FiltrarUsuarios(filtro);
        }

        // Sugerencia: Agrega este evento al TextBox Changed también
        private void TxtBucarUsuarios_TextChanged(object sender, EventArgs e)
        {
            FiltrarUsuarios(TxtBucarUsuarios.Text);
        }

        private void FiltrarUsuarios(string filtro)
        {
            if (_listaUsuariosCompleta == null || !_listaUsuariosCompleta.Any()) return;

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvUsuarios.DataSource = _listaUsuariosCompleta;
            }
            else
            {
                var listaFiltrada = _listaUsuariosCompleta.Where(u =>
                    (u.Nombres != null && u.Nombres.Contains(filtro, StringComparison.OrdinalIgnoreCase)) ||
                    (u.Apellidos != null && u.Apellidos.Contains(filtro, StringComparison.OrdinalIgnoreCase)) ||
                    (u.Correo_Electronico != null && u.Correo_Electronico.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                ).ToList();

                dgvUsuarios.DataSource = listaFiltrada;
            }
            PersonalizarDataGrid(); // Re-aplicar estilos
        }
    }
}