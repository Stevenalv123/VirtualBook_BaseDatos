using Newtonsoft.Json;
using System.Net.Http.Json;
using VirtualBook.Views.AdminViews;
using VirtualBook.Views.UploadBookForm;

namespace VirtualBook.Views
{
    public partial class AdminDashboardForm : Form
    {
        Panel PanelCentral;
        private Form ActiveForm;
        int _idUsuario = 0;
        IMainForm mf;
        string descargasUrl = "https://localhost:7014/api/Descargas";
        HttpClient cliente = new HttpClient();
        public AdminDashboardForm(IMainForm _mf, int idUsuario)
        {
            InitializeComponent();
            mf = _mf;
            _idUsuario = idUsuario;
            CargarDescargas();
        }

        private void borderedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void CargarLibros()
        {
            string totalLibrosURL = "https://localhost:7014/api/Libroes/totalLibros";
            string LibrosURL = "https://localhost:7014/api/Libroes/dataLibro";
            string TotalUsuariosURL = "https://localhost:7014/api/Usuarios/total";

            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        var response = await client.GetAsync(LibrosURL);
            //        var TotalLibros = await client.GetAsync(totalLibrosURL);
            //        var Usuarios = await client.GetAsync(TotalUsuariosURL);

            //        if (response.IsSuccessStatusCode)
            //        {
            //            //var usuarios = await response.Content.ReadFromJsonAsync<List<DTOs.ReadLibroDTO>>();
            //            var json = await response.Content.ReadAsStringAsync();
            //            var list = JsonConvert.DeserializeObject<List<DTOs.ReadDataLibroDTO>>(json);
            //            int total = Convert.ToInt32(await TotalLibros.Content.ReadAsStringAsync());
            //            int totalUsuarios = Convert.ToInt32(await Usuarios.Content.ReadAsStringAsync());

            //            lblTotalLibros.Text = total.ToString();
            //            lblTotalUsuarios.Text = totalUsuarios.ToString();
            //            dgvShowBooks.DataSource = list;
            //        }
            //        else
            //        {
            //            MessageBox.Show(Text = $"Error al cargar los Libros: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al cargar los libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    ;
            //}
        }

        private void BtnAgregarNuevoLibro_Click(object sender, EventArgs e)
        {
            mf.OpenForm(new UploadBookForm.UploadBookForm(_idUsuario, mf));
        }

        private void OpenForm(Form ChildForm)
        {
            if (ActiveForm != null) ActiveForm.Close();
            ActiveForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            TemaManager.AplicarTema(ChildForm, TemaManager.ModoOscuroActivo);
            PanelCentral.Controls.Add(ChildForm);
            PanelCentral.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private bool IsFormOpen(Type formType)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == formType)
                {
                    return true;
                }
            }
            return false;
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            CargarLibros();
        }

        private async void BucarLibros_Click(object sender, EventArgs e)
        {
            string filtro = TxtBucarLibros.Text;
            string api = $"https://localhost:7014/api/Libroes/buscar?Busqueda={filtro}";


            //using (HttpClient client = new HttpClient())
            //{
            //    try
            //    {
            //        var response = await client.GetAsync(api);


            //        if (response.IsSuccessStatusCode)
            //        {
            //            var libros = await response.Content.ReadFromJsonAsync<List<DTOs.ReadDataLibroDTO>>();

            //            dgvShowBooks.DataSource = libros;

            //        }
            //        else
            //        {
            //            MessageBox.Show($"Error al cargar los libros: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"Error al cargar los libros: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        //private List<ReadDescargaDTO> todasLasDescargas = new List<ReadDescargaDTO>();

        private async Task CargarDescargas()
        {
            //try
            //{
            //    todasLasDescargas = await cliente.GetFromJsonAsync<List<ReadDescargaDTO>>(descargasUrl);
            //    ActualizarContadorDescargas(todasLasDescargas.Count);
            //    lblDescargas.Text = todasLasDescargas.Count.ToString();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error cargando descargas: " + ex.Message);
            //}
        }
        private void ActualizarContadorDescargas(int total)
        {
            lblDescargas.Text = total.ToString();
        }

    }
}
