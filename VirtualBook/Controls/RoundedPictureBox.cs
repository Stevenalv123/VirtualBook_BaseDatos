using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualBook.Controls
{
    public class RoundedPictureBox : PictureBox
    {
        public int BorderSize { get; set; } = 2;
        public Color BorderColor { get; set; } = Color.Gray;

        public RoundedPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom; 
            this.BackColor = Color.Transparent;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            SetRoundedRegion();
        }

        private void SetRoundedRegion()
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, this.Width, this.Height);
                this.Region = new Region(path);
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (BorderSize > 0)
            {
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    pe.Graphics.DrawEllipse(pen, BorderSize / 2, BorderSize / 2,
                        this.Width - BorderSize, this.Height - BorderSize);
                }
            }
        }
    }
}
