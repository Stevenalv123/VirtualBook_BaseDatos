namespace VirtualBook
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            BtnIrRegistrarmeForm = new VirtualBook.Controls.RJButton();
            label2 = new Label();
            label1 = new Label();
            panelIniciarSesion = new Panel();
            LblRestablecerContraseña = new Label();
            label5 = new Label();
            borderedPanel2 = new VirtualBook.Controls.BorderedPanel();
            TxtContraseña = new VirtualBook.Controls.RoundedTextBox();
            BtnVerContraseña = new FontAwesome.Sharp.IconButton();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            TxtCorreo = new VirtualBook.Controls.RoundedTextBox();
            BtnCerrar = new FontAwesome.Sharp.IconButton();
            circularButton3 = new VirtualBook.Controls.CircularButton();
            circularButton2 = new VirtualBook.Controls.CircularButton();
            circularButton1 = new VirtualBook.Controls.CircularButton();
            BtnContinuar = new VirtualBook.Controls.RJButton();
            label4 = new Label();
            label3 = new Label();
            ErrorValidaciones = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            panel1.SuspendLayout();
            panelIniciarSesion.SuspendLayout();
            borderedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorValidaciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.MujerLeyendo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(BtnIrRegistrarmeForm);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 450);
            panel1.TabIndex = 0;
            // 
            // BtnIrRegistrarmeForm
            // 
            BtnIrRegistrarmeForm.BackColor = Color.Transparent;
            BtnIrRegistrarmeForm.BackgroundColor = Color.Transparent;
            BtnIrRegistrarmeForm.BorderColor = Color.White;
            BtnIrRegistrarmeForm.BorderRadius = 20;
            BtnIrRegistrarmeForm.BorderSize = 0;
            BtnIrRegistrarmeForm.Cursor = Cursors.Hand;
            BtnIrRegistrarmeForm.FlatStyle = FlatStyle.Flat;
            BtnIrRegistrarmeForm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIrRegistrarmeForm.ForeColor = Color.White;
            BtnIrRegistrarmeForm.Location = new Point(55, 281);
            BtnIrRegistrarmeForm.Name = "BtnIrRegistrarmeForm";
            BtnIrRegistrarmeForm.Size = new Size(199, 52);
            BtnIrRegistrarmeForm.TabIndex = 15;
            BtnIrRegistrarmeForm.Text = "Quiero regístrarme";
            BtnIrRegistrarmeForm.TextColor = Color.White;
            toolTip1.SetToolTip(BtnIrRegistrarmeForm, "No tienes una cuenta? registrate ahora");
            BtnIrRegistrarmeForm.UseVisualStyleBackColor = false;
            BtnIrRegistrarmeForm.Click += BtnIrRegistrarmeForm_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 164);
            label2.Name = "label2";
            label2.Size = new Size(224, 65);
            label2.TabIndex = 1;
            label2.Text = "Ingresa tu información y crea una nueva cuenta para disfrutar de la experiencia";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(72, 104);
            label1.Name = "label1";
            label1.Size = new Size(171, 45);
            label1.TabIndex = 0;
            label1.Text = "Regístrate";
            // 
            // panelIniciarSesion
            // 
            panelIniciarSesion.BackColor = SystemColors.Window;
            panelIniciarSesion.Controls.Add(LblRestablecerContraseña);
            panelIniciarSesion.Controls.Add(label5);
            panelIniciarSesion.Controls.Add(borderedPanel2);
            panelIniciarSesion.Controls.Add(borderedPanel1);
            panelIniciarSesion.Controls.Add(BtnCerrar);
            panelIniciarSesion.Controls.Add(circularButton3);
            panelIniciarSesion.Controls.Add(circularButton2);
            panelIniciarSesion.Controls.Add(circularButton1);
            panelIniciarSesion.Controls.Add(BtnContinuar);
            panelIniciarSesion.Controls.Add(label4);
            panelIniciarSesion.Controls.Add(label3);
            panelIniciarSesion.Dock = DockStyle.Fill;
            panelIniciarSesion.Location = new Point(310, 0);
            panelIniciarSesion.Name = "panelIniciarSesion";
            panelIniciarSesion.Size = new Size(490, 450);
            panelIniciarSesion.TabIndex = 1;
            // 
            // LblRestablecerContraseña
            // 
            LblRestablecerContraseña.AutoSize = true;
            LblRestablecerContraseña.Cursor = Cursors.Hand;
            LblRestablecerContraseña.Font = new Font("Segoe UI", 8F, FontStyle.Underline, GraphicsUnit.Point, 0);
            LblRestablecerContraseña.ForeColor = Color.FromArgb(113, 113, 122);
            LblRestablecerContraseña.Location = new Point(270, 301);
            LblRestablecerContraseña.Name = "LblRestablecerContraseña";
            LblRestablecerContraseña.Size = new Size(104, 13);
            LblRestablecerContraseña.TabIndex = 24;
            LblRestablecerContraseña.Text = "Restablecela ahora";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(113, 113, 122);
            label5.Location = new Point(129, 301);
            label5.Name = "label5";
            label5.Size = new Size(147, 13);
            label5.TabIndex = 23;
            label5.Text = "¿Olvidastes tu contraseña? ";
            // 
            // borderedPanel2
            // 
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel2.BorderRadius = 5;
            borderedPanel2.BorderSize = 2;
            borderedPanel2.Controls.Add(TxtContraseña);
            borderedPanel2.Controls.Add(BtnVerContraseña);
            borderedPanel2.Controls.Add(iconPictureBox2);
            borderedPanel2.Location = new Point(112, 266);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Padding = new Padding(3);
            borderedPanel2.Size = new Size(281, 32);
            borderedPanel2.TabIndex = 22;
            // 
            // TxtContraseña
            // 
            TxtContraseña.BorderStyle = BorderStyle.None;
            TxtContraseña.Dock = DockStyle.Left;
            TxtContraseña.Font = new Font("Segoe UI", 12F);
            TxtContraseña.ForeColor = Color.FromArgb(64, 64, 64);
            TxtContraseña.Location = new Point(32, 3);
            TxtContraseña.Multiline = true;
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.PlaceholderText = "Contraseña";
            TxtContraseña.Size = new Size(220, 26);
            TxtContraseña.TabIndex = 12;
            // 
            // BtnVerContraseña
            // 
            BtnVerContraseña.Cursor = Cursors.Hand;
            BtnVerContraseña.FlatAppearance.BorderSize = 0;
            BtnVerContraseña.FlatStyle = FlatStyle.Flat;
            BtnVerContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnVerContraseña.IconColor = Color.FromArgb(113, 113, 122);
            BtnVerContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVerContraseña.IconSize = 20;
            BtnVerContraseña.Location = new Point(261, 3);
            BtnVerContraseña.Name = "BtnVerContraseña";
            BtnVerContraseña.Size = new Size(17, 26);
            BtnVerContraseña.TabIndex = 13;
            BtnVerContraseña.UseVisualStyleBackColor = true;
            BtnVerContraseña.Click += BtnVerContraseña_Click;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.BackColor = Color.White;
            iconPictureBox2.Dock = DockStyle.Left;
            iconPictureBox2.ForeColor = Color.FromArgb(113, 113, 122);
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox2.IconColor = Color.FromArgb(113, 113, 122);
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 26;
            iconPictureBox2.Location = new Point(3, 3);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(29, 26);
            iconPictureBox2.TabIndex = 9;
            iconPictureBox2.TabStop = false;
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel1.BorderRadius = 5;
            borderedPanel1.BorderSize = 2;
            borderedPanel1.Controls.Add(iconPictureBox1);
            borderedPanel1.Controls.Add(TxtCorreo);
            borderedPanel1.Location = new Point(112, 217);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Padding = new Padding(3);
            borderedPanel1.Size = new Size(281, 32);
            borderedPanel1.TabIndex = 21;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.ForeColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconPictureBox1.IconColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 26;
            iconPictureBox1.Location = new Point(3, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(29, 26);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
            // 
            // TxtCorreo
            // 
            TxtCorreo.BorderStyle = BorderStyle.None;
            TxtCorreo.Font = new Font("Segoe UI", 12F);
            TxtCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            TxtCorreo.Location = new Point(32, 3);
            TxtCorreo.Multiline = true;
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.PlaceholderText = "Correo Electronico";
            TxtCorreo.Size = new Size(246, 27);
            TxtCorreo.TabIndex = 8;
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnCerrar.IconColor = Color.FromArgb(113, 113, 122);
            BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCerrar.Location = new Point(448, 12);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(30, 33);
            BtnCerrar.TabIndex = 12;
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // circularButton3
            // 
            circularButton3.BackColor = Color.White;
            circularButton3.Cursor = Cursors.Hand;
            circularButton3.FlatAppearance.BorderColor = Color.White;
            circularButton3.FlatAppearance.BorderSize = 0;
            circularButton3.FlatAppearance.MouseDownBackColor = Color.Silver;
            circularButton3.FlatStyle = FlatStyle.Flat;
            circularButton3.ForeColor = Color.White;
            circularButton3.Image = (Image)resources.GetObject("circularButton3.Image");
            circularButton3.Location = new Point(307, 105);
            circularButton3.Name = "circularButton3";
            circularButton3.Size = new Size(44, 44);
            circularButton3.TabIndex = 7;
            circularButton3.UseVisualStyleBackColor = false;
            // 
            // circularButton2
            // 
            circularButton2.BackColor = Color.White;
            circularButton2.Cursor = Cursors.Hand;
            circularButton2.FlatAppearance.BorderColor = Color.Black;
            circularButton2.FlatAppearance.BorderSize = 0;
            circularButton2.FlatAppearance.MouseDownBackColor = Color.Silver;
            circularButton2.FlatStyle = FlatStyle.Flat;
            circularButton2.ForeColor = Color.White;
            circularButton2.Image = (Image)resources.GetObject("circularButton2.Image");
            circularButton2.Location = new Point(215, 105);
            circularButton2.Name = "circularButton2";
            circularButton2.Size = new Size(44, 44);
            circularButton2.TabIndex = 6;
            circularButton2.UseVisualStyleBackColor = false;
            // 
            // circularButton1
            // 
            circularButton1.BackColor = Color.White;
            circularButton1.Cursor = Cursors.Hand;
            circularButton1.FlatAppearance.BorderColor = Color.White;
            circularButton1.FlatAppearance.MouseDownBackColor = Color.Silver;
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.ForeColor = Color.White;
            circularButton1.Image = (Image)resources.GetObject("circularButton1.Image");
            circularButton1.Location = new Point(123, 105);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(44, 44);
            circularButton1.TabIndex = 5;
            circularButton1.UseVisualStyleBackColor = false;
            // 
            // BtnContinuar
            // 
            BtnContinuar.BackColor = Color.FromArgb(59, 176, 155);
            BtnContinuar.BackgroundColor = Color.FromArgb(59, 176, 155);
            BtnContinuar.BorderColor = Color.PaleVioletRed;
            BtnContinuar.BorderRadius = 20;
            BtnContinuar.BorderSize = 0;
            BtnContinuar.Cursor = Cursors.Hand;
            BtnContinuar.FlatAppearance.BorderSize = 0;
            BtnContinuar.FlatStyle = FlatStyle.Flat;
            BtnContinuar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnContinuar.ForeColor = Color.White;
            BtnContinuar.Location = new Point(157, 355);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(199, 52);
            BtnContinuar.TabIndex = 4;
            BtnContinuar.Text = "Continuar";
            BtnContinuar.TextColor = Color.White;
            BtnContinuar.UseVisualStyleBackColor = false;
            BtnContinuar.Click += BtnContinuar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(123, 177);
            label4.Name = "label4";
            label4.Size = new Size(244, 17);
            label4.TabIndex = 1;
            label4.Text = "o inicia sesión con tú correo electronico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(59, 176, 155);
            label3.Location = new Point(47, 40);
            label3.Name = "label3";
            label3.Size = new Size(398, 40);
            label3.TabIndex = 0;
            label3.Text = "Inicia sesión en VirtualBook";
            // 
            // ErrorValidaciones
            // 
            ErrorValidaciones.ContainerControl = this;
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelIniciarSesion);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelIniciarSesion.ResumeLayout(false);
            panelIniciarSesion.PerformLayout();
            borderedPanel2.ResumeLayout(false);
            borderedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorValidaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelIniciarSesion;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private Button btnContinue;
        private Controls.RJButton BtnContinuar;
        private Controls.CircularButton circularButton1;
        private Controls.CircularButton circularButton2;
        private Controls.CircularButton circularButton3;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private Controls.RJButton BtnIrRegistrarmeForm;
        private ErrorProvider ErrorValidaciones;
        private Controls.BorderedPanel borderedPanel2;
        private Controls.RoundedTextBox TxtContraseña;
        private FontAwesome.Sharp.IconButton BtnVerContraseña;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private Controls.BorderedPanel borderedPanel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Controls.RoundedTextBox TxtCorreo;
        private Label LblRestablecerContraseña;
        private Label label5;
        private ToolTip toolTip1;
    }
}