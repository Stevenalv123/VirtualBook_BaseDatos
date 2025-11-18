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
            BtnCancelar = new Button();
            panel2 = new Panel();
            BtnGuardar = new VirtualBook.Controls.RJButton();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            TxtNombre = new TextBox();
            label2 = new Label();
            borderedPanel2 = new VirtualBook.Controls.BorderedPanel();
            TxtNacionalidad = new TextBox();
            borderedPanel3 = new VirtualBook.Controls.BorderedPanel();
            pictureBox5 = new PictureBox();
            DtpFecha = new DateTimePicker();
            label3 = new Label();
            borderedPanel6 = new VirtualBook.Controls.BorderedPanel();
            TxtBio = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            borderedPanel1.SuspendLayout();
            borderedPanel2.SuspendLayout();
            borderedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            borderedPanel6.SuspendLayout();
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
            panel1.Controls.Add(BtnCancelar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 33);
            panel1.TabIndex = 1;
            // 
            // BtnCancelar
            // 
            BtnCancelar.FlatAppearance.BorderSize = 0;
            BtnCancelar.FlatStyle = FlatStyle.Flat;
            BtnCancelar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCancelar.ForeColor = Color.White;
            BtnCancelar.Location = new Point(395, 3);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(36, 24);
            BtnCancelar.TabIndex = 0;
            BtnCancelar.Text = "X";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(borderedPanel6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(borderedPanel3);
            panel2.Controls.Add(borderedPanel2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(BtnGuardar);
            panel2.Controls.Add(borderedPanel1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 378);
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
            BtnGuardar.Location = new Point(306, 329);
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
            borderedPanel1.Controls.Add(TxtNombre);
            borderedPanel1.Location = new Point(171, 17);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(260, 30);
            borderedPanel1.TabIndex = 2;
            // 
            // TxtNombre
            // 
            TxtNombre.BorderStyle = BorderStyle.None;
            TxtNombre.Font = new Font("Segoe UI", 12F);
            TxtNombre.Location = new Point(12, 5);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.PlaceholderText = "Ingrese el nombre del autor";
            TxtNombre.Size = new Size(245, 22);
            TxtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 4;
            label2.Text = "Nacionalidad";
            // 
            // borderedPanel2
            // 
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.DarkGray;
            borderedPanel2.BorderRadius = 10;
            borderedPanel2.BorderSize = 1;
            borderedPanel2.Controls.Add(TxtNacionalidad);
            borderedPanel2.Location = new Point(171, 55);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Size = new Size(260, 30);
            borderedPanel2.TabIndex = 3;
            // 
            // TxtNacionalidad
            // 
            TxtNacionalidad.BorderStyle = BorderStyle.None;
            TxtNacionalidad.Font = new Font("Segoe UI", 12F);
            TxtNacionalidad.Location = new Point(12, 5);
            TxtNacionalidad.Name = "TxtNacionalidad";
            TxtNacionalidad.PlaceholderText = "Nicaraguense";
            TxtNacionalidad.Size = new Size(245, 22);
            TxtNacionalidad.TabIndex = 1;
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = Color.White;
            borderedPanel3.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel3.BorderRadius = 10;
            borderedPanel3.BorderSize = 1;
            borderedPanel3.Controls.Add(pictureBox5);
            borderedPanel3.Controls.Add(DtpFecha);
            borderedPanel3.Location = new Point(171, 91);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Padding = new Padding(3);
            borderedPanel3.Size = new Size(260, 36);
            borderedPanel3.TabIndex = 22;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_calendario1;
            pictureBox5.Location = new Point(6, 5);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // DtpFecha
            // 
            DtpFecha.CalendarForeColor = Color.FromArgb(64, 64, 64);
            DtpFecha.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            DtpFecha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DtpFecha.Format = DateTimePickerFormat.Short;
            DtpFecha.Location = new Point(34, 5);
            DtpFecha.Margin = new Padding(3, 2, 3, 2);
            DtpFecha.Name = "DtpFecha";
            DtpFecha.Size = new Size(209, 25);
            DtpFecha.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 23;
            label3.Text = "Fecha nacimiento";
            // 
            // borderedPanel6
            // 
            borderedPanel6.BackColor = Color.White;
            borderedPanel6.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel6.BorderRadius = 10;
            borderedPanel6.BorderSize = 2;
            borderedPanel6.Controls.Add(TxtBio);
            borderedPanel6.Location = new Point(12, 178);
            borderedPanel6.Name = "borderedPanel6";
            borderedPanel6.Size = new Size(419, 132);
            borderedPanel6.TabIndex = 24;
            // 
            // TxtBio
            // 
            TxtBio.BorderStyle = BorderStyle.None;
            TxtBio.Location = new Point(6, 3);
            TxtBio.Multiline = true;
            TxtBio.Name = "TxtBio";
            TxtBio.Size = new Size(410, 126);
            TxtBio.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 143);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 25;
            label4.Text = "Biografía";
            // 
            // NuevoAutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 411);
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
            borderedPanel6.ResumeLayout(false);
            borderedPanel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Controls.RJButton BtnGuardar;
        private Controls.BorderedPanel borderedPanel1;
        private TextBox TxtNombre;
        private Button BtnCancelar;
        private Controls.BorderedPanel borderedPanel2;
        private TextBox TxtNacionalidad;
        private Label label2;
        private Controls.BorderedPanel borderedPanel3;
        private PictureBox pictureBox5;
        private DateTimePicker DtpFecha;
        private Label label3;
        private Controls.BorderedPanel borderedPanel6;
        private TextBox TxtBio;
        private Label label4;
    }
}