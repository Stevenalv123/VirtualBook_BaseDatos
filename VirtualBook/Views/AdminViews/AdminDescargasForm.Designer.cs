namespace VirtualBook.Views.AdminViews
{
    partial class AdminDescargasForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            borderedPanel1 = new Controls.BorderedPanel();
            borderedPanel5 = new Controls.BorderedPanel();
            pictureBox1 = new PictureBox();
            lblTotalDescargas = new Label();
            label9 = new Label();
            borderedPanel2 = new Controls.BorderedPanel();
            btnBuscarLibros = new FontAwesome.Sharp.IconPictureBox();
            txtBuscar = new TextBox();
            label2 = new Label();
            dgvDescargas = new DataGridView();
            borderedPanel1.SuspendLayout();
            borderedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            borderedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescargas).BeginInit();
            SuspendLayout();
            // 
            // borderedPanel1
            // 
            borderedPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.Lavender;
            borderedPanel1.BorderRadius = 20;
            borderedPanel1.BorderSize = 2;
            borderedPanel1.Controls.Add(dgvDescargas);
            borderedPanel1.Controls.Add(borderedPanel5);
            borderedPanel1.Controls.Add(borderedPanel2);
            borderedPanel1.Controls.Add(label2);
            borderedPanel1.Location = new Point(12, 12);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(930, 543);
            borderedPanel1.TabIndex = 0;
            // 
            // borderedPanel5
            // 
            borderedPanel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderedPanel5.BackColor = Color.White;
            borderedPanel5.BorderColor = Color.Black;
            borderedPanel5.BorderRadius = 10;
            borderedPanel5.BorderSize = 1;
            borderedPanel5.Controls.Add(pictureBox1);
            borderedPanel5.Controls.Add(lblTotalDescargas);
            borderedPanel5.Controls.Add(label9);
            borderedPanel5.Location = new Point(616, 32);
            borderedPanel5.Name = "borderedPanel5";
            borderedPanel5.Size = new Size(276, 100);
            borderedPanel5.TabIndex = 49;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_descargas_48;
            pictureBox1.Location = new Point(140, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // lblTotalDescargas
            // 
            lblTotalDescargas.AutoSize = true;
            lblTotalDescargas.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDescargas.Location = new Point(22, 41);
            lblTotalDescargas.Name = "lblTotalDescargas";
            lblTotalDescargas.Size = new Size(65, 30);
            lblTotalDescargas.TabIndex = 36;
            lblTotalDescargas.Text = "4000";
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
            // borderedPanel2
            // 
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.Black;
            borderedPanel2.BorderRadius = 10;
            borderedPanel2.BorderSize = 1;
            borderedPanel2.Controls.Add(btnBuscarLibros);
            borderedPanel2.Controls.Add(txtBuscar);
            borderedPanel2.Location = new Point(36, 83);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Size = new Size(472, 34);
            borderedPanel2.TabIndex = 47;
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
            // txtBuscar
            // 
            txtBuscar.BorderStyle = BorderStyle.None;
            txtBuscar.Font = new Font("Segoe UI", 12F);
            txtBuscar.Location = new Point(45, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar libros, autores, o generos";
            txtBuscar.Size = new Size(402, 22);
            txtBuscar.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 32);
            label2.Name = "label2";
            label2.Size = new Size(289, 30);
            label2.TabIndex = 44;
            label2.Text = "Visualización de descargas";
            // 
            // dgvDescargas
            // 
            dgvDescargas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDescargas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDescargas.BackgroundColor = Color.White;
            dgvDescargas.BorderStyle = BorderStyle.None;
            dgvDescargas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 177, 155);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDescargas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDescargas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDescargas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDescargas.EnableHeadersVisualStyles = false;
            dgvDescargas.GridColor = Color.White;
            dgvDescargas.Location = new Point(36, 194);
            dgvDescargas.Name = "dgvDescargas";
            dgvDescargas.ReadOnly = true;
            dgvDescargas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDescargas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDescargas.RowHeadersVisible = false;
            dgvDescargas.ScrollBars = ScrollBars.None;
            dgvDescargas.Size = new Size(856, 290);
            dgvDescargas.TabIndex = 38;
            // 
            // AdminDescargasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 567);
            Controls.Add(borderedPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDescargasForm";
            Text = "AdminDescargasForm";
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            borderedPanel5.ResumeLayout(false);
            borderedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            borderedPanel2.ResumeLayout(false);
            borderedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDescargas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.BorderedPanel borderedPanel1;
        private Label label2;
        private Controls.BorderedPanel borderedPanel2;
        private FontAwesome.Sharp.IconPictureBox btnBuscarLibros;
        private TextBox txtBuscar;
        private Controls.BorderedPanel borderedPanel5;
        private PictureBox pictureBox1;
        private Label lblTotalDescargas;
        private Label label9;
        private DataGridView dgvDescargas;
    }
}