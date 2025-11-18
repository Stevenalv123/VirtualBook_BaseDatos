using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualBook.Controller;
using VirtualBook.Models.DTO;

namespace VirtualBook.Views.GeneralViews
{
    public partial class NuevoAutorForm : Form
    {
        private readonly ApiClient _apiClient;
        public int NuevoAutorId { get; private set; } = 0;
        public NuevoAutorForm()
        {
            InitializeComponent();
            _apiClient = ApiClient.Instance;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            var nuevoAutor = new AutorRequestDTO
            {
                NombreAutor = TxtNombre.Text,
                Biografia = TxtBio.Text,
                Nacionalidad = TxtNacionalidad.Text,
                FechaNacimiento = DtpFecha.Value
            };

            BtnGuardar.Enabled = false;

            try
            {
                int id = await _apiClient.Data.CrearAutorAsync(nuevoAutor);

                if (id > 0)
                {
                    NuevoAutorId = id;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al crear autor.");
                    BtnGuardar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                BtnGuardar.Enabled = true;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
