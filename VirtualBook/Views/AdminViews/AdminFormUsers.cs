using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;
// Asegúrate de que tu namespace de recursos sea accesible
using VirtualBook.Properties; // Agrega esto para acceder a Resources

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

            // Suscribirse a eventos importantes (si no lo hiciste en el diseñador)
            dgvUsuarios.CellContentClick += DgvUsuarios_CellContentClick;
            dgvUsuarios.CellFormatting += DgvUsuarios_CellFormatting; // Asegurarse de que este evento esté suscrito
            dgvUsuarios.CellPainting += DgvUsuarios_CellPainting; // Nuevo evento para dibujar el botón personalizado
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

                    PersonalizarDataGrid(); // Llama esto después de asignar el DataSource
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
            // Asegurarse de que las columnas se generen antes de manipularlas
            dgvUsuarios.AutoGenerateColumns = true;
            dgvUsuarios.DataSource = _listaUsuariosCompleta; // Re-asignar para asegurar que se generen si es necesario

            if (dgvUsuarios.Columns.Count == 0) return;

            // 1. Ocultar columnas técnicas
            OcultarColumna("IdUsuario");
            OcultarColumna("FotoPerfil");
            // Puedes dejar 'Estado' visible o no, dependiendo de tu gusto. Si la ocultas, el botón es la única indicación.
            // OcultarColumna("Estado"); 

            // 2. Renombrar encabezados
            if (dgvUsuarios.Columns.Contains("Nombres")) dgvUsuarios.Columns["Nombres"].HeaderText = "Nombres";
            if (dgvUsuarios.Columns.Contains("Apellidos")) dgvUsuarios.Columns["Apellidos"].HeaderText = "Apellidos";
            if (dgvUsuarios.Columns.Contains("Correo_Electronico")) dgvUsuarios.Columns["Correo_Electronico"].HeaderText = "Correo Electrónico";
            if (dgvUsuarios.Columns.Contains("NombreRol")) dgvUsuarios.Columns["NombreRol"].HeaderText = "Rol";
            if (dgvUsuarios.Columns.Contains("Estado")) dgvUsuarios.Columns["Estado"].HeaderText = "Estado Actual"; // Mantenerla visible y renombrada


            // 3. Agregar Columna de Botón "Acción" (Si no existe ya)
            if (!dgvUsuarios.Columns.Contains("btnAccion"))
            {
                DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                btnColumn.Name = "btnAccion";
                btnColumn.HeaderText = "Acción";
                btnColumn.Text = " "; // No mostrar texto por defecto, lo pintaremos en CellPainting
                btnColumn.UseColumnTextForButtonValue = false; // Importante
                dgvUsuarios.Columns.Add(btnColumn);
            }

            // Estilos generales
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.ReadOnly = false;

            // Proteger columnas de texto para que no se editen
            foreach (DataGridViewColumn col in dgvUsuarios.Columns)
            {
                if (col.Name != "btnAccion") col.ReadOnly = true;
            }

            // Mover la columna de acción al final si lo deseas
            if (dgvUsuarios.Columns.Contains("btnAccion"))
            {
                dgvUsuarios.Columns["btnAccion"].DisplayIndex = dgvUsuarios.Columns.Count - 1;
                dgvUsuarios.Columns["btnAccion"].Width = 100; // Ancho fijo para el botón
            }
        }

        // Método auxiliar para limpiar código
        private void OcultarColumna(string nombre)
        {
            if (dgvUsuarios.Columns.Contains(nombre)) dgvUsuarios.Columns[nombre].Visible = false;
        }

        // Evento para personalizar el texto y el tooltip del botón
        private void DgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnAccion" && e.RowIndex >= 0)
            {
                var usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as UsuarioDto;
                if (usuario != null)
                {
                    // El tooltip mostrará la acción
                    dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = usuario.Estado ?
                        $"Inactivar a {usuario.Nombres}" :
                        $"Activar a {usuario.Nombres}";
                }
            }
        }

        // NUEVO: Evento para pintar el botón con la imagen
        private void DgvUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            // Verificar si es la columna del botón
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "btnAccion")
            {
                // 1. Pintar el fondo y bordes estándar de la celda primero
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var usuario = dgvUsuarios.Rows[e.RowIndex].DataBoundItem as UsuarioDto;
                if (usuario != null)
                {
                    
                    Color bgColor = usuario.Estado ? Color.FromArgb(231, 76, 60) : Color.FromArgb(46, 204, 113); // Colores más bonitos (Flat colors)

                    
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


        // LOGICA DEL CLICK (sin cambios, ya funciona bien)
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
                    bool nuevoEstado = !usuario.Estado; // Invertir estado
                    bool exito = await _apiClient.LoginUsers.CambiarEstadoUsuarioAsync(usuario.IdUsuario, nuevoEstado);

                    if (exito)
                    {
                        usuario.Estado = nuevoEstado;
                        // Forzar redibujado para que el botón cambie de color y el ToolTip se actualice
                        dgvUsuarios.InvalidateCell(e.ColumnIndex, e.RowIndex);
                        dgvUsuarios.Refresh();
                        MessageBox.Show("Estado actualizado correctamente.");

                        // Opcional: Recargar todos los usuarios si deseas que la columna 'Estado' también se actualice
                        // Pero con el InvalidateCell, solo el botón se actualiza visualmente
                        // await CargarUsuarios(); 
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