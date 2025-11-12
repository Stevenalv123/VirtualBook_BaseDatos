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

namespace VirtualBook.Views.GeneralViews
{
    public partial class NuevoAutorForm : Form
    {
        string baseUrl = "https://localhost:7014/api/Autores/";
        HttpClient client = new HttpClient();
        public NuevoAutorForm()
        {
            InitializeComponent();
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            string nombreAutor = TxtNombreAutor.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombreAutor))
            {
                MessageBox.Show("Por favor, ingrese un nombre de autor.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var response = await client.GetAsync(baseUrl + "Existe?nombre=" + nombreAutor);
                response.EnsureSuccessStatusCode();

                bool yaExiste = bool.Parse(await response.Content.ReadAsStringAsync());

                if (yaExiste)
                {
                    MessageBox.Show("El autor ya existe en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var nuevoAutor = new { NombreAutor = nombreAutor };
                var guardarResponse = await client.PostAsJsonAsync(baseUrl, nuevoAutor);

                if (guardarResponse.IsSuccessStatusCode)
                {
                    MessageBox.Show("Autor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    string errorMessage = await guardarResponse.Content.ReadAsStringAsync();
                    MessageBox.Show($"Error al guardar el autor: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
