namespace VirtualBook.Views
{
    partial class BookInfoForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookInfoForms));
            BtnRegresar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panel2 = new Panel();
            PcbCargando = new PictureBox();
            btnEnviarResena = new VirtualBook.Controls.RJButton();
            label1 = new Label();
            txtReseña = new RichTextBox();
            PcbFotoPerfilPublicador = new VirtualBook.Controls.RoundedPictureBox();
            BtnSeguir = new VirtualBook.Controls.RJButton();
            LblNumeroPaginas = new Label();
            label7 = new Label();
            BtnCompartir = new FontAwesome.Sharp.IconButton();
            LblPublicadoPor = new Label();
            label6 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            LblDescargas = new Label();
            LblDescripcion = new Label();
            label9 = new Label();
            LblFormato = new Label();
            LblIdioma = new Label();
            LblAñoPublicacion = new Label();
            LblCategoria = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            LblAutor = new Label();
            LblTitulo = new Label();
            BtnDescargar = new FontAwesome.Sharp.Material.MaterialButton();
            BtnAgregarFavoritos = new FontAwesome.Sharp.Material.MaterialButton();
            BtnLeer = new Button();
            PcbPortada = new PictureBox();
            label8 = new Label();
            flpReseñas = new FlowLayoutPanel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargando).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfilPublicador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbPortada).BeginInit();
            SuspendLayout();
            // 
            // BtnRegresar
            // 
            BtnRegresar.FlatAppearance.BorderSize = 0;
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.Font = new Font("Arial", 10F);
            BtnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            BtnRegresar.IconColor = Color.Black;
            BtnRegresar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnRegresar.IconSize = 32;
            BtnRegresar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRegresar.Location = new Point(12, 12);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(164, 38);
            BtnRegresar.TabIndex = 0;
            BtnRegresar.Text = "Regresar al menú";
            BtnRegresar.TextAlign = ContentAlignment.MiddleRight;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnRegresar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1094, 59);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(PcbCargando);
            panel2.Controls.Add(btnEnviarResena);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtReseña);
            panel2.Controls.Add(PcbFotoPerfilPublicador);
            panel2.Controls.Add(BtnSeguir);
            panel2.Controls.Add(LblNumeroPaginas);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(BtnCompartir);
            panel2.Controls.Add(LblPublicadoPor);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(iconPictureBox1);
            panel2.Controls.Add(LblDescargas);
            panel2.Controls.Add(LblDescripcion);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(LblFormato);
            panel2.Controls.Add(LblIdioma);
            panel2.Controls.Add(LblAñoPublicacion);
            panel2.Controls.Add(LblCategoria);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(LblAutor);
            panel2.Controls.Add(LblTitulo);
            panel2.Controls.Add(BtnDescargar);
            panel2.Controls.Add(BtnAgregarFavoritos);
            panel2.Controls.Add(BtnLeer);
            panel2.Controls.Add(PcbPortada);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50);
            panel2.Size = new Size(1094, 642);
            panel2.TabIndex = 2;
            // 
            // PcbCargando
            // 
            PcbCargando.Image = Properties.Resources.cargandoLibro;
            PcbCargando.Location = new Point(23, 18);
            PcbCargando.Name = "PcbCargando";
            PcbCargando.Size = new Size(1042, 443);
            PcbCargando.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbCargando.TabIndex = 25;
            PcbCargando.TabStop = false;
            // 
            // btnEnviarResena
            // 
            btnEnviarResena.BackColor = Color.FromArgb(45, 154, 134);
            btnEnviarResena.BackgroundColor = Color.FromArgb(45, 154, 134);
            btnEnviarResena.BorderColor = Color.PaleVioletRed;
            btnEnviarResena.BorderRadius = 5;
            btnEnviarResena.BorderSize = 0;
            btnEnviarResena.Cursor = Cursors.Hand;
            btnEnviarResena.FlatAppearance.BorderSize = 0;
            btnEnviarResena.FlatStyle = FlatStyle.Flat;
            btnEnviarResena.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEnviarResena.ForeColor = Color.White;
            btnEnviarResena.Location = new Point(641, 548);
            btnEnviarResena.Name = "btnEnviarResena";
            btnEnviarResena.Size = new Size(94, 28);
            btnEnviarResena.TabIndex = 28;
            btnEnviarResena.Text = "Enviar";
            btnEnviarResena.TextColor = Color.White;
            btnEnviarResena.UseVisualStyleBackColor = false;
            btnEnviarResena.Click += btnEnviarResena_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 12F);
            label1.ForeColor = Color.FromArgb(113, 113, 122);
            label1.Location = new Point(357, 527);
            label1.Name = "label1";
            label1.Size = new Size(114, 18);
            label1.TabIndex = 27;
            label1.Text = "Escribir reseña";
            // 
            // txtReseña
            // 
            txtReseña.Location = new Point(357, 548);
            txtReseña.Name = "txtReseña";
            txtReseña.Size = new Size(278, 66);
            txtReseña.TabIndex = 26;
            txtReseña.Text = "";
            // 
            // PcbFotoPerfilPublicador
            // 
            PcbFotoPerfilPublicador.BackColor = Color.Transparent;
            PcbFotoPerfilPublicador.BorderColor = Color.Transparent;
            PcbFotoPerfilPublicador.BorderSize = 0;
            PcbFotoPerfilPublicador.Location = new Point(656, 431);
            PcbFotoPerfilPublicador.Name = "PcbFotoPerfilPublicador";
            PcbFotoPerfilPublicador.Size = new Size(30, 30);
            PcbFotoPerfilPublicador.SizeMode = PictureBoxSizeMode.Zoom;
            PcbFotoPerfilPublicador.TabIndex = 24;
            PcbFotoPerfilPublicador.TabStop = false;
            // 
            // BtnSeguir
            // 
            BtnSeguir.BackColor = Color.FromArgb(45, 154, 134);
            BtnSeguir.BackgroundColor = Color.FromArgb(45, 154, 134);
            BtnSeguir.BorderColor = Color.PaleVioletRed;
            BtnSeguir.BorderRadius = 5;
            BtnSeguir.BorderSize = 0;
            BtnSeguir.Cursor = Cursors.Hand;
            BtnSeguir.FlatAppearance.BorderSize = 0;
            BtnSeguir.FlatStyle = FlatStyle.Flat;
            BtnSeguir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnSeguir.ForeColor = Color.White;
            BtnSeguir.Location = new Point(832, 433);
            BtnSeguir.Name = "BtnSeguir";
            BtnSeguir.Size = new Size(117, 28);
            BtnSeguir.TabIndex = 23;
            BtnSeguir.Text = "Seguir";
            BtnSeguir.TextColor = Color.White;
            BtnSeguir.UseVisualStyleBackColor = false;
            BtnSeguir.Click += BtnSeguir_Click;
            // 
            // LblNumeroPaginas
            // 
            LblNumeroPaginas.AutoSize = true;
            LblNumeroPaginas.Font = new Font("Arial", 12F);
            LblNumeroPaginas.Location = new Point(359, 262);
            LblNumeroPaginas.Name = "LblNumeroPaginas";
            LblNumeroPaginas.Size = new Size(26, 18);
            LblNumeroPaginas.TabIndex = 22;
            LblNumeroPaginas.Text = "10";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 12F);
            label7.ForeColor = Color.FromArgb(113, 113, 122);
            label7.Location = new Point(359, 235);
            label7.Name = "label7";
            label7.Size = new Size(145, 18);
            label7.TabIndex = 21;
            label7.Text = "Numero de paginas";
            // 
            // BtnCompartir
            // 
            BtnCompartir.Cursor = Cursors.Hand;
            BtnCompartir.FlatAppearance.BorderSize = 0;
            BtnCompartir.FlatStyle = FlatStyle.Flat;
            BtnCompartir.Font = new Font("Arial", 10F);
            BtnCompartir.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            BtnCompartir.IconColor = Color.FromArgb(113, 113, 122);
            BtnCompartir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCompartir.IconSize = 32;
            BtnCompartir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCompartir.Location = new Point(357, 453);
            BtnCompartir.Name = "BtnCompartir";
            BtnCompartir.Size = new Size(138, 37);
            BtnCompartir.TabIndex = 20;
            BtnCompartir.Text = "Compartir libro";
            BtnCompartir.TextAlign = ContentAlignment.MiddleRight;
            BtnCompartir.UseVisualStyleBackColor = true;
            // 
            // LblPublicadoPor
            // 
            LblPublicadoPor.AutoSize = true;
            LblPublicadoPor.Font = new Font("Arial", 12F);
            LblPublicadoPor.Location = new Point(692, 437);
            LblPublicadoPor.Name = "LblPublicadoPor";
            LblPublicadoPor.Size = new Size(0, 18);
            LblPublicadoPor.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Arial", 12F);
            label6.ForeColor = Color.FromArgb(113, 113, 122);
            label6.Location = new Point(656, 413);
            label6.Name = "label6";
            label6.Size = new Size(105, 18);
            label6.TabIndex = 18;
            label6.Text = "Publicado por";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Download;
            iconPictureBox1.IconColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 31;
            iconPictureBox1.Location = new Point(360, 416);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(33, 31);
            iconPictureBox1.TabIndex = 17;
            iconPictureBox1.TabStop = false;
            // 
            // LblDescargas
            // 
            LblDescargas.AutoSize = true;
            LblDescargas.Font = new Font("Arial", 11F);
            LblDescargas.Location = new Point(399, 422);
            LblDescargas.Name = "LblDescargas";
            LblDescargas.Size = new Size(46, 17);
            LblDescargas.TabIndex = 16;
            LblDescargas.Text = "14,7K";
            // 
            // LblDescripcion
            // 
            LblDescripcion.Font = new Font("Arial", 10F);
            LblDescripcion.ForeColor = Color.FromArgb(113, 113, 122);
            LblDescripcion.Location = new Point(359, 331);
            LblDescripcion.Name = "LblDescripcion";
            LblDescripcion.Size = new Size(706, 72);
            LblDescripcion.TabIndex = 15;
            LblDescripcion.Text = resources.GetString("LblDescripcion.Text");
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 14F, FontStyle.Bold);
            label9.Location = new Point(359, 300);
            label9.Name = "label9";
            label9.Size = new Size(122, 22);
            label9.TabIndex = 14;
            label9.Text = "Descripción";
            // 
            // LblFormato
            // 
            LblFormato.AutoSize = true;
            LblFormato.Font = new Font("Arial", 12F);
            LblFormato.Location = new Point(691, 200);
            LblFormato.Name = "LblFormato";
            LblFormato.Size = new Size(32, 18);
            LblFormato.TabIndex = 13;
            LblFormato.Text = "Pdf";
            // 
            // LblIdioma
            // 
            LblIdioma.AutoSize = true;
            LblIdioma.Font = new Font("Arial", 12F);
            LblIdioma.Location = new Point(359, 200);
            LblIdioma.Name = "LblIdioma";
            LblIdioma.Size = new Size(65, 18);
            LblIdioma.TabIndex = 12;
            LblIdioma.Text = "Español";
            // 
            // LblAñoPublicacion
            // 
            LblAñoPublicacion.AutoSize = true;
            LblAñoPublicacion.Font = new Font("Arial", 12F);
            LblAñoPublicacion.Location = new Point(691, 136);
            LblAñoPublicacion.Name = "LblAñoPublicacion";
            LblAñoPublicacion.Size = new Size(44, 18);
            LblAñoPublicacion.TabIndex = 11;
            LblAñoPublicacion.Text = "2022";
            // 
            // LblCategoria
            // 
            LblCategoria.AutoSize = true;
            LblCategoria.Font = new Font("Arial", 12F);
            LblCategoria.Location = new Point(359, 136);
            LblCategoria.Name = "LblCategoria";
            LblCategoria.Size = new Size(192, 18);
            LblCategoria.TabIndex = 10;
            LblCategoria.Text = "Ciencias computacionales";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 12F);
            label5.ForeColor = Color.FromArgb(113, 113, 122);
            label5.Location = new Point(359, 112);
            label5.Name = "label5";
            label5.Size = new Size(78, 18);
            label5.TabIndex = 9;
            label5.Text = "Categoria";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Arial", 12F);
            label4.ForeColor = Color.FromArgb(113, 113, 122);
            label4.Location = new Point(691, 112);
            label4.Name = "label4";
            label4.Size = new Size(141, 18);
            label4.TabIndex = 8;
            label4.Text = "Año de publicación";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 12F);
            label3.ForeColor = Color.FromArgb(113, 113, 122);
            label3.Location = new Point(359, 173);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 7;
            label3.Text = "Idioma";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Arial", 12F);
            label2.ForeColor = Color.FromArgb(113, 113, 122);
            label2.Location = new Point(691, 173);
            label2.Name = "label2";
            label2.Size = new Size(67, 18);
            label2.TabIndex = 6;
            label2.Text = "Formato";
            // 
            // LblAutor
            // 
            LblAutor.AutoSize = true;
            LblAutor.BackColor = Color.White;
            LblAutor.Font = new Font("Arial", 14F);
            LblAutor.ForeColor = Color.FromArgb(113, 113, 122);
            LblAutor.Location = new Point(359, 64);
            LblAutor.Name = "LblAutor";
            LblAutor.Size = new Size(137, 22);
            LblAutor.TabIndex = 5;
            LblAutor.Text = "por John Smith";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Arial", 24F, FontStyle.Bold);
            LblTitulo.Location = new Point(359, 18);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(531, 37);
            LblTitulo.TabIndex = 4;
            LblTitulo.Text = "Introduction to Computer Science";
            // 
            // BtnDescargar
            // 
            BtnDescargar.Cursor = Cursors.Hand;
            BtnDescargar.FlatStyle = FlatStyle.Flat;
            BtnDescargar.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnDescargar.IconChar = FontAwesome.Sharp.MaterialIcons.Download;
            BtnDescargar.IconColor = Color.Black;
            BtnDescargar.IconSize = 44;
            BtnDescargar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDescargar.Location = new Point(23, 453);
            BtnDescargar.Name = "BtnDescargar";
            BtnDescargar.Size = new Size(313, 49);
            BtnDescargar.TabIndex = 3;
            BtnDescargar.Tag = "NoCambiarTema";
            BtnDescargar.Text = "Descargar libro";
            BtnDescargar.UseVisualStyleBackColor = true;
            BtnDescargar.Click += BtnDescargar_Click;
            // 
            // BtnAgregarFavoritos
            // 
            BtnAgregarFavoritos.Cursor = Cursors.Hand;
            BtnAgregarFavoritos.FlatStyle = FlatStyle.Flat;
            BtnAgregarFavoritos.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnAgregarFavoritos.IconChar = FontAwesome.Sharp.MaterialIcons.HeartMultipleOutline;
            BtnAgregarFavoritos.IconColor = Color.Black;
            BtnAgregarFavoritos.IconSize = 44;
            BtnAgregarFavoritos.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarFavoritos.Location = new Point(23, 398);
            BtnAgregarFavoritos.Name = "BtnAgregarFavoritos";
            BtnAgregarFavoritos.Size = new Size(313, 49);
            BtnAgregarFavoritos.TabIndex = 2;
            BtnAgregarFavoritos.Tag = "NoCambiarTema";
            BtnAgregarFavoritos.Text = "Añadir a favoritos";
            BtnAgregarFavoritos.UseVisualStyleBackColor = true;
            BtnAgregarFavoritos.Click += BtnAgregarFavoritos_Click;
            // 
            // BtnLeer
            // 
            BtnLeer.BackColor = Color.FromArgb(45, 154, 134);
            BtnLeer.Cursor = Cursors.Hand;
            BtnLeer.FlatAppearance.BorderSize = 0;
            BtnLeer.FlatStyle = FlatStyle.Flat;
            BtnLeer.Font = new Font("Arial", 12F, FontStyle.Bold);
            BtnLeer.ForeColor = Color.White;
            BtnLeer.Location = new Point(23, 343);
            BtnLeer.Name = "BtnLeer";
            BtnLeer.Size = new Size(313, 49);
            BtnLeer.TabIndex = 1;
            BtnLeer.Tag = "NoCambiarTema";
            BtnLeer.Text = "Leer libro";
            BtnLeer.UseVisualStyleBackColor = false;
            BtnLeer.Click += BtnLeer_Click;
            // 
            // PcbPortada
            // 
            PcbPortada.Image = (Image)resources.GetObject("PcbPortada.Image");
            PcbPortada.Location = new Point(23, 18);
            PcbPortada.Name = "PcbPortada";
            PcbPortada.Size = new Size(313, 319);
            PcbPortada.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbPortada.TabIndex = 0;
            PcbPortada.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 14F, FontStyle.Bold);
            label8.Location = new Point(32, 716);
            label8.Name = "label8";
            label8.Size = new Size(170, 22);
            label8.TabIndex = 15;
            label8.Text = "Reseñas del libro";
            // 
            // flpReseñas
            // 
            flpReseñas.Location = new Point(45, 755);
            flpReseñas.Name = "flpReseñas";
            flpReseñas.Size = new Size(1020, 291);
            flpReseñas.TabIndex = 16;
            // 
            // BookInfoForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1094, 1100);
            Controls.Add(flpReseñas);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookInfoForms";
            Text = "BookInfoForms";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargando).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfilPublicador).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbPortada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnRegresar;
        private Panel panel1;
        private Panel panel2;
        private Button BtnLeer;
        private PictureBox PcbPortada;
        private FontAwesome.Sharp.Material.MaterialButton BtnAgregarFavoritos;
        private Label LblTitulo;
        private FontAwesome.Sharp.Material.MaterialButton BtnDescargar;
        private Label LblAutor;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label LblDescripcion;
        private Label label9;
        private Label LblFormato;
        private Label LblAñoPublicacion;
        private Label LblCategoria;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label LblDescargas;
        private Label LblPublicadoPor;
        private Label label6;
        private FontAwesome.Sharp.IconButton BtnCompartir;
        private Label LblIdioma;
        private Label label3;
        private Label LblNumeroPaginas;
        private Label label7;
        private Controls.RoundedPictureBox PcbFotoPerfilPublicador;
        private Controls.RJButton BtnSeguir;
        private PictureBox PcbCargando;
        private Label label1;
        private RichTextBox txtReseña;
        private Controls.RJButton btnEnviarResena;
        private Label label8;
        private FlowLayoutPanel flpReseñas;
    }
}