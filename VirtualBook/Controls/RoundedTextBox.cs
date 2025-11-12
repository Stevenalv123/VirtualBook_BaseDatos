using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VirtualBook.Controls
{
    public class RoundedTextBox : TextBox
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeft, int nTop, int nRight, int nBottom,
            int nWidthEllipse, int nHeightEllipse);

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            int radius = 15; // radio de las esquinas redondeadas
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int radius = 15;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, radius, radius));
        }
    }

}
