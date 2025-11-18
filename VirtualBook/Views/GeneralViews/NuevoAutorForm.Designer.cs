namespace VirtualBook.Views.GeneralViews
{
    partial class NuevoAutorForm
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
            label1 = new Label();
            panel1 = new Panel();
            BtnCerrar = new Button();
            panel2 = new Panel();
            BtnGuardar = new VirtualBook.Controls.RJButton();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            TxtNombreAutor = new TextBox();
            borderedPanel2 = new VirtualBook.Controls.BorderedPanel();
            textBox1 = new TextBox();
            label2 = new Label();
            borderedPanel3 = new VirtualBook.Controls.BorderedPanel();
            pictureBox5 = new PictureBox();
            dtmfechanacimiento = new DateTimePicker();
            label3 = new Label();
            borderedPanel7 = new VirtualBook.Controls.BorderedPanel();
            CmbAutor = new ComboBox();
            label4 = new Label();
            borderedPanel6 = new VirtualBook.Controls.BorderedPanel();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            borderedPanel1.SuspendLayout();
            borderedPanel2.SuspendLayout();
            borderedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            borderedPanel7.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Autor:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 177, 155);
            panel1.Controls.Add(BtnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 33);
            panel1.TabIndex = 1;
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCerrar.ForeColor = Color.White;
            BtnCerrar.Location = new Point(405, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(36, 24);
            BtnCerrar.TabIndex = 0;
            BtnCerrar.Text = "X";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(borderedPanel6);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(borderedPanel7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(borderedPanel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(borderedPanel2);
            panel2.Controls.Add(BtnGuardar);
            panel2.Controls.Add(borderedPanel1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(476, 463);
            panel2.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(58, 177, 155);
            BtnGuardar.BackgroundColor = Color.FromArgb(58, 177, 155);
            BtnGuardar.BorderColor = Color.PaleVioletRed;
            BtnGuardar.BorderRadius = 5;
            BtnGuardar.BorderSize = 0;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(339, 420);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(125, 31);
            BtnGuardar.TabIndex = 3;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextColor = Color.White;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.DarkGray;
            borderedPanel1.BorderRadius = 10;
            borderedPanel1.BorderSize = 1;
            borderedPanel1.Controls.Add(TxtNombreAutor);
            borderedPanel1.Location = new Point(196, 13);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(260, 30);
            borderedPanel1.TabIndex = 2;
            // 
            // TxtNombreAutor
            // 
            TxtNombreAutor.BorderStyle = BorderStyle.None;
            TxtNombreAutor.Font = new Font("Segoe UI", 12F);
            TxtNombreAutor.Location = new Point(12, 5);
            TxtNombreAutor.Name = "TxtNombreAutor";
            TxtNombreAutor.PlaceholderText = "Ingrese el nombre del autor";
            TxtNombreAutor.Size = new Size(245, 22);
            TxtNombreAutor.TabIndex = 1;
            // 
            // borderedPanel2
            // 
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.DarkGray;
            borderedPanel2.BorderRadius = 10;
            borderedPanel2.BorderSize = 1;
            borderedPanel2.Controls.Add(textBox1);
            borderedPanel2.Location = new Point(196, 63);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Size = new Size(260, 30);
            borderedPanel2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(12, 5);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Ingrese el nombre del autor";
            textBox1.Size = new Size(245, 22);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 4;
            label2.Text = "Nacionalidad";
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = Color.White;
            borderedPanel3.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel3.BorderRadius = 5;
            borderedPanel3.BorderSize = 1;
            borderedPanel3.Controls.Add(pictureBox5);
            borderedPanel3.Controls.Add(dtmfechanacimiento);
            borderedPanel3.Location = new Point(196, 109);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Padding = new Padding(3);
            borderedPanel3.Size = new Size(260, 42);
            borderedPanel3.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_calendario1;
            pictureBox5.Location = new Point(6, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // dtmfechanacimiento
            // 
            dtmfechanacimiento.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dtmfechanacimiento.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dtmfechanacimiento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtmfechanacimiento.Format = DateTimePickerFormat.Short;
            dtmfechanacimiento.Location = new Point(34, 7);
            dtmfechanacimiento.Margin = new Padding(3, 2, 3, 2);
            dtmfechanacimiento.Name = "dtmfechanacimiento";
            dtmfechanacimiento.Size = new Size(220, 25);
            dtmfechanacimiento.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(168, 21);
            label3.TabIndex = 23;
            label3.Text = "Fecha de nacimiento";
            // 
            // borderedPanel7
            // 
            borderedPanel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderedPanel7.BackColor = Color.White;
            borderedPanel7.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel7.BorderRadius = 10;
            borderedPanel7.BorderSize = 1;
            borderedPanel7.Controls.Add(CmbAutor);
            borderedPanel7.Location = new Point(176, 171);
            borderedPanel7.Name = "borderedPanel7";
            borderedPanel7.Size = new Size(280, 34);
            borderedPanel7.TabIndex = 24;
            // 
            // CmbAutor
            // 
            CmbAutor.BackColor = Color.White;
            CmbAutor.FlatStyle = FlatStyle.Flat;
            CmbAutor.ForeColor = Color.FromArgb(64, 64, 64);
            CmbAutor.FormattingEnabled = true;
            CmbAutor.Location = new Point(7, 5);
            CmbAutor.Name = "CmbAutor";
            CmbAutor.Size = new Size(267, 23);
            CmbAutor.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 184);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 25;
            label4.Text = "Nacionalidad";
            // 
            // borderedPanel6
            // 
            borderedPanel6.BackColor = Color.White;
            borderedPanel6.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel6.BorderRadius = 10;
            borderedPanel6.BorderSize = 1;
            borderedPanel6.Location = new Point(12, 267);
            borderedPanel6.Name = "borderedPanel6";
            borderedPanel6.Size = new Size(444, 132);
            borderedPanel6.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 27;
            label5.Text = "Biografia";
            // 
            // NuevoAutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 496);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoAutorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoAutorForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            borderedPanel2.ResumeLayout(false);
            borderedPanel2.PerformLayout();
            borderedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            borderedPanel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Controls.RJButton BtnGuardar;
        private Controls.BorderedPanel borderedPanel1;
        private Button BtnCerrar;
        private Label label2;
        private Controls.BorderedPanel borderedPanel2;
        private TextBox textBox1;
        private TextBox TxtNombreAutor;
        private Controls.BorderedPanel borderedPanel3;
        private PictureBox pictureBox5;
        private DateTimePicker dtmfechanacimiento;
        private Label label3;
        private Label label4;
        private Controls.BorderedPanel borderedPanel7;
        private ComboBox CmbAutor;
        private Controls.BorderedPanel borderedPanel6;
        private Label label5;
    }
}