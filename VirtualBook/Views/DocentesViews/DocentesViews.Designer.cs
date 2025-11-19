namespace VirtualBook.Views.DocentesViews
{
    partial class DocentesViews
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
            panel1 = new Panel();
            BtnEliminar = new VirtualBook.Controls.RJButton();
            PanelInfo = new Panel();
            DgvLibros = new DataGridView();
            panel2 = new Panel();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            LblTotalBooks = new Label();
            label2 = new Label();
            borderedPanel2 = new VirtualBook.Controls.BorderedPanel();
            LblFollowers = new Label();
            label6 = new Label();
            BtnUploadNewBook = new VirtualBook.Controls.RJButton();
            label5 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            PanelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvLibros).BeginInit();
            panel2.SuspendLayout();
            borderedPanel1.SuspendLayout();
            borderedPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(BtnEliminar);
            panel1.Controls.Add(PanelInfo);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(BtnUploadNewBook);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 664);
            panel1.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Right;
            BtnEliminar.BackColor = Color.FromArgb(58, 177, 155);
            BtnEliminar.BackgroundColor = Color.FromArgb(58, 177, 155);
            BtnEliminar.BackgroundImageLayout = ImageLayout.Stretch;
            BtnEliminar.BorderColor = Color.PaleVioletRed;
            BtnEliminar.BorderRadius = 5;
            BtnEliminar.BorderSize = 0;
            BtnEliminar.Cursor = Cursors.Hand;
            BtnEliminar.Enabled = false;
            BtnEliminar.FlatAppearance.BorderSize = 0;
            BtnEliminar.FlatStyle = FlatStyle.Flat;
            BtnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnEliminar.ForeColor = Color.White;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(598, 212);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(158, 28);
            BtnEliminar.TabIndex = 11;
            BtnEliminar.Tag = "NoCambiarTema";
            BtnEliminar.Text = "Eliminar Libro";
            BtnEliminar.TextColor = Color.White;
            BtnEliminar.UseVisualStyleBackColor = false;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // PanelInfo
            // 
            PanelInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelInfo.Controls.Add(DgvLibros);
            PanelInfo.Location = new Point(42, 265);
            PanelInfo.Name = "PanelInfo";
            PanelInfo.Size = new Size(871, 366);
            PanelInfo.TabIndex = 10;
            // 
            // DgvLibros
            // 
            DgvLibros.AllowUserToAddRows = false;
            DgvLibros.AllowUserToDeleteRows = false;
            DgvLibros.AllowUserToOrderColumns = true;
            DgvLibros.AllowUserToResizeColumns = false;
            DgvLibros.AllowUserToResizeRows = false;
            DgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgvLibros.BackgroundColor = Color.White;
            DgvLibros.BorderStyle = BorderStyle.None;
            DgvLibros.CellBorderStyle = DataGridViewCellBorderStyle.None;
            DgvLibros.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 177, 155);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(58, 177, 155);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DgvLibros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DgvLibros.DefaultCellStyle = dataGridViewCellStyle2;
            DgvLibros.Dock = DockStyle.Fill;
            DgvLibros.Location = new Point(0, 0);
            DgvLibros.Name = "DgvLibros";
            DgvLibros.Size = new Size(871, 366);
            DgvLibros.TabIndex = 0;
            DgvLibros.SelectionChanged += BtnEliminar_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(borderedPanel1);
            panel2.Controls.Add(borderedPanel2);
            panel2.Location = new Point(21, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(921, 127);
            panel2.TabIndex = 9;
            // 
            // borderedPanel1
            // 
            borderedPanel1.Anchor = AnchorStyles.Left;
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.FromArgb(224, 224, 224);
            borderedPanel1.BorderRadius = 10;
            borderedPanel1.BorderSize = 2;
            borderedPanel1.Controls.Add(LblTotalBooks);
            borderedPanel1.Controls.Add(label2);
            borderedPanel1.Location = new Point(9, 13);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(200, 100);
            borderedPanel1.TabIndex = 1;
            // 
            // LblTotalBooks
            // 
            LblTotalBooks.AutoSize = true;
            LblTotalBooks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTotalBooks.Location = new Point(13, 39);
            LblTotalBooks.Name = "LblTotalBooks";
            LblTotalBooks.Size = new Size(22, 21);
            LblTotalBooks.TabIndex = 1;
            LblTotalBooks.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(13, 11);
            label2.Name = "label2";
            label2.Size = new Size(168, 17);
            label2.TabIndex = 0;
            label2.Text = "Total de libros publicados";
            // 
            // borderedPanel2
            // 
            borderedPanel2.Anchor = AnchorStyles.Top;
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.FromArgb(224, 224, 224);
            borderedPanel2.BorderRadius = 10;
            borderedPanel2.BorderSize = 2;
            borderedPanel2.Controls.Add(LblFollowers);
            borderedPanel2.Controls.Add(label6);
            borderedPanel2.Location = new Point(699, 13);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Size = new Size(200, 100);
            borderedPanel2.TabIndex = 2;
            // 
            // LblFollowers
            // 
            LblFollowers.AutoSize = true;
            LblFollowers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblFollowers.Location = new Point(23, 39);
            LblFollowers.Name = "LblFollowers";
            LblFollowers.Size = new Size(34, 21);
            LblFollowers.TabIndex = 1;
            LblFollowers.Text = "----";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 11);
            label6.Name = "label6";
            label6.Size = new Size(76, 17);
            label6.TabIndex = 0;
            label6.Text = "Seguidores";
            // 
            // BtnUploadNewBook
            // 
            BtnUploadNewBook.Anchor = AnchorStyles.Right;
            BtnUploadNewBook.BackColor = Color.FromArgb(58, 177, 155);
            BtnUploadNewBook.BackgroundColor = Color.FromArgb(58, 177, 155);
            BtnUploadNewBook.BackgroundImageLayout = ImageLayout.Stretch;
            BtnUploadNewBook.BorderColor = Color.PaleVioletRed;
            BtnUploadNewBook.BorderRadius = 5;
            BtnUploadNewBook.BorderSize = 0;
            BtnUploadNewBook.Cursor = Cursors.Hand;
            BtnUploadNewBook.FlatAppearance.BorderSize = 0;
            BtnUploadNewBook.FlatStyle = FlatStyle.Flat;
            BtnUploadNewBook.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnUploadNewBook.ForeColor = Color.White;
            BtnUploadNewBook.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUploadNewBook.Location = new Point(762, 213);
            BtnUploadNewBook.Name = "BtnUploadNewBook";
            BtnUploadNewBook.Size = new Size(158, 28);
            BtnUploadNewBook.TabIndex = 8;
            BtnUploadNewBook.Tag = "NoCambiarTema";
            BtnUploadNewBook.Text = "Subir nuevo libro";
            BtnUploadNewBook.TextColor = Color.White;
            BtnUploadNewBook.UseVisualStyleBackColor = false;
            BtnUploadNewBook.Click += BtnUploadNewBook_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 215);
            label5.Name = "label5";
            label5.Size = new Size(172, 21);
            label5.TabIndex = 7;
            label5.Text = "Mis libros publicados";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 0;
            label1.Text = "Estadisticas";
            // 
            // DocentesViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 665);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DocentesViews";
            Text = "DocentesViews";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            PanelInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvLibros).EndInit();
            panel2.ResumeLayout(false);
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            borderedPanel2.ResumeLayout(false);
            borderedPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Controls.BorderedPanel borderedPanel1;
        private Label LblTotalBooks;
        private Label label2;
        private Controls.BorderedPanel borderedPanel2;
        private Label LblFollowers;
        private Label label6;
        private Controls.RJButton BtnUploadNewBook;
        private Label label5;
        private Panel panel2;
        private Panel PanelInfo;
        private DataGridView DgvLibros;
        private Controls.RJButton BtnEliminar;
    }
}