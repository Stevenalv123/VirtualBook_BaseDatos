namespace VirtualBook.Views
{
    partial class ConfirmacionCorreoForm
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            LblCorreo = new Label();
            TxtN1 = new TextBox();
            TxtN2 = new TextBox();
            TxtN3 = new TextBox();
            TxtN4 = new TextBox();
            TxtN5 = new TextBox();
            TxtN6 = new TextBox();
            label3 = new Label();
            lblReenviarCorreo = new Label();
            BtnRegresarRegistro = new FontAwesome.Sharp.IconButton();
            BtnVerificarCodigo = new VirtualBook.Controls.RJButton();
            panel1 = new Panel();
            LblCodigoEstatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.iconoEmail;
            pictureBox1.Location = new Point(153, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 129);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 1;
            label1.Text = "Revisa tu correro electrónico";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(98, 158);
            label2.Name = "label2";
            label2.Size = new Size(282, 20);
            label2.TabIndex = 2;
            label2.Text = "Hemos enviado un código de 6 dígitos a:";
            // 
            // LblCorreo
            // 
            LblCorreo.AutoSize = true;
            LblCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblCorreo.Location = new Point(149, 189);
            LblCorreo.Name = "LblCorreo";
            LblCorreo.Size = new Size(178, 21);
            LblCorreo.TabIndex = 3;
            LblCorreo.Text = "stevenalv9@gmail.com";
            // 
            // TxtN1
            // 
            TxtN1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TxtN1.Location = new Point(86, 241);
            TxtN1.Margin = new Padding(3, 2, 3, 2);
            TxtN1.MaxLength = 1;
            TxtN1.Name = "TxtN1";
            TxtN1.Size = new Size(38, 43);
            TxtN1.TabIndex = 5;
            TxtN1.KeyUp += textBox6_KeyUp;
            // 
            // TxtN2
            // 
            TxtN2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TxtN2.Location = new Point(142, 241);
            TxtN2.Margin = new Padding(3, 2, 3, 2);
            TxtN2.MaxLength = 1;
            TxtN2.Name = "TxtN2";
            TxtN2.Size = new Size(38, 43);
            TxtN2.TabIndex = 6;
            TxtN2.KeyUp += textBox6_KeyUp;
            // 
            // TxtN3
            // 
            TxtN3.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TxtN3.Location = new Point(198, 241);
            TxtN3.Margin = new Padding(3, 2, 3, 2);
            TxtN3.MaxLength = 1;
            TxtN3.Name = "TxtN3";
            TxtN3.Size = new Size(38, 43);
            TxtN3.TabIndex = 7;
            TxtN3.KeyUp += textBox6_KeyUp;
            // 
            // TxtN4
            // 
            TxtN4.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TxtN4.Location = new Point(254, 241);
            TxtN4.Margin = new Padding(3, 2, 3, 2);
            TxtN4.MaxLength = 1;
            TxtN4.Name = "TxtN4";
            TxtN4.Size = new Size(38, 43);
            TxtN4.TabIndex = 8;
            TxtN4.KeyUp += textBox6_KeyUp;
            // 
            // TxtN5
            // 
            TxtN5.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TxtN5.Location = new Point(310, 241);
            TxtN5.Margin = new Padding(3, 2, 3, 2);
            TxtN5.MaxLength = 1;
            TxtN5.Name = "TxtN5";
            TxtN5.Size = new Size(38, 43);
            TxtN5.TabIndex = 9;
            TxtN5.KeyUp += textBox6_KeyUp;
            // 
            // TxtN6
            // 
            TxtN6.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TxtN6.Location = new Point(366, 241);
            TxtN6.Margin = new Padding(3, 2, 3, 2);
            TxtN6.MaxLength = 1;
            TxtN6.Name = "TxtN6";
            TxtN6.Size = new Size(38, 43);
            TxtN6.TabIndex = 10;
            TxtN6.TextChanged += TxtN6_TextChanged;
            TxtN6.KeyUp += textBox6_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(163, 370);
            label3.Name = "label3";
            label3.Size = new Size(150, 19);
            label3.TabIndex = 11;
            label3.Text = "¿No recibiste el correo?";
            // 
            // lblReenviarCorreo
            // 
            lblReenviarCorreo.AutoSize = true;
            lblReenviarCorreo.Cursor = Cursors.Hand;
            lblReenviarCorreo.Font = new Font("Segoe UI", 10F, FontStyle.Underline, GraphicsUnit.Point, 0);
            lblReenviarCorreo.ForeColor = Color.FromArgb(70, 78, 216);
            lblReenviarCorreo.Location = new Point(178, 404);
            lblReenviarCorreo.Name = "lblReenviarCorreo";
            lblReenviarCorreo.Size = new Size(120, 19);
            lblReenviarCorreo.TabIndex = 12;
            lblReenviarCorreo.Text = "Reenviar el codigo";
            lblReenviarCorreo.Click += lblReenviarCorreo_Click;
            // 
            // BtnRegresarRegistro
            // 
            BtnRegresarRegistro.Cursor = Cursors.Hand;
            BtnRegresarRegistro.FlatAppearance.BorderSize = 0;
            BtnRegresarRegistro.FlatStyle = FlatStyle.Flat;
            BtnRegresarRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnRegresarRegistro.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            BtnRegresarRegistro.IconColor = Color.Black;
            BtnRegresarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRegresarRegistro.IconSize = 32;
            BtnRegresarRegistro.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRegresarRegistro.Location = new Point(132, 499);
            BtnRegresarRegistro.Name = "BtnRegresarRegistro";
            BtnRegresarRegistro.Padding = new Padding(0, 0, 10, 0);
            BtnRegresarRegistro.Size = new Size(212, 47);
            BtnRegresarRegistro.TabIndex = 14;
            BtnRegresarRegistro.Text = "Regresar a Registro";
            BtnRegresarRegistro.TextAlign = ContentAlignment.MiddleRight;
            BtnRegresarRegistro.UseVisualStyleBackColor = true;
            BtnRegresarRegistro.Click += BtnRegresarRegistro_Click;
            // 
            // BtnVerificarCodigo
            // 
            BtnVerificarCodigo.BackColor = Color.FromArgb(139, 139, 141);
            BtnVerificarCodigo.BackgroundColor = Color.FromArgb(139, 139, 141);
            BtnVerificarCodigo.BorderColor = Color.PaleVioletRed;
            BtnVerificarCodigo.BorderRadius = 8;
            BtnVerificarCodigo.BorderSize = 0;
            BtnVerificarCodigo.Cursor = Cursors.Hand;
            BtnVerificarCodigo.Enabled = false;
            BtnVerificarCodigo.FlatAppearance.BorderSize = 0;
            BtnVerificarCodigo.FlatStyle = FlatStyle.Flat;
            BtnVerificarCodigo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            BtnVerificarCodigo.ForeColor = Color.White;
            BtnVerificarCodigo.Location = new Point(33, 311);
            BtnVerificarCodigo.Name = "BtnVerificarCodigo";
            BtnVerificarCodigo.Size = new Size(409, 47);
            BtnVerificarCodigo.TabIndex = 15;
            BtnVerificarCodigo.Text = "Verificar código";
            BtnVerificarCodigo.TextColor = Color.White;
            BtnVerificarCodigo.UseVisualStyleBackColor = false;
            BtnVerificarCodigo.Click += BtnVerificarCodigo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGray;
            panel1.Location = new Point(37, 479);
            panel1.Name = "panel1";
            panel1.Size = new Size(403, 1);
            panel1.TabIndex = 16;
            // 
            // LblCodigoEstatus
            // 
            LblCodigoEstatus.AutoSize = true;
            LblCodigoEstatus.Cursor = Cursors.Hand;
            LblCodigoEstatus.Font = new Font("Segoe UI", 10F);
            LblCodigoEstatus.ForeColor = Color.Red;
            LblCodigoEstatus.Location = new Point(163, 436);
            LblCodigoEstatus.Name = "LblCodigoEstatus";
            LblCodigoEstatus.Size = new Size(146, 19);
            LblCodigoEstatus.TabIndex = 17;
            LblCodigoEstatus.Text = "El codigo es incorrecto";
            LblCodigoEstatus.Visible = false;
            // 
            // ConfirmacionCorreoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(476, 570);
            Controls.Add(LblCodigoEstatus);
            Controls.Add(panel1);
            Controls.Add(BtnVerificarCodigo);
            Controls.Add(BtnRegresarRegistro);
            Controls.Add(lblReenviarCorreo);
            Controls.Add(label3);
            Controls.Add(TxtN6);
            Controls.Add(TxtN5);
            Controls.Add(TxtN4);
            Controls.Add(TxtN3);
            Controls.Add(TxtN2);
            Controls.Add(TxtN1);
            Controls.Add(LblCorreo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(476, 570);
            MinimumSize = new Size(476, 570);
            Name = "ConfirmacionCorreoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ConfirmacionCorreoForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label LblCorreo;
        private Button BtnVerificarCorreo;
        private TextBox TxtN1;
        private TextBox TxtN2;
        private TextBox TxtN3;
        private TextBox TxtN4;
        private TextBox TxtN5;
        private TextBox TxtN6;
        private Label label3;
        private Label lblReenviarCorreo;
        private FontAwesome.Sharp.IconButton BtnRegresarRegistro;
        private Controls.RJButton BtnVerificarCodigo;
        private Panel panel1;
        private Label LblCodigoEstatus;
    }
}