using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualBook.Views
{
    public partial class PdfVisorForm : Form
    {
        public PdfVisorForm(string rutaPDF)
        {
            InitializeComponent();
            this.Text = "Lectura del libro";

            WebBrowser visor = new WebBrowser
            {
                Dock = DockStyle.Fill,
                Url = new Uri(rutaPDF)
            };

            this.Controls.Add(visor);
        }
    }
}
