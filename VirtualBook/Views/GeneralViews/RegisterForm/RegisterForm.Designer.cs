namespace VirtualBook.Views
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            panelIzquierdo = new Panel();
            BtnIrLoginForm = new Controls.RJButton();
            label2 = new Label();
            label1 = new Label();
            TxtCorreo = new Controls.RoundedTextBox();
            panelDerecho = new Panel();
            PanelConfirmarContraseña = new Controls.BorderedPanel();
            TxtConfirmarContraseña = new Controls.RoundedTextBox();
            iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            BtnVerConfirmarContraseña = new FontAwesome.Sharp.IconButton();
            BtnCerrar = new FontAwesome.Sharp.IconButton();
            PanelContraseña = new Controls.BorderedPanel();
            TxtContraseña = new Controls.RoundedTextBox();
            BtnVerContraseña = new FontAwesome.Sharp.IconButton();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            PanelCorreoElectronico = new Controls.BorderedPanel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            BtnContinuar = new Controls.RJButton();
            label4 = new Label();
            circularButton3 = new Controls.CircularButton();
            circularButton2 = new Controls.CircularButton();
            circularButton1 = new Controls.CircularButton();
            label3 = new Label();
            iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            borderedPanel3 = new Controls.BorderedPanel();
            TxtConfirmarC = new Controls.RoundedTextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ErrorValidaciones = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            panelIzquierdo.SuspendLayout();
            panelDerecho.SuspendLayout();
            PanelConfirmarContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).BeginInit();
            PanelContraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            PanelCorreoElectronico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).BeginInit();
            borderedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorValidaciones).BeginInit();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackgroundImage = Properties.Resources.MujerLeyendo;
            panelIzquierdo.BackgroundImageLayout = ImageLayout.Stretch;
            panelIzquierdo.Controls.Add(BtnIrLoginForm);
            panelIzquierdo.Controls.Add(label2);
            panelIzquierdo.Controls.Add(label1);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Margin = new Padding(3, 2, 3, 2);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(310, 450);
            panelIzquierdo.TabIndex = 0;
            // 
            // BtnIrLoginForm
            // 
            BtnIrLoginForm.BackColor = Color.Transparent;
            BtnIrLoginForm.BackgroundColor = Color.Transparent;
            BtnIrLoginForm.BorderColor = Color.White;
            BtnIrLoginForm.BorderRadius = 20;
            BtnIrLoginForm.BorderSize = 0;
            BtnIrLoginForm.Cursor = Cursors.Hand;
            BtnIrLoginForm.FlatStyle = FlatStyle.Flat;
            BtnIrLoginForm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnIrLoginForm.ForeColor = Color.White;
            BtnIrLoginForm.Location = new Point(55, 264);
            BtnIrLoginForm.Name = "BtnIrLoginForm";
            BtnIrLoginForm.Size = new Size(199, 52);
            BtnIrLoginForm.TabIndex = 16;
            BtnIrLoginForm.Text = "Iniciar sesión";
            BtnIrLoginForm.TextColor = Color.White;
            BtnIrLoginForm.UseVisualStyleBackColor = false;
            BtnIrLoginForm.Click += BtnIrLoginForm_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(22, 165);
            label2.Name = "label2";
            label2.Size = new Size(270, 86);
            label2.TabIndex = 1;
            label2.Text = "Ingresa tu correo y tu contraseña asociada a tu cuenta y disfruta de la experiencia.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 112);
            label1.Name = "label1";
            label1.Size = new Size(270, 32);
            label1.TabIndex = 0;
            label1.Text = "¿Ya tienes una cuenta?";
            // 
            // TxtCorreo
            // 
            TxtCorreo.BorderStyle = BorderStyle.None;
            TxtCorreo.Font = new Font("Segoe UI", 12F);
            TxtCorreo.ForeColor = Color.FromArgb(64, 64, 64);
            TxtCorreo.Location = new Point(31, 2);
            TxtCorreo.Multiline = true;
            TxtCorreo.Name = "TxtCorreo";
            TxtCorreo.PlaceholderText = "Correo Electronico";
            TxtCorreo.Size = new Size(240, 26);
            TxtCorreo.TabIndex = 8;
            // 
            // panelDerecho
            // 
            panelDerecho.BackgroundImageLayout = ImageLayout.Stretch;
            panelDerecho.Controls.Add(PanelConfirmarContraseña);
            panelDerecho.Controls.Add(BtnCerrar);
            panelDerecho.Controls.Add(PanelContraseña);
            panelDerecho.Controls.Add(PanelCorreoElectronico);
            panelDerecho.Controls.Add(BtnContinuar);
            panelDerecho.Controls.Add(label4);
            panelDerecho.Controls.Add(circularButton3);
            panelDerecho.Controls.Add(circularButton2);
            panelDerecho.Controls.Add(circularButton1);
            panelDerecho.Controls.Add(label3);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(310, 0);
            panelDerecho.Margin = new Padding(3, 2, 3, 2);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(490, 450);
            panelDerecho.TabIndex = 1;
            // 
            // PanelConfirmarContraseña
            // 
            PanelConfirmarContraseña.BackColor = Color.White;
            PanelConfirmarContraseña.BorderColor = Color.FromArgb(113, 113, 122);
            PanelConfirmarContraseña.BorderRadius = 5;
            PanelConfirmarContraseña.BorderSize = 2;
            PanelConfirmarContraseña.Controls.Add(TxtConfirmarContraseña);
            PanelConfirmarContraseña.Controls.Add(iconPictureBox4);
            PanelConfirmarContraseña.Controls.Add(BtnVerConfirmarContraseña);
            PanelConfirmarContraseña.Location = new Point(109, 299);
            PanelConfirmarContraseña.Margin = new Padding(3, 2, 3, 2);
            PanelConfirmarContraseña.Name = "PanelConfirmarContraseña";
            PanelConfirmarContraseña.Padding = new Padding(3, 2, 3, 2);
            PanelConfirmarContraseña.Size = new Size(286, 31);
            PanelConfirmarContraseña.TabIndex = 23;
            // 
            // TxtConfirmarContraseña
            // 
            TxtConfirmarContraseña.BorderStyle = BorderStyle.None;
            TxtConfirmarContraseña.Dock = DockStyle.Left;
            TxtConfirmarContraseña.Font = new Font("Segoe UI", 12F);
            TxtConfirmarContraseña.ForeColor = Color.FromArgb(64, 64, 64);
            TxtConfirmarContraseña.Location = new Point(32, 2);
            TxtConfirmarContraseña.Multiline = true;
            TxtConfirmarContraseña.Name = "TxtConfirmarContraseña";
            TxtConfirmarContraseña.PasswordChar = '*';
            TxtConfirmarContraseña.PlaceholderText = "Confirmar Contraseña";
            TxtConfirmarContraseña.Size = new Size(220, 27);
            TxtConfirmarContraseña.TabIndex = 12;
            // 
            // iconPictureBox4
            // 
            iconPictureBox4.BackColor = Color.White;
            iconPictureBox4.Dock = DockStyle.Left;
            iconPictureBox4.ForeColor = Color.FromArgb(113, 113, 122);
            iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox4.IconColor = Color.FromArgb(113, 113, 122);
            iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox4.IconSize = 27;
            iconPictureBox4.Location = new Point(3, 2);
            iconPictureBox4.Name = "iconPictureBox4";
            iconPictureBox4.Size = new Size(29, 27);
            iconPictureBox4.TabIndex = 9;
            iconPictureBox4.TabStop = false;
            // 
            // BtnVerConfirmarContraseña
            // 
            BtnVerConfirmarContraseña.FlatAppearance.BorderSize = 0;
            BtnVerConfirmarContraseña.FlatStyle = FlatStyle.Flat;
            BtnVerConfirmarContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnVerConfirmarContraseña.IconColor = Color.FromArgb(113, 113, 122);
            BtnVerConfirmarContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVerConfirmarContraseña.IconSize = 20;
            BtnVerConfirmarContraseña.Location = new Point(258, 2);
            BtnVerConfirmarContraseña.Margin = new Padding(3, 2, 3, 2);
            BtnVerConfirmarContraseña.Name = "BtnVerConfirmarContraseña";
            BtnVerConfirmarContraseña.Size = new Size(17, 26);
            BtnVerConfirmarContraseña.TabIndex = 13;
            BtnVerConfirmarContraseña.UseVisualStyleBackColor = true;
            BtnVerConfirmarContraseña.Click += BtnVerConfirmarContraseña_Click;
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
            BtnCerrar.TabIndex = 22;
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // PanelContraseña
            // 
            PanelContraseña.BackColor = Color.White;
            PanelContraseña.BorderColor = Color.FromArgb(113, 113, 122);
            PanelContraseña.BorderRadius = 5;
            PanelContraseña.BorderSize = 2;
            PanelContraseña.Controls.Add(TxtContraseña);
            PanelContraseña.Controls.Add(BtnVerContraseña);
            PanelContraseña.Controls.Add(iconPictureBox2);
            PanelContraseña.Location = new Point(109, 249);
            PanelContraseña.Margin = new Padding(3, 2, 3, 2);
            PanelContraseña.Name = "PanelContraseña";
            PanelContraseña.Padding = new Padding(3, 2, 3, 2);
            PanelContraseña.Size = new Size(286, 31);
            PanelContraseña.TabIndex = 20;
            // 
            // TxtContraseña
            // 
            TxtContraseña.BorderStyle = BorderStyle.None;
            TxtContraseña.Dock = DockStyle.Left;
            TxtContraseña.Font = new Font("Segoe UI", 12F);
            TxtContraseña.ForeColor = Color.FromArgb(64, 64, 64);
            TxtContraseña.Location = new Point(32, 2);
            TxtContraseña.Multiline = true;
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '*';
            TxtContraseña.PlaceholderText = "Contraseña";
            TxtContraseña.Size = new Size(220, 27);
            TxtContraseña.TabIndex = 12;
            TxtContraseña.Enter += TxtContraseña_Enter;
            // 
            // BtnVerContraseña
            // 
            BtnVerContraseña.FlatAppearance.BorderSize = 0;
            BtnVerContraseña.FlatStyle = FlatStyle.Flat;
            BtnVerContraseña.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnVerContraseña.IconColor = Color.FromArgb(113, 113, 122);
            BtnVerContraseña.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVerContraseña.IconSize = 20;
            BtnVerContraseña.Location = new Point(258, 3);
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
            iconPictureBox2.IconSize = 27;
            iconPictureBox2.Location = new Point(3, 2);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(29, 27);
            iconPictureBox2.TabIndex = 9;
            iconPictureBox2.TabStop = false;
            // 
            // PanelCorreoElectronico
            // 
            PanelCorreoElectronico.BackColor = Color.White;
            PanelCorreoElectronico.BorderColor = Color.FromArgb(113, 113, 122);
            PanelCorreoElectronico.BorderRadius = 5;
            PanelCorreoElectronico.BorderSize = 2;
            PanelCorreoElectronico.Controls.Add(iconPictureBox1);
            PanelCorreoElectronico.Controls.Add(TxtCorreo);
            PanelCorreoElectronico.Location = new Point(109, 203);
            PanelCorreoElectronico.Margin = new Padding(3, 2, 3, 2);
            PanelCorreoElectronico.Name = "PanelCorreoElectronico";
            PanelCorreoElectronico.Padding = new Padding(3, 2, 3, 2);
            PanelCorreoElectronico.Size = new Size(286, 31);
            PanelCorreoElectronico.TabIndex = 19;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.ForeColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            iconPictureBox1.IconColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 27;
            iconPictureBox1.Location = new Point(3, 2);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(29, 27);
            iconPictureBox1.TabIndex = 9;
            iconPictureBox1.TabStop = false;
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
            BtnContinuar.Location = new Point(149, 364);
            BtnContinuar.Name = "BtnContinuar";
            BtnContinuar.Size = new Size(199, 52);
            BtnContinuar.TabIndex = 18;
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
            label4.Location = new Point(96, 165);
            label4.Name = "label4";
            label4.Size = new Size(309, 17);
            label4.TabIndex = 11;
            label4.Text = "ó registrate manualmente con tu correo electrónico";
            // 
            // circularButton3
            // 
            circularButton3.Cursor = Cursors.Hand;
            circularButton3.FlatAppearance.BorderColor = Color.White;
            circularButton3.FlatAppearance.BorderSize = 0;
            circularButton3.FlatAppearance.MouseDownBackColor = Color.Silver;
            circularButton3.FlatStyle = FlatStyle.Flat;
            circularButton3.ForeColor = Color.White;
            circularButton3.Image = (Image)resources.GetObject("circularButton3.Image");
            circularButton3.Location = new Point(311, 99);
            circularButton3.Name = "circularButton3";
            circularButton3.Size = new Size(49, 44);
            circularButton3.TabIndex = 10;
            toolTip1.SetToolTip(circularButton3, "Inicia sesión con tu cuenta de Apple");
            circularButton3.UseVisualStyleBackColor = true;
            // 
            // circularButton2
            // 
            circularButton2.Cursor = Cursors.Hand;
            circularButton2.FlatAppearance.BorderColor = Color.Black;
            circularButton2.FlatAppearance.BorderSize = 0;
            circularButton2.FlatAppearance.MouseDownBackColor = Color.Silver;
            circularButton2.FlatStyle = FlatStyle.Flat;
            circularButton2.ForeColor = Color.White;
            circularButton2.Image = (Image)resources.GetObject("circularButton2.Image");
            circularButton2.Location = new Point(219, 99);
            circularButton2.Name = "circularButton2";
            circularButton2.Size = new Size(49, 44);
            circularButton2.TabIndex = 9;
            toolTip1.SetToolTip(circularButton2, "Inicia sesión con tu cuenta de Google");
            circularButton2.UseVisualStyleBackColor = true;
            // 
            // circularButton1
            // 
            circularButton1.Cursor = Cursors.Hand;
            circularButton1.FlatAppearance.BorderColor = Color.White;
            circularButton1.FlatAppearance.MouseDownBackColor = Color.Silver;
            circularButton1.FlatStyle = FlatStyle.Flat;
            circularButton1.ForeColor = Color.White;
            circularButton1.Image = (Image)resources.GetObject("circularButton1.Image");
            circularButton1.Location = new Point(127, 99);
            circularButton1.Name = "circularButton1";
            circularButton1.Size = new Size(49, 44);
            circularButton1.TabIndex = 8;
            toolTip1.SetToolTip(circularButton1, "Inicia sesión con tu cuenta de Facebook");
            circularButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(59, 176, 155);
            label3.Location = new Point(58, 29);
            label3.Name = "label3";
            label3.Size = new Size(370, 40);
            label3.TabIndex = 0;
            label3.Text = "Regístrate en VirtualBook";
            // 
            // iconPictureBox3
            // 
            iconPictureBox3.BackColor = Color.White;
            iconPictureBox3.Dock = DockStyle.Left;
            iconPictureBox3.ForeColor = Color.FromArgb(113, 113, 122);
            iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Key;
            iconPictureBox3.IconColor = Color.FromArgb(113, 113, 122);
            iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox3.IconSize = 33;
            iconPictureBox3.Location = new Point(3, 4);
            iconPictureBox3.Margin = new Padding(3, 4, 3, 4);
            iconPictureBox3.Name = "iconPictureBox3";
            iconPictureBox3.Size = new Size(33, 35);
            iconPictureBox3.TabIndex = 9;
            iconPictureBox3.TabStop = false;
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = Color.White;
            borderedPanel3.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel3.BorderRadius = 5;
            borderedPanel3.BorderSize = 2;
            borderedPanel3.Controls.Add(TxtConfirmarC);
            borderedPanel3.Controls.Add(iconButton1);
            borderedPanel3.Controls.Add(iconPictureBox3);
            borderedPanel3.Location = new Point(120, 403);
            borderedPanel3.Margin = new Padding(3, 4, 3, 4);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Padding = new Padding(3, 4, 3, 4);
            borderedPanel3.Size = new Size(321, 43);
            borderedPanel3.TabIndex = 21;
            // 
            // TxtConfirmarC
            // 
            TxtConfirmarC.Location = new Point(0, 0);
            TxtConfirmarC.Name = "TxtConfirmarC";
            TxtConfirmarC.Size = new Size(100, 23);
            TxtConfirmarC.TabIndex = 0;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconButton1.IconColor = Color.FromArgb(113, 113, 122);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(295, 4);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(19, 35);
            iconButton1.TabIndex = 13;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // ErrorValidaciones
            // 
            ErrorValidaciones.ContainerControl = this;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDerecho);
            Controls.Add(panelIzquierdo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panelIzquierdo.ResumeLayout(false);
            panelIzquierdo.PerformLayout();
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            PanelConfirmarContraseña.ResumeLayout(false);
            PanelConfirmarContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox4).EndInit();
            PanelContraseña.ResumeLayout(false);
            PanelContraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            PanelCorreoElectronico.ResumeLayout(false);
            PanelCorreoElectronico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox3).EndInit();
            borderedPanel3.ResumeLayout(false);
            borderedPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ErrorValidaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIzquierdo;
        private Panel panelDerecho;
        private Label label1;
        private Label label2;
        private Label label3;
        private Controls.RJButton BtnIrLoginForm;
        private Controls.CircularButton circularButton3;
        private Controls.CircularButton circularButton2;
        private Controls.CircularButton circularButton1;
        private Label label4;
        private FontAwesome.Sharp.IconButton BtnVerContraseña;
        private Controls.RoundedTextBox TxtContraseña;
        private Controls.RoundedTextBox TxtCorreo;
        private Controls.RJButton BtnContinuar;
        private Controls.BorderedPanel PanelCorreoElectronico;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Controls.BorderedPanel PanelContraseña;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton BtnVerConfirmarContraseña;
        private Controls.BorderedPanel borderedPanel3;
        private Controls.RoundedTextBox TxtConfirmarC;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private ErrorProvider ErrorValidaciones;
        private Controls.BorderedPanel PanelConfirmarContraseña;
        private Controls.RoundedTextBox TxtConfirmarContraseña;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private ToolTip toolTip1;
    }
}