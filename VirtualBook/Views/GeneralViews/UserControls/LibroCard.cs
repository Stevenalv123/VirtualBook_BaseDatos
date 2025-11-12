using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Net.Http.Json;
using VirtualBook.DTOs;
using VirtualBook.Views;

namespace VirtualBook.UserControls
{
    public partial class LibroCard : UserControl
    {
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
            set => PicPortada.Load(value);
        }

        ReadVistaPreviaLibro _libro;
        string baseUrl = "https://localhost:7014/api/";
        HttpClient cliente = new();
        IMainForm _mainform;

        public LibroCard(ReadVistaPreviaLibro libro, IMainForm mainForm)
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint |
                  ControlStyles.DoubleBuffer, true);

            this.Margin = new Padding(10);

            // Redondeo automático al cambiar tamaño
            this.Resize += (s, e) => this.Invalidate();



            // Efecto hover
            Color originalColor = this.BackColor;

            this.MouseEnter += (s, e) => this.BackColor = Color.AliceBlue;
            this.MouseLeave += (s, e) => this.BackColor = originalColor;

            foreach (Control c in this.Controls)
            {
                c.MouseEnter += (s, e) => this.BackColor = Color.AliceBlue;
                c.MouseLeave += (s, e) => this.BackColor = originalColor;
            }

            _libro = libro;
            CargarInfo();
            _mainform = mainForm;
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

        private void CargarInfo()
        {
            LblTitulo.Text = _libro.Titulo;
            LblAutor.Text = _libro.Autor;
            LblCategoria.Text = _libro.Categoria;
            if (_libro.Portada != null && _libro.Portada.Length > 0)
            {
                using (var ms = new MemoryStream(_libro.Portada))
                {
                    PicPortada.Image = Image.FromStream(ms);
                    PicPortada.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                PicPortada.Image = null;
            }
        }

        private void BtnDetalles_Click(object sender, EventArgs e)
        {
            if (_mainform != null)
            {
                var detalles=new BookInfoForms(_libro.IdLibro, _mainform);
                _mainform.OpenForm(detalles);
            }
        }
    }
}
