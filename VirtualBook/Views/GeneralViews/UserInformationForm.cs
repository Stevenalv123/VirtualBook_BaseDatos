using System.Net.Http.Json;
using VirtualBook.DTOs;
using VirtualBook.Views.AdminViews;


namespace VirtualBook.Views
{
    public partial class UserInformationForm : Form
    {
        private readonly string BaseUrl = "https://localhost:7014/api/Usuarios/register";
        public byte[] fotoPerfil { get; set; }
        RegisterForm register_Form;

        public UserInformationForm(Views.RegisterForm registerForm)
        {
            InitializeComponent();
            register_Form = registerForm;
            register_Form.Hide();
            CargarRoles();
        }

        private async void BtnRegistrar_Click(object sender, EventArgs e)
        {
            //validamos que los campos no esten vacios
            if (string.IsNullOrWhiteSpace(TxtNombreUsuario.Text) || string.IsNullOrEmpty(TxtApellidosUsuarios.Text))
            {
                MessageBox.Show("Por favor completa todos los campos obligatorios.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var fechaLimite = DateTime.Today.AddYears(-8);
            if (dtmfechanacimiento.Value > fechaLimite)
            {
                MessageBox.Show("El usuario debe tener al menos 8 años de edad.", "Fecha de nacimiento inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cborol.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un rol válido.");
                return;
            }

            int idRol = (int)cborol.SelectedValue;

            //agregar el usuario 
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var nuevoUsuario = new CreateUserDTO
                    {
                        Nombres = TxtNombreUsuario.Text,
                        Apellidos = TxtApellidosUsuarios.Text,
                        CorreoElectronico = register_Form._Correo,
                        Contraseña = register_Form._Contraseña,
                        FotoPerfil = fotoPerfil,
                        Rol = idRol,
                        FechaNacimiento = dtmfechanacimiento.Value,
                        Genero = cbogenero.SelectedItem?.ToString()
                    };

                    var response = await client.PostAsJsonAsync(BaseUrl, nuevoUsuario);
                    if (response.IsSuccessStatusCode)
                    {
                        var usuarioRegistrado = await response.Content.ReadFromJsonAsync<ReadUsuarioDTO>();
                        if (usuarioRegistrado != null)
                        {
                            Cookies.GuardarCookie(usuarioRegistrado.IdUsuario, usuarioRegistrado.Rol);

                            if (usuarioRegistrado.Rol == 1)
                            {
                                var adminForm = new AdministradorMainForm(idRol);
                                adminForm.Show();
                                this.Hide();
                            }
                            else if (usuarioRegistrado.Rol == 2)
                            {
                                var userform = new DocentesViews.DocentesMainForm(usuarioRegistrado.IdUsuario);
                                userform.Show();
                                this.Hide();
                            }
                            else if (usuarioRegistrado.Rol == 3)
                            {
                                var mainform = new MainForm(usuarioRegistrado.IdUsuario);
                                mainform.Show();
                                this.Hide();
                            }

                            this.Hide();
                            register_Form.Hide();
                        }
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Error al registrar usuario:\n" + response.StatusCode + "\n" + errorMessage);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectar con el servidor: {ex.Message}");
                }
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            register_Form.Show();
            this.Hide();
        }

        private void BtnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            SeleccionarImagen();
        }

        private void SeleccionarImagen()
        {
            OpenFileDialog dlgImagenPerfil = new OpenFileDialog();
            dlgImagenPerfil.InitialDirectory = "";
            dlgImagenPerfil.Filter = "Imagenes|*.jpg;*.png;*.JPEG";
            dlgImagenPerfil.FilterIndex = 3;
            dlgImagenPerfil.Title = "Cargar Imagen";
            if (dlgImagenPerfil.ShowDialog() == DialogResult.OK)
            {
                PcbFotoPerfil.BackgroundImage = null;
                PcbFotoPerfil.Image = new Bitmap(dlgImagenPerfil.FileName);
                fotoPerfil = File.ReadAllBytes(dlgImagenPerfil.FileName); // Convertir la imagen a bytes
            }
        }

        private void PcbFotoPerfil_Click(object sender, EventArgs e)
        {
            SeleccionarImagen();
        }

        private async void CargarRoles()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync("https://localhost:7014/api/Roles");
                    if (response.IsSuccessStatusCode)
                    {
                        var roles = await response.Content.ReadFromJsonAsync<List<ReadRolesDTO>>();
                        cborol.DataSource = roles;
                        cborol.DisplayMember = "NombreRol";
                        cborol.ValueMember = "IdRol";
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar los roles: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al conectar con el servidor: " + ex.Message);
                }
            }
        }
    }
}
