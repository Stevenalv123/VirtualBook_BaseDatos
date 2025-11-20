using System.Data;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;

namespace VirtualBook.Views
{
    public partial class AdminFormUsers : Form
    {
        private readonly ApiClient _apiClient;
        private List<UsuarioDto> _listaUsuariosCompleta;

        public AdminFormUsers()
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
            _listaUsuariosCompleta = new List<UsuarioDto>();

            dgvUsuarios.CellContentClick += DgvUsuarios_CellContentClick;
            dgvUsuarios.CellFormatting += DgvUsuarios_CellFormatting; 
            dgvUsuarios.CellPainting += DgvUsuarios_CellPainting; 
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
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = _listaUsuariosCompleta;

            if (dgvUsuarios.Columns.Count == 0) return;

            OcultarColumna("IdUsuario");
            OcultarColumna("FotoPerfil");
            if (dgvUsuarios.Columns.Contains("Nombres")) dgvUsuarios.Columns["Nombres"].HeaderText = "Nombres";
            if (dgvUsuarios.Columns.Contains("Apellidos")) dgvUsuarios.Columns["Apellidos"].HeaderText = "Apellidos";
            if (dgvUsuarios.Columns.Contains("Correo_Electronico")) dgvUsuarios.Columns["Correo_Electronico"].HeaderText = "Correo Electrónico";
            if (dgvUsuarios.Columns.Contains("NombreRol")) dgvUsuarios.Columns["NombreRol"].HeaderText = "Rol";
            if (dgvUsuarios.Columns.Contains("Estado")) dgvUsuarios.Columns["Estado"].HeaderText = "Estado Actual"; 

            if (!dgvUsuarios.Columns.Contains("btnAccion"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnAccion";
                btnColumn.HeaderText = "Acción";
                btnColumn.Text = " "; 
                btnColumn.UseColumnTextForButtonValue = false; 
                dgvUsuarios.Columns.Add(btnColumn);
            }

            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.ReadOnly = false;

            foreach (DataGridViewColumn col in dgvUsuarios.Columns)
            {
                if (col.Name != "btnAccion") col.ReadOnly = true;
            }

            if (dgvUsuarios.Columns.Contains("btnAccion"))
            {
                dgvUsuarios.Columns["btnAccion"].DisplayIndex = dgvUsuarios.Columns.Count - 1;
                dgvUsuarios.Columns["btnAccion"].Width = 100;
            }
        }

        private void OcultarColumna(string nombre)
        {
            if (dgvUsuarios.Columns.Contains(nombre)) dgvUsuarios.Columns[nombre].Visible = false;
        }

        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnAccion" && e.RowIndex >= 0)
            {
                var usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as UsuarioDto;
                if (usuario != null)
                {
                    dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = usuario.Estado ?
                        $"Inactivar a {usuario.Nombres}" :
                        $"Activar a {usuario.Nombres}";
                }
            }
        }

        private void DgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnAccion")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as UsuarioDto;
                if (usuario != null)
                {
                    
                    Color bgColor = usuario.Estado ? Color.FromArgb(231, 76, 60) : Color.FromArgb(46, 204, 113); 

                    
                    var buttonRect = new Rectangle(e.CellBounds.X + 2, e.CellBounds.Y + 2, e.CellBounds.Width - 4, e.CellBounds.Height - 4);

                   
                    using (SolidBrush brush = new SolidBrush(bgColor))
                    {
                      
                        e.Graphics.FillRectangle(brush, buttonRect);
                    }

                   
                    Image icon = Properties.Resources.activar;

                    if (icon != null)
                    {
                        
                        int iconSize = 16; 
                                           
                        
                        int x = e.CellBounds.X + (e.CellBounds.Width - iconSize) / 2;
                        int y = e.CellBounds.Y + (e.CellBounds.Height - iconSize) / 2;

                       
                        e.Graphics.DrawImage(icon, new Rectangle(x, y, iconSize, iconSize));
                    }
                }

               
                e.Handled = true;
            }
        }


        private async void DgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvUsuarios.Columns[e.ColumnIndex].Name == "btnAccion")
            {
                var usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as UsuarioDto;
                if (usuario == null) return;

                string accionTexto = usuario.Estado ? "desactivar" : "activar";
                var confirm = MessageBox.Show($"¿Seguro que deseas {accionTexto} al usuario {usuario.Nombres}?",
                                              "Confirmar cambio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool nuevoEstado = !usuario.Estado;
                    bool exito = await _apiClient.LoginUsers.CambiarEstadoUsuarioAsync(usuario.IdUsuario, nuevoEstado);

                    if (exito)
                    {
                        usuario.Estado = nuevoEstado;
                        dgvUsuarios.InvalidateCell(e.ColumnIndex, e.RowIndex);
                        dgvUsuarios.Refresh();
                        MessageBox.Show("Estado actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo cambiar el estado del usuario.");
                    }
                }
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            FiltrarUsuarios(TxtBucarUsuarios.Text);
        }

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
            PersonalizarDataGrid();
        }
    }
}