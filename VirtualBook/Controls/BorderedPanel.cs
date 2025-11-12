using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace VirtualBook.Controls
{
    [DesignerCategory("Code")]
    public class BorderedPanel : Panel
    {
        private Color borderColor = Color.Blue;
        private int borderSize = 2;
        private int borderRadius = 20;
        
        [Category("Apariencia")]
        public Color BorderColor
        {
            get => borderColor;
            set { borderColor = value; Invalidate(); }
        }

        [Category("Apariencia")]
        public int BorderSize
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }

        [Category("Apariencia")]
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = value; SetRoundedRegion(); }
        }

        public BorderedPanel()
        {
            this.BackColor = Color.White;
            this.Resize += (s, e) => SetRoundedRegion();
        }

        private void SetRoundedRegion()
        {
            if (BorderRadius > 0)
            {
                var path = GetRoundedRectanglePath(this.ClientRectangle, BorderRadius);
                this.Region = new Region(path);
                this.Invalidate();
            }
            else
            {
                this.Region = null;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (BorderRadius > 0)
            {
                var rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1);
                using (GraphicsPath path = GetRoundedRectanglePath(rect, BorderRadius))
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else
            {
                using (Pen pen = new Pen(BorderColor, BorderSize))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
