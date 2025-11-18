using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Net.Http.Json;
//using VirtualBook.DTOs;
using VirtualBook.Views;

namespace VirtualBook.UserControls
{
    public partial class LibroCard : UserControl
    {
        public event EventHandler DetallesClick;
        public LibroCard()
        {
            InitializeComponent();
        }

        private int radioBorde = 40;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Titulo { get => LblTitulo.Text; set => LblTitulo.Text = value; }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Autor { get => LblAutor.Text; set => LblAutor.Text = value; }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Sinopsis { get => LblCategoria.Text; set => LblCategoria.Text = value; }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string UrlPortada
        {
            get => PicPortada.ImageLocation;
            set
            {
                try
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        PicPortada.LoadAsync(value);
                    }
                    else
                    {
                        PicPortada.Image = Properties.Resources.placeholder;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al cargar imagen {value}: {ex.Message}");
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            using (GraphicsPath path = GetRoundedRectPath(bounds, radioBorde))
            {
                this.Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float r = radius;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            DetallesClick?.Invoke(this, e);
        }
    }
}
