using System;
using System.Drawing;
using System.Windows.Forms;

namespace VirtualBook.Views.GeneralViews.UserControls
{
    public partial class ReseñasCard : UserControl
    {
        public ReseñasCard()
        {
            InitializeComponent();
        }

        // Pega esto dentro de: public partial class ReseñasCard : UserControl { ... }

        public void ConfigurarDatos(string nombreUsuario, string comentario, string urlFoto)
        {
            // 1. Asignar textos (usando los nombres de tu Designer)
            lblNombreUsuario.Text = nombreUsuario;
            lblComentario.Text = comentario;

            // 2. Cargar foto
            try
            {
                if (!string.IsNullOrEmpty(urlFoto))
                    PcbFotoPerfilUsuario.LoadAsync(urlFoto);
                else
                    PcbFotoPerfilUsuario.Image = Properties.Resources.avatar;
            }
            catch
            {
                PcbFotoPerfilUsuario.Image = Properties.Resources.avatar;
            }

            // 3. Ajustar altura de la tarjeta según el texto del comentario
            AjustarAltura();
        }

        private void AjustarAltura()
        {
            // Mide cuánto espacio ocupa el texto
            Size sz = TextRenderer.MeasureText(lblComentario.Text, lblComentario.Font, new Size(lblComentario.Width, 0), TextFormatFlags.WordBreak);

            // Calcula la nueva altura: Posición Y del label + Altura texto + Margen inferior
            int nuevaAltura = lblComentario.Location.Y + sz.Height + 20;

            // Si es más grande que la tarjeta original, la estiramos
            if (nuevaAltura > this.Height)
            {
                this.Height = nuevaAltura;
            }
        }
    }
}