namespace VirtualBook.UserControls
{
    partial class LibroCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            BtnDetalles = new FontAwesome.Sharp.IconButton();
            LblCategoria = new Label();
            LblAutor = new Label();
            PicPortada = new PictureBox();
            LblTitulo = new Label();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            ((System.ComponentModel.ISupportInitialize)PicPortada).BeginInit();
            borderedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnDetalles
            // 
            BtnDetalles.Cursor = Cursors.Hand;
            BtnDetalles.FlatAppearance.BorderSize = 0;
            BtnDetalles.FlatStyle = FlatStyle.Flat;
            BtnDetalles.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnDetalles.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnDetalles.IconColor = Color.Black;
            BtnDetalles.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnDetalles.Location = new Point(183, 284);
            BtnDetalles.Name = "BtnDetalles";
            BtnDetalles.Size = new Size(89, 28);
            BtnDetalles.TabIndex = 8;
            BtnDetalles.Text = "Detalles  >";
            BtnDetalles.UseVisualStyleBackColor = true;
            //BtnDetalles.Click += BtnDetalles_Click;
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Segoe UI", 9.75F);
            LblCategoria.ForeColor = SystemColors.ControlDark;
            LblCategoria.Location = new Point(25, 295);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(43, 17);
            LblCategoria.TabIndex = 7;
            LblCategoria.Text = "label1";
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.Font = new Font("Segoe UI", 9.75F);
            LblAutor.ForeColor = SystemColors.ControlDark;
            LblAutor.Location = new Point(25, 35);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(43, 17);
            LblAutor.TabIndex = 6;
            LblAutor.Text = "label1";
            // 
            // PicPortada
            // 
            PicPortada.Location = new Point(56, 64);
            PicPortada.Margin = new Padding(3, 2, 3, 2);
            PicPortada.Name = "PicPortada";
            PicPortada.Size = new Size(174, 206);
            PicPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            PicPortada.TabIndex = 5;
            PicPortada.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(25, 14);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(57, 21);
            LblTitulo.TabIndex = 4;
            LblTitulo.Text = "label1";
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = SystemColors.ControlLight;
            borderedPanel1.BorderRadius = 20;
            borderedPanel1.BorderSize = 1;
            borderedPanel1.Controls.Add(PicPortada);
            borderedPanel1.Controls.Add(BtnDetalles);
            borderedPanel1.Controls.Add(LblCategoria);
            borderedPanel1.Controls.Add(LblTitulo);
            borderedPanel1.Controls.Add(LblAutor);
            borderedPanel1.Location = new Point(3, 1);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(291, 321);
            borderedPanel1.TabIndex = 9;
            // 
            // LibroCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            Controls.Add(borderedPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LibroCard";
            Size = new Size(297, 325);
            ((System.ComponentModel.ISupportInitialize)PicPortada).EndInit();
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LblCategoria;
        private Label LblAutor;
        private PictureBox PicPortada;
        private Label LblTitulo;
        private FontAwesome.Sharp.IconButton BtnDetalles;
        private Controls.BorderedPanel borderedPanel1;
    }
}
