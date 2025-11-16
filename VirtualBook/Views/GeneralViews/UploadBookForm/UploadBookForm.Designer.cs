namespace VirtualBook.Views.UploadBookForm
{
    partial class UploadBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UploadBookForm));
            panel1 = new Panel();
            BtnAñadirAutor = new VirtualBook.Controls.BorderedPanel();
            BtnAgregarAutor = new VirtualBook.Controls.RJButton();
            borderedPanel13 = new VirtualBook.Controls.BorderedPanel();
            CmbFormato = new ComboBox();
            borderedPanel11 = new VirtualBook.Controls.BorderedPanel();
            CmbIdioma = new ComboBox();
            btnCancel = new VirtualBook.Controls.RJButton();
            BtnAgregarLibro = new VirtualBook.Controls.RJButton();
            borderedPanel10 = new VirtualBook.Controls.BorderedPanel();
            CmbCategoria = new ComboBox();
            label14 = new Label();
            borderedPanel9 = new VirtualBook.Controls.BorderedPanel();
            TxtNumeroPaginas = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            borderedPanel7 = new VirtualBook.Controls.BorderedPanel();
            label10 = new Label();
            borderedPanel6 = new VirtualBook.Controls.BorderedPanel();
            TxtDescripcion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            borderedPanel3 = new VirtualBook.Controls.BorderedPanel();
            TxtTitulo = new TextBox();
            label4 = new Label();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            PcbLibroPortada = new FontAwesome.Sharp.Material.MaterialPictureBox();
            LblStatusArchivo = new Label();
            btnAddFile = new VirtualBook.Controls.RJButton();
            label3 = new Label();
            LblStatus = new Label();
            btnAddCover = new VirtualBook.Controls.RJButton();
            label1 = new Label();
            CmbAutor = new ComboBox();
            panel1.SuspendLayout();
            BtnAñadirAutor.SuspendLayout();
            borderedPanel13.SuspendLayout();
            borderedPanel11.SuspendLayout();
            borderedPanel10.SuspendLayout();
            borderedPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TxtNumeroPaginas).BeginInit();
            borderedPanel7.SuspendLayout();
            borderedPanel6.SuspendLayout();
            borderedPanel3.SuspendLayout();
            borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbLibroPortada).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(BtnAñadirAutor);
            panel1.Controls.Add(borderedPanel1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 710);
            panel1.TabIndex = 0;
            // 
            // BtnAñadirAutor
            // 
            BtnAñadirAutor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BtnAñadirAutor.BackColor = Color.White;
            BtnAñadirAutor.BorderColor = Color.FromArgb(224, 224, 224);
            BtnAñadirAutor.BorderRadius = 20;
            BtnAñadirAutor.BorderSize = 2;
            BtnAñadirAutor.Controls.Add(BtnAgregarAutor);
            BtnAñadirAutor.Controls.Add(borderedPanel13);
            BtnAñadirAutor.Controls.Add(borderedPanel11);
            BtnAñadirAutor.Controls.Add(btnCancel);
            BtnAñadirAutor.Controls.Add(BtnAgregarLibro);
            BtnAñadirAutor.Controls.Add(borderedPanel10);
            BtnAñadirAutor.Controls.Add(label14);
            BtnAñadirAutor.Controls.Add(borderedPanel9);
            BtnAñadirAutor.Controls.Add(label13);
            BtnAñadirAutor.Controls.Add(label12);
            BtnAñadirAutor.Controls.Add(borderedPanel7);
            BtnAñadirAutor.Controls.Add(label10);
            BtnAñadirAutor.Controls.Add(borderedPanel6);
            BtnAñadirAutor.Controls.Add(label7);
            BtnAñadirAutor.Controls.Add(label6);
            BtnAñadirAutor.Controls.Add(borderedPanel3);
            BtnAñadirAutor.Controls.Add(label4);
            BtnAñadirAutor.Location = new Point(341, 12);
            BtnAñadirAutor.Name = "BtnAñadirAutor";
            BtnAñadirAutor.Size = new Size(617, 686);
            BtnAñadirAutor.TabIndex = 1;
            // 
            // BtnAgregarAutor
            // 
            BtnAgregarAutor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregarAutor.BackColor = Color.Black;
            BtnAgregarAutor.BackgroundColor = Color.Black;
            BtnAgregarAutor.BorderColor = Color.PaleVioletRed;
            BtnAgregarAutor.BorderRadius = 5;
            BtnAgregarAutor.BorderSize = 0;
            BtnAgregarAutor.Cursor = Cursors.Hand;
            BtnAgregarAutor.FlatAppearance.BorderSize = 0;
            BtnAgregarAutor.FlatStyle = FlatStyle.Flat;
            BtnAgregarAutor.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            BtnAgregarAutor.ForeColor = Color.White;
            BtnAgregarAutor.Location = new Point(550, 38);
            BtnAgregarAutor.Name = "BtnAgregarAutor";
            BtnAgregarAutor.Size = new Size(34, 34);
            BtnAgregarAutor.TabIndex = 28;
            BtnAgregarAutor.Tag = "NoCambiarTema";
            BtnAgregarAutor.Text = "+";
            BtnAgregarAutor.TextColor = Color.White;
            BtnAgregarAutor.UseVisualStyleBackColor = false;
            // 
            // borderedPanel13
            // 
            borderedPanel13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderedPanel13.BackColor = Color.White;
            borderedPanel13.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel13.BorderRadius = 10;
            borderedPanel13.BorderSize = 2;
            borderedPanel13.Controls.Add(CmbFormato);
            borderedPanel13.Location = new Point(318, 101);
            borderedPanel13.Name = "borderedPanel13";
            borderedPanel13.Size = new Size(274, 34);
            borderedPanel13.TabIndex = 27;
            // 
            // CmbFormato
            // 
            CmbFormato.BackColor = Color.White;
            CmbFormato.FlatStyle = FlatStyle.Flat;
            CmbFormato.ForeColor = Color.FromArgb(64, 64, 64);
            CmbFormato.FormattingEnabled = true;
            CmbFormato.Location = new Point(12, 5);
            CmbFormato.Name = "CmbFormato";
            CmbFormato.Size = new Size(248, 23);
            CmbFormato.TabIndex = 5;
            // 
            // borderedPanel11
            // 
            borderedPanel11.BackColor = Color.White;
            borderedPanel11.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel11.BorderRadius = 10;
            borderedPanel11.BorderSize = 2;
            borderedPanel11.Controls.Add(CmbIdioma);
            borderedPanel11.Location = new Point(15, 167);
            borderedPanel11.Name = "borderedPanel11";
            borderedPanel11.Size = new Size(270, 34);
            borderedPanel11.TabIndex = 25;
            // 
            // CmbIdioma
            // 
            CmbIdioma.FlatStyle = FlatStyle.Flat;
            CmbIdioma.FormattingEnabled = true;
            CmbIdioma.Items.AddRange(new object[] { "Inglés", "Español", "Francés", "Alemán", "Chino", "Japonés", "Italiano", "Portugués", "Ruso", "Árabe", "Hindi", "Coreano", "Neerlandés", "Sueco", "Turco", "Polaco", "Danés", "Noruego", "Griego", "Hebreo" });
            CmbIdioma.Location = new Point(8, 6);
            CmbIdioma.Name = "CmbIdioma";
            CmbIdioma.Size = new Size(248, 23);
            CmbIdioma.TabIndex = 7;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.BackColor = Color.FromArgb(224, 224, 224);
            btnCancel.BackgroundColor = Color.FromArgb(224, 224, 224);
            btnCancel.BorderColor = Color.PaleVioletRed;
            btnCancel.BorderRadius = 5;
            btnCancel.BorderSize = 0;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(375, 638);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(99, 32);
            btnCancel.TabIndex = 24;
            btnCancel.Tag = "NoCambiarTema";
            btnCancel.Text = "Cancel";
            btnCancel.TextColor = Color.Black;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // BtnAgregarLibro
            // 
            BtnAgregarLibro.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnAgregarLibro.BackColor = Color.Black;
            BtnAgregarLibro.BackgroundColor = Color.Black;
            BtnAgregarLibro.BorderColor = Color.PaleVioletRed;
            BtnAgregarLibro.BorderRadius = 5;
            BtnAgregarLibro.BorderSize = 0;
            BtnAgregarLibro.FlatAppearance.BorderSize = 0;
            BtnAgregarLibro.FlatStyle = FlatStyle.Flat;
            BtnAgregarLibro.ForeColor = Color.White;
            BtnAgregarLibro.Location = new Point(480, 638);
            BtnAgregarLibro.Name = "BtnAgregarLibro";
            BtnAgregarLibro.Size = new Size(124, 32);
            BtnAgregarLibro.TabIndex = 23;
            BtnAgregarLibro.Tag = "NoCambiarTema";
            BtnAgregarLibro.Text = "Add Book";
            BtnAgregarLibro.TextColor = Color.White;
            BtnAgregarLibro.UseVisualStyleBackColor = false;
            BtnAgregarLibro.Click += BtnAgregarLibro_Click;
            // 
            // borderedPanel10
            // 
            borderedPanel10.BackColor = Color.White;
            borderedPanel10.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel10.BorderRadius = 10;
            borderedPanel10.BorderSize = 2;
            borderedPanel10.Controls.Add(CmbCategoria);
            borderedPanel10.Location = new Point(15, 101);
            borderedPanel10.Name = "borderedPanel10";
            borderedPanel10.Size = new Size(270, 34);
            borderedPanel10.TabIndex = 22;
            // 
            // CmbCategoria
            // 
            CmbCategoria.BackColor = Color.White;
            CmbCategoria.FlatStyle = FlatStyle.Flat;
            CmbCategoria.ForeColor = Color.FromArgb(64, 64, 64);
            CmbCategoria.FormattingEnabled = true;
            CmbCategoria.Location = new Point(8, 5);
            CmbCategoria.Name = "CmbCategoria";
            CmbCategoria.Size = new Size(248, 23);
            CmbCategoria.TabIndex = 4;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Location = new Point(15, 214);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 21;
            label14.Text = "Descripcion";
            // 
            // borderedPanel9
            // 
            borderedPanel9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderedPanel9.BackColor = Color.White;
            borderedPanel9.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel9.BorderRadius = 10;
            borderedPanel9.BorderSize = 2;
            borderedPanel9.Controls.Add(TxtNumeroPaginas);
            borderedPanel9.Location = new Point(318, 165);
            borderedPanel9.Name = "borderedPanel9";
            borderedPanel9.Size = new Size(274, 34);
            borderedPanel9.TabIndex = 20;
            // 
            // TxtNumeroPaginas
            // 
            TxtNumeroPaginas.BorderStyle = BorderStyle.None;
            TxtNumeroPaginas.Font = new Font("Segoe UI", 11F);
            TxtNumeroPaginas.Location = new Point(12, 5);
            TxtNumeroPaginas.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            TxtNumeroPaginas.Name = "TxtNumeroPaginas";
            TxtNumeroPaginas.Size = new Size(251, 23);
            TxtNumeroPaginas.TabIndex = 0;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(319, 147);
            label13.Name = "label13";
            label13.Size = new Size(111, 15);
            label13.TabIndex = 19;
            label13.Text = "Numero de paginas";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(318, 81);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 17;
            label12.Text = "Formato";
            // 
            // borderedPanel7
            // 
            borderedPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderedPanel7.BackColor = Color.White;
            borderedPanel7.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel7.BorderRadius = 10;
            borderedPanel7.BorderSize = 2;
            borderedPanel7.Controls.Add(CmbAutor);
            borderedPanel7.Location = new Point(318, 38);
            borderedPanel7.Name = "borderedPanel7";
            borderedPanel7.Size = new Size(226, 34);
            borderedPanel7.TabIndex = 14;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(318, 20);
            label10.Name = "label10";
            label10.Size = new Size(42, 15);
            label10.TabIndex = 13;
            label10.Text = "Autor*";
            // 
            // borderedPanel6
            // 
            borderedPanel6.BackColor = Color.White;
            borderedPanel6.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel6.BorderRadius = 10;
            borderedPanel6.BorderSize = 2;
            borderedPanel6.Controls.Add(TxtDescripcion);
            borderedPanel6.Location = new Point(15, 232);
            borderedPanel6.Name = "borderedPanel6";
            borderedPanel6.Size = new Size(554, 132);
            borderedPanel6.TabIndex = 12;
            // 
            // TxtDescripcion
            // 
            TxtDescripcion.BorderStyle = BorderStyle.None;
            TxtDescripcion.Location = new Point(6, 3);
            TxtDescripcion.Multiline = true;
            TxtDescripcion.Name = "TxtDescripcion";
            TxtDescripcion.Size = new Size(545, 126);
            TxtDescripcion.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 147);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 6;
            label7.Text = "Idioma";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 81);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 5;
            label6.Text = "Categoria*";
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = Color.White;
            borderedPanel3.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel3.BorderRadius = 10;
            borderedPanel3.BorderSize = 2;
            borderedPanel3.Controls.Add(TxtTitulo);
            borderedPanel3.Location = new Point(15, 38);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Size = new Size(270, 34);
            borderedPanel3.TabIndex = 1;
            // 
            // TxtTitulo
            // 
            TxtTitulo.BorderStyle = BorderStyle.None;
            TxtTitulo.Location = new Point(8, 8);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(248, 16);
            TxtTitulo.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 20);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 0;
            label4.Text = "Titulo*";
            // 
            // borderedPanel1
            // 
            borderedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            borderedPanel1.BorderRadius = 20;
            borderedPanel1.BorderSize = 2;
            borderedPanel1.Controls.Add(PcbLibroPortada);
            borderedPanel1.Controls.Add(LblStatusArchivo);
            borderedPanel1.Controls.Add(btnAddFile);
            borderedPanel1.Controls.Add(label3);
            borderedPanel1.Controls.Add(LblStatus);
            borderedPanel1.Controls.Add(btnAddCover);
            borderedPanel1.Controls.Add(label1);
            borderedPanel1.Location = new Point(12, 12);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(323, 686);
            borderedPanel1.TabIndex = 0;
            // 
            // PcbLibroPortada
            // 
            PcbLibroPortada.BackColor = Color.White;
            PcbLibroPortada.BackgroundImage = (Image)resources.GetObject("PcbLibroPortada.BackgroundImage");
            PcbLibroPortada.BackgroundImageLayout = ImageLayout.Zoom;
            PcbLibroPortada.ForeColor = SystemColors.ControlText;
            PcbLibroPortada.IconChar = FontAwesome.Sharp.MaterialIcons.None;
            PcbLibroPortada.IconColor = SystemColors.ControlText;
            PcbLibroPortada.IconSize = 207;
            PcbLibroPortada.Location = new Point(61, 25);
            PcbLibroPortada.Name = "PcbLibroPortada";
            PcbLibroPortada.Size = new Size(207, 268);
            PcbLibroPortada.SizeMode = PictureBoxSizeMode.Zoom;
            PcbLibroPortada.TabIndex = 0;
            PcbLibroPortada.TabStop = false;
            PcbLibroPortada.DragDrop += SoltarArchivo;
            PcbLibroPortada.DragEnter += ArrastrarArchivo;
            PcbLibroPortada.DragLeave += pcboUploadCover_DragLeave;
            // 
            // LblStatusArchivo
            // 
            LblStatusArchivo.AutoSize = true;
            LblStatusArchivo.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStatusArchivo.ForeColor = Color.Gray;
            LblStatusArchivo.Location = new Point(29, 486);
            LblStatusArchivo.Name = "LblStatusArchivo";
            LblStatusArchivo.Size = new Size(238, 13);
            LblStatusArchivo.TabIndex = 6;
            LblStatusArchivo.Text = "Supported formats: PDF, Max file size: 100MB";
            LblStatusArchivo.Visible = false;
            // 
            // btnAddFile
            // 
            btnAddFile.BackColor = Color.FromArgb(58, 177, 155);
            btnAddFile.BackgroundColor = Color.FromArgb(58, 177, 155);
            btnAddFile.BorderColor = Color.Fuchsia;
            btnAddFile.BorderRadius = 5;
            btnAddFile.BorderSize = 0;
            btnAddFile.FlatAppearance.BorderSize = 0;
            btnAddFile.FlatStyle = FlatStyle.Flat;
            btnAddFile.ForeColor = Color.White;
            btnAddFile.Location = new Point(29, 439);
            btnAddFile.Name = "btnAddFile";
            btnAddFile.Size = new Size(259, 31);
            btnAddFile.TabIndex = 5;
            btnAddFile.Tag = "NoCambiarTema";
            btnAddFile.Text = "Elegir Archivo";
            btnAddFile.TextColor = Color.White;
            btnAddFile.UseVisualStyleBackColor = false;
            btnAddFile.Click += CargarLibro_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 412);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "Archivo PDF";
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblStatus.ForeColor = Color.Gray;
            LblStatus.Location = new Point(29, 378);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(283, 13);
            LblStatus.TabIndex = 3;
            LblStatus.Text = "Recommended size: 600x900 pixels. Max file size: 2MB.";
            LblStatus.Visible = false;
            // 
            // btnAddCover
            // 
            btnAddCover.BackColor = Color.FromArgb(58, 177, 155);
            btnAddCover.BackgroundColor = Color.FromArgb(58, 177, 155);
            btnAddCover.BorderColor = Color.Fuchsia;
            btnAddCover.BorderRadius = 5;
            btnAddCover.BorderSize = 0;
            btnAddCover.FlatAppearance.BorderSize = 0;
            btnAddCover.FlatStyle = FlatStyle.Flat;
            btnAddCover.ForeColor = Color.White;
            btnAddCover.Location = new Point(29, 333);
            btnAddCover.Name = "btnAddCover";
            btnAddCover.Size = new Size(259, 31);
            btnAddCover.TabIndex = 2;
            btnAddCover.Tag = "NoCambiarTema";
            btnAddCover.Text = "Elegir Archivo";
            btnAddCover.TextColor = Color.White;
            btnAddCover.UseVisualStyleBackColor = false;
            btnAddCover.Click += CargarPortadaLibro;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 305);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Portada";
            // 
            // CmbAutor
            // 
            CmbAutor.BackColor = Color.White;
            CmbAutor.FlatStyle = FlatStyle.Flat;
            CmbAutor.ForeColor = Color.FromArgb(64, 64, 64);
            CmbAutor.FormattingEnabled = true;
            CmbAutor.Location = new Point(7, 5);
            CmbAutor.Name = "CmbAutor";
            CmbAutor.Size = new Size(211, 23);
            CmbAutor.TabIndex = 5;
            // 
            // UploadBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 710);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UploadBookForm";
            Text = "UploadBookForm";
            panel1.ResumeLayout(false);
            BtnAñadirAutor.ResumeLayout(false);
            BtnAñadirAutor.PerformLayout();
            borderedPanel13.ResumeLayout(false);
            borderedPanel11.ResumeLayout(false);
            borderedPanel10.ResumeLayout(false);
            borderedPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TxtNumeroPaginas).EndInit();
            borderedPanel7.ResumeLayout(false);
            borderedPanel6.ResumeLayout(false);
            borderedPanel6.PerformLayout();
            borderedPanel3.ResumeLayout(false);
            borderedPanel3.PerformLayout();
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcbLibroPortada).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Controls.BorderedPanel borderedPanel1;
        private Label LblStatus;
        private Controls.RJButton btnAddCover;
        private Label label1;
        private FontAwesome.Sharp.Material.MaterialPictureBox PcbLibroPortada;
        private Controls.RJButton btnAddFile;
        private Label label3;
        private Controls.BorderedPanel BtnAñadirAutor;
        private Label label4;
        private Controls.BorderedPanel borderedPanel3;
        private TextBox TxtTitulo;
        private ComboBox CmbIdioma;
        private Label label7;
        private Label label6;
        private ComboBox CmbCategoria;
        private TextBox TxtDescripcion;
        private Controls.BorderedPanel borderedPanel6;
        private Controls.BorderedPanel borderedPanel9;
        private Label label13;
        private Label label12;
        private Controls.BorderedPanel borderedPanel7;
        private Label label10;
        private Label label14;
        private Controls.BorderedPanel borderedPanel10;
        private Controls.RJButton btnCancel;
        private Controls.RJButton BtnAgregarLibro;
        private Controls.BorderedPanel borderedPanel11;
        private Controls.BorderedPanel borderedPanel13;
        private Label LblStatusArchivo;
        private NumericUpDown TxtNumeroPaginas;
        private Controls.RJButton BtnAgregarAutor;
        private ListBox LstAutores;
        private ComboBox CmbFormato;
        private ComboBox CmbAutor;
    }
}