using NuGet.Protocol.Plugins;
using System.Net.Http.Json;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;
using VirtualBook.Views.AdminViews;
using VirtualBook.Views.DocentesViews;


namespace VirtualBook.Views
{
    public partial class UserInformationForm : Form
    {
        private readonly ApiClient _apiClient;
        public byte[] fotoPerfil { get; set; }
        RegisterForm register_Form;
        public string correo;
        public string contrasena;
        private string rutaImagenSeleccionada;

        public UserInformationForm(string _correo, string _contrasena)
        {
            InitializeComponent();
            correo = _correo;
            contrasena = _contrasena;
            _apiClient = ApiClient.Instance;
            CargarRoles();
        }

        private async void BtnRegistrar_Click(object sender, EventArgs e)
        {
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
 
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var nuevoUsuario = new RegisterRequest
                    {
                        Nombres = TxtNombreUsuario.Text.Trim(),
                        Apellidos = TxtApellidosUsuarios.Text.Trim(),
                        Correo_Electronico = correo,
                        Contrasena = contrasena,
                        IdRol = idRol,
                        FotoPerfil = rutaImagenSeleccionada,
                        FechaNacimiento = dtmfechanacimiento.Value,
                        Genero = cbogenero.SelectedItem?.ToString() ?? string.Empty
                    };
                    bool registroExitoso = await _apiClient.LoginUsers.RegistrarUsuario(nuevoUsuario);

                    if (registroExitoso)
                    {
                        var loginResponse = await _apiClient.LoginUsers.ValidateCredentialsAsync(correo, contrasena);

                        if (!string.IsNullOrEmpty(loginResponse.Token))
                        {
                            MessageBox.Show($"¡Bienvenido {loginResponse.Nombres}!", "Registro Exitoso");

                            _apiClient.SetAuthToken(loginResponse.Token);

                            CargarFormulario(loginResponse.IdRol, loginResponse.IdUsuario);

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registro exitoso, pero falló el inicio de sesión automático. Por favor inicie sesión manualmente.");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al registrar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                rutaImagenSeleccionada = dlgImagenPerfil.FileName; 
            }
        }

        private void PcbFotoPerfil_Click(object sender, EventArgs e)
        {
            SeleccionarImagen();
        }

        private async void CargarRoles()
        {
            try
            {
                var roles = await _apiClient.LoginUsers.GetRolesAsync();
                cborol.DataSource = roles;
                cborol.DisplayMember = "NombreRol";
                cborol.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar roles: {ex.Message}");
            }
        }

        private void CargarFormulario(int idRol, int idUsuario)
        {
            switch (idRol)
            {
                case 1:
                    var adminForm = new AdministradorMainForm();
                    adminForm.Show();
                    break;
                case 2:
                    var docenForm = new DocentesMainForm();
                    docenForm.Show();
                    break;
                case 3:
                    var mainForm = new MainForm();
                    mainForm.Show();
                    break;
                default:
                    MessageBox.Show("Rol desconocido. Contacte a soporte.");
                    this.Show();
                    break;
            }
        }
    }
}
