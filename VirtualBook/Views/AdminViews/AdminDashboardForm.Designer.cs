namespace VirtualBook.Views
{
    partial class AdminDashboardForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            lblTotalLibros = new Label();
            label4 = new Label();
            lblTotalUsuarios = new Label();
            label7 = new Label();
            lblDescargas = new Label();
            label9 = new Label();
            toolTip1 = new ToolTip(components);
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            BtnEliminar = new VirtualBook.Controls.RJButton();
            dgvShowBooks = new DataGridView();
            borderedPanel2 = new VirtualBook.Controls.BorderedPanel();
            btnBuscarLibros = new FontAwesome.Sharp.IconPictureBox();
            TxtBucarLibros = new TextBox();
            btnNuevoLibro = new VirtualBook.Controls.RJButton();
            label2 = new Label();
            borderedPanel3 = new VirtualBook.Controls.BorderedPanel();
            roundedPictureBox4 = new VirtualBook.Controls.RoundedPictureBox();
            borderedPanel4 = new VirtualBook.Controls.BorderedPanel();
            roundedPictureBox5 = new VirtualBook.Controls.RoundedPictureBox();
            borderedPanel5 = new VirtualBook.Controls.BorderedPanel();
            roundedPictureBox6 = new VirtualBook.Controls.RoundedPictureBox();
            borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowBooks).BeginInit();
            borderedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarLibros).BeginInit();
            borderedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox4).BeginInit();
            borderedPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).BeginInit();
            borderedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lblTotalLibros
            // 
            lblTotalLibros.AutoSize = true;
            lblTotalLibros.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLibros.Location = new Point(23, 40);
            lblTotalLibros.Name = "lblTotalLibros";
            lblTotalLibros.Size = new Size(40, 30);
            lblTotalLibros.TabIndex = 32;
            lblTotalLibros.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(23, 19);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 31;
            label4.Text = "Total de Libros";
            // 
            // lblTotalUsuarios
            // 
            lblTotalUsuarios.AutoSize = true;
            lblTotalUsuarios.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalUsuarios.Location = new Point(16, 42);
            lblTotalUsuarios.Name = "lblTotalUsuarios";
            lblTotalUsuarios.Size = new Size(40, 30);
            lblTotalUsuarios.TabIndex = 34;
            lblTotalUsuarios.Text = "---";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(16, 21);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 33;
            label7.Text = "Usuarios registrados";
            // 
            // lblDescargas
            // 
            lblDescargas.AutoSize = true;
            lblDescargas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescargas.Location = new Point(22, 41);
            lblDescargas.Name = "lblDescargas";
            lblDescargas.Size = new Size(40, 30);
            lblDescargas.TabIndex = 36;
            lblDescargas.Text = "---";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(22, 20);
            label9.Name = "label9";
            label9.Size = new Size(81, 21);
            label9.TabIndex = 35;
            label9.Text = "Descargas";
            // 
            // borderedPanel1
            // 
            borderedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.Black;
            borderedPanel1.BorderRadius = 20;
            borderedPanel1.BorderSize = 1;
            borderedPanel1.Controls.Add(BtnEliminar);
            borderedPanel1.Controls.Add(dgvShowBooks);
            borderedPanel1.Controls.Add(borderedPanel2);
            borderedPanel1.Controls.Add(btnNuevoLibro);
            borderedPanel1.Controls.Add(label2);
            borderedPanel1.Location = new Point(17, 190);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(930, 497);
            borderedPanel1.TabIndex = 37;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.BackColor = Color.FromArgb(58, 177, 155);
            BtnEliminar.BackgroundColor = Color.FromArgb(58, 177, 155);
            BtnEliminar.BorderColor = Color.PaleVioletRed;
            BtnEliminar.BorderRadius = 5;
            BtnEliminar.BorderSize = 0;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.Location = new Point(617, 22);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(140, 30);
            BtnEliminar.TabIndex = 48;
            BtnEliminar.Tag = "NoCambiarTema";
            BtnEliminar.Text = "Eliminar Libro";
            BtnEliminar.TextColor = Color.White;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // dgvShowBooks
            // 
            dgvShowBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvShowBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShowBooks.BackgroundColor = Color.White;
            dgvShowBooks.BorderStyle = BorderStyle.None;
            dgvShowBooks.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(58, 177, 155);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvShowBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvShowBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvShowBooks.DefaultCellStyle = dataGridViewCellStyle5;
            dgvShowBooks.EnableHeadersVisualStyles = false;
            dgvShowBooks.GridColor = Color.White;
            dgvShowBooks.Location = new Point(23, 127);
            dgvShowBooks.Name = "dgvShowBooks";
            dgvShowBooks.ReadOnly = true;
            dgvShowBooks.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvShowBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvShowBooks.RowHeadersVisible = false;
            dgvShowBooks.ScrollBars = ScrollBars.None;
            dgvShowBooks.Size = new Size(885, 337);
            dgvShowBooks.TabIndex = 47;
            dgvShowBooks.SelectionChanged += dgvShowBooks_SelectionChanged;
            // 
            // borderedPanel2
            // 
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.Black;
            borderedPanel2.BorderRadius = 10;
            borderedPanel2.BorderSize = 1;
            borderedPanel2.Controls.Add(btnBuscarLibros);
            borderedPanel2.Controls.Add(TxtBucarLibros);
            borderedPanel2.Location = new Point(26, 68);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Size = new Size(472, 34);
            borderedPanel2.TabIndex = 46;
            // 
            // btnBuscarLibros
            // 
            btnBuscarLibros.BackColor = Color.White;
            btnBuscarLibros.ForeColor = Color.FromArgb(113, 113, 122);
            btnBuscarLibros.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarLibros.IconColor = Color.FromArgb(113, 113, 122);
            btnBuscarLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarLibros.IconSize = 28;
            btnBuscarLibros.Location = new Point(7, 3);
            btnBuscarLibros.Name = "btnBuscarLibros";
            btnBuscarLibros.Size = new Size(32, 28);
            btnBuscarLibros.TabIndex = 41;
            btnBuscarLibros.TabStop = false;
            // 
            // TxtBucarLibros
            // 
            TxtBucarLibros.BorderStyle = BorderStyle.None;
            TxtBucarLibros.Font = new Font("Segoe UI", 12F);
            TxtBucarLibros.Location = new Point(44, 6);
            TxtBucarLibros.Name = "TxtBucarLibros";
            TxtBucarLibros.PlaceholderText = "Buscar libros, autores, o generos";
            TxtBucarLibros.Size = new Size(402, 22);
            TxtBucarLibros.TabIndex = 42;
            TxtBucarLibros.TextChanged += BucarLibros_Click;
            // 
            // btnNuevoLibro
            // 
            btnNuevoLibro.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNuevoLibro.BackColor = Color.FromArgb(58, 177, 155);
            btnNuevoLibro.BackgroundColor = Color.FromArgb(58, 177, 155);
            btnNuevoLibro.BorderColor = Color.PaleVioletRed;
            btnNuevoLibro.BorderRadius = 5;
            btnNuevoLibro.BorderSize = 0;
            btnNuevoLibro.Cursor = Cursors.Hand;
            btnNuevoLibro.FlatAppearance.BorderSize = 0;
            btnNuevoLibro.FlatStyle = FlatStyle.Flat;
            btnNuevoLibro.ForeColor = Color.White;
            btnNuevoLibro.Location = new Point(768, 22);
            btnNuevoLibro.Name = "btnNuevoLibro";
            btnNuevoLibro.Size = new Size(140, 30);
            btnNuevoLibro.TabIndex = 45;
            btnNuevoLibro.Tag = "NoCambiarTema";
            btnNuevoLibro.Text = "Nuevo Libro";
            btnNuevoLibro.TextColor = Color.White;
            btnNuevoLibro.UseVisualStyleBackColor = false;
            btnNuevoLibro.Click += BtnAgregarNuevoLibro_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 22);
            label2.Name = "label2";
            label2.Size = new Size(193, 30);
            label2.TabIndex = 43;
            label2.Text = "Gestion de Libros";
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = Color.White;
            borderedPanel3.BorderColor = Color.Black;
            borderedPanel3.BorderRadius = 10;
            borderedPanel3.BorderSize = 1;
            borderedPanel3.Controls.Add(roundedPictureBox4);
            borderedPanel3.Controls.Add(label4);
            borderedPanel3.Controls.Add(lblTotalLibros);
            borderedPanel3.Location = new Point(17, 46);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Size = new Size(276, 100);
            borderedPanel3.TabIndex = 38;
            // 
            // roundedPictureBox4
            // 
            roundedPictureBox4.BackColor = Color.Transparent;
            roundedPictureBox4.BorderColor = Color.Gray;
            roundedPictureBox4.BorderSize = 0;
            roundedPictureBox4.Image = Properties.Resources.Imagen_de_WhatsApp_2025_06_05_a_las_20_00_25_fdf2ca21;
            roundedPictureBox4.Location = new Point(189, 19);
            roundedPictureBox4.Name = "roundedPictureBox4";
            roundedPictureBox4.Size = new Size(53, 49);
            roundedPictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox4.TabIndex = 33;
            roundedPictureBox4.TabStop = false;
            // 
            // borderedPanel4
            // 
            borderedPanel4.Anchor = AnchorStyles.Top;
            borderedPanel4.BackColor = Color.White;
            borderedPanel4.BorderColor = Color.Black;
            borderedPanel4.BorderRadius = 10;
            borderedPanel4.BorderSize = 1;
            borderedPanel4.Controls.Add(roundedPictureBox5);
            borderedPanel4.Controls.Add(label7);
            borderedPanel4.Controls.Add(lblTotalUsuarios);
            borderedPanel4.Location = new Point(344, 46);
            borderedPanel4.Name = "borderedPanel4";
            borderedPanel4.Size = new Size(276, 100);
            borderedPanel4.TabIndex = 39;
            // 
            // roundedPictureBox5
            // 
            roundedPictureBox5.BackColor = Color.Transparent;
            roundedPictureBox5.BorderColor = Color.Gray;
            roundedPictureBox5.BorderSize = 0;
            roundedPictureBox5.Image = Properties.Resources.Imagen_de_WhatsApp_2025_06_05_a_las_20_01_46_ce0776e2;
            roundedPictureBox5.Location = new Point(191, 19);
            roundedPictureBox5.Name = "roundedPictureBox5";
            roundedPictureBox5.Size = new Size(53, 49);
            roundedPictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox5.TabIndex = 35;
            roundedPictureBox5.TabStop = false;
            // 
            // borderedPanel5
            // 
            borderedPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderedPanel5.BackColor = Color.White;
            borderedPanel5.BorderColor = Color.Black;
            borderedPanel5.BorderRadius = 10;
            borderedPanel5.BorderSize = 1;
            borderedPanel5.Controls.Add(roundedPictureBox6);
            borderedPanel5.Controls.Add(lblDescargas);
            borderedPanel5.Controls.Add(label9);
            borderedPanel5.Location = new Point(671, 46);
            borderedPanel5.Name = "borderedPanel5";
            borderedPanel5.Size = new Size(276, 100);
            borderedPanel5.TabIndex = 40;
            // 
            // roundedPictureBox6
            // 
            roundedPictureBox6.BackColor = Color.Transparent;
            roundedPictureBox6.BorderColor = Color.Gray;
            roundedPictureBox6.BorderSize = 0;
            roundedPictureBox6.Image = Properties.Resources.Imagen_de_WhatsApp_2025_06_05_a_las_20_03_09_01681dc1;
            roundedPictureBox6.Location = new Point(191, 19);
            roundedPictureBox6.Name = "roundedPictureBox6";
            roundedPictureBox6.Size = new Size(53, 49);
            roundedPictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            roundedPictureBox6.TabIndex = 37;
            roundedPictureBox6.TabStop = false;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(970, 710);
            Controls.Add(borderedPanel5);
            Controls.Add(borderedPanel4);
            Controls.Add(borderedPanel3);
            Controls.Add(borderedPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminDashboardForm";
            Padding = new Padding(20);
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShowBooks).EndInit();
            borderedPanel2.ResumeLayout(false);
            borderedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarLibros).EndInit();
            borderedPanel3.ResumeLayout(false);
            borderedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox4).EndInit();
            borderedPanel4.ResumeLayout(false);
            borderedPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox5).EndInit();
            borderedPanel5.ResumeLayout(false);
            borderedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.BorderedPanel borderedPanel1;
        private Controls.BorderedPanel borderedPanel2;
        private Controls.BorderedPanel borderedPanel3;
        private Controls.BorderedPanel borderedPanel4;
        private Controls.BorderedPanel borderedPanel5;
        private Label label4;
        private Controls.RoundedPictureBox roundedPictureBox1;
        private Label lblTotalLibros;
        private Controls.RoundedPictureBox roundedPictureBox2;
        private Label lblTotalUsuarios;
        private Label label7;
        private Label lblDescargas;
        private Label label9;
        private Controls.RoundedPictureBox roundedPictureBox3;
        private ToolTip toolTip1;
        private Controls.RJButton BtnNuevoLibro;
        private Controls.RJButton btnNuevoLibro;
        private DataGridView dgvShowBooks;
        private TextBox TxtBucarLibros;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox btnBuscarLibros;
        private Controls.RoundedPictureBox roundedPictureBox4;
        private Controls.RoundedPictureBox roundedPictureBox5;
        private Controls.RoundedPictureBox roundedPictureBox6;
        private Controls.RJButton BtnEliminar;
    }
}