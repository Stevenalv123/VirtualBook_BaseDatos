namespace VirtualBook.Views
{
    partial class UserInformationForm
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
            panelDerecho = new Panel();
            borderedPanel10 = new VirtualBook.Controls.BorderedPanel();
            borderedPanel3 = new VirtualBook.Controls.BorderedPanel();
            pictureBox5 = new PictureBox();
            dtmfechanacimiento = new DateTimePicker();
            borderedPanel5 = new VirtualBook.Controls.BorderedPanel();
            pictureBox6 = new PictureBox();
            cbogenero = new ComboBox();
            borderedPanel7 = new VirtualBook.Controls.BorderedPanel();
            pictureBox8 = new PictureBox();
            cborol = new ComboBox();
            BtnRegresar = new FontAwesome.Sharp.IconButton();
            BtnCerrar = new FontAwesome.Sharp.IconButton();
            BtnRegistrar = new VirtualBook.Controls.RJButton();
            label4 = new Label();
            label3 = new Label();
            borderedPanel9 = new VirtualBook.Controls.BorderedPanel();
            BtnSeleccionarImagen = new VirtualBook.Controls.CircularButton();
            PcbFotoPerfil = new VirtualBook.Controls.RoundedPictureBox();
            borderedPanel8 = new VirtualBook.Controls.BorderedPanel();
            pictureBox2 = new PictureBox();
            TxtApellidosUsuarios = new VirtualBook.Controls.RoundedTextBox();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            pictureBox1 = new PictureBox();
            TxtNombreUsuario = new VirtualBook.Controls.RoundedTextBox();
            panelDerecho.SuspendLayout();
            borderedPanel10.SuspendLayout();
            borderedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            borderedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            borderedPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            borderedPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).BeginInit();
            borderedPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelDerecho
            // 
            panelDerecho.BackgroundImageLayout = ImageLayout.Stretch;
            panelDerecho.Controls.Add(borderedPanel10);
            panelDerecho.Controls.Add(BtnRegresar);
            panelDerecho.Controls.Add(BtnCerrar);
            panelDerecho.Controls.Add(BtnRegistrar);
            panelDerecho.Controls.Add(label4);
            panelDerecho.Controls.Add(label3);
            panelDerecho.Controls.Add(borderedPanel9);
            panelDerecho.Dock = DockStyle.Fill;
            panelDerecho.Location = new Point(0, 0);
            panelDerecho.Margin = new Padding(3, 2, 3, 2);
            panelDerecho.Name = "panelDerecho";
            panelDerecho.Size = new Size(511, 726);
            panelDerecho.TabIndex = 2;
            // 
            // borderedPanel10
            // 
            borderedPanel10.BackColor = Color.White;
            borderedPanel10.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel10.BorderRadius = 5;
            borderedPanel10.BorderSize = 1;
            borderedPanel10.Controls.Add(borderedPanel3);
            borderedPanel10.Controls.Add(borderedPanel5);
            borderedPanel10.Controls.Add(borderedPanel7);
            borderedPanel10.Location = new Point(79, 436);
            borderedPanel10.Name = "borderedPanel10";
            borderedPanel10.Padding = new Padding(3);
            borderedPanel10.Size = new Size(370, 187);
            borderedPanel10.TabIndex = 38;
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = Color.White;
            borderedPanel3.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel3.BorderRadius = 5;
            borderedPanel3.BorderSize = 2;
            borderedPanel3.Controls.Add(pictureBox5);
            borderedPanel3.Controls.Add(dtmfechanacimiento);
            borderedPanel3.Location = new Point(42, 18);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Padding = new Padding(3);
            borderedPanel3.Size = new Size(281, 42);
            borderedPanel3.TabIndex = 21;
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
            dtmfechanacimiento.Size = new Size(238, 25);
            dtmfechanacimiento.TabIndex = 14;
            // 
            // borderedPanel5
            // 
            borderedPanel5.BackColor = Color.White;
            borderedPanel5.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel5.BorderRadius = 5;
            borderedPanel5.BorderSize = 2;
            borderedPanel5.Controls.Add(pictureBox6);
            borderedPanel5.Controls.Add(cbogenero);
            borderedPanel5.Location = new Point(42, 73);
            borderedPanel5.Name = "borderedPanel5";
            borderedPanel5.Padding = new Padding(3);
            borderedPanel5.Size = new Size(281, 43);
            borderedPanel5.TabIndex = 24;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_símbolo_de_venus_50;
            pictureBox6.Location = new Point(6, 8);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 24);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // cbogenero
            // 
            cbogenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cbogenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbogenero.ForeColor = Color.FromArgb(64, 64, 64);
            cbogenero.FormattingEnabled = true;
            cbogenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cbogenero.Location = new Point(34, 8);
            cbogenero.Margin = new Padding(3, 2, 3, 2);
            cbogenero.Name = "cbogenero";
            cbogenero.Size = new Size(238, 23);
            cbogenero.TabIndex = 10;
            // 
            // borderedPanel7
            // 
            borderedPanel7.BackColor = Color.White;
            borderedPanel7.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel7.BorderRadius = 5;
            borderedPanel7.BorderSize = 2;
            borderedPanel7.Controls.Add(pictureBox8);
            borderedPanel7.Controls.Add(cborol);
            borderedPanel7.Location = new Point(42, 129);
            borderedPanel7.Name = "borderedPanel7";
            borderedPanel7.Padding = new Padding(3);
            borderedPanel7.Size = new Size(283, 39);
            borderedPanel7.TabIndex = 26;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.icons8_roles_50;
            pictureBox8.Location = new Point(9, 6);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(22, 24);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 11;
            pictureBox8.TabStop = false;
            // 
            // cborol
            // 
            cborol.DropDownStyle = ComboBoxStyle.DropDownList;
            cborol.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cborol.ForeColor = Color.FromArgb(64, 64, 64);
            cborol.FormattingEnabled = true;
            cborol.Items.AddRange(new object[] { "Estudiante", "Docente" });
            cborol.Location = new Point(37, 8);
            cborol.Margin = new Padding(3, 2, 3, 2);
            cborol.Name = "cborol";
            cborol.Size = new Size(235, 23);
            cborol.TabIndex = 10;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.FlatAppearance.BorderSize = 0;
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            BtnRegresar.IconColor = Color.FromArgb(113, 113, 122);
            BtnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRegresar.IconSize = 30;
            BtnRegresar.Location = new Point(12, 10);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(31, 23);
            BtnRegresar.TabIndex = 37;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnCerrar.IconColor = Color.FromArgb(113, 113, 122);
            BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCerrar.IconSize = 30;
            BtnCerrar.Location = new Point(478, 5);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(30, 33);
            BtnCerrar.TabIndex = 22;
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.FromArgb(59, 176, 155);
            BtnRegistrar.BackgroundColor = Color.FromArgb(59, 176, 155);
            BtnRegistrar.BorderColor = Color.PaleVioletRed;
            BtnRegistrar.BorderRadius = 20;
            BtnRegistrar.BorderSize = 0;
            BtnRegistrar.Cursor = Cursors.Hand;
            BtnRegistrar.FlatAppearance.BorderSize = 0;
            BtnRegistrar.FlatStyle = FlatStyle.Flat;
            BtnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnRegistrar.ForeColor = Color.White;
            BtnRegistrar.Location = new Point(158, 648);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(199, 52);
            BtnRegistrar.TabIndex = 18;
            BtnRegistrar.Text = "Continuar";
            BtnRegistrar.TextColor = Color.White;
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(137, 61);
            label4.Name = "label4";
            label4.Size = new Size(252, 17);
            label4.TabIndex = 11;
            label4.Text = "Completa tu informacion en VirtualBook";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(59, 176, 155);
            label3.Location = new Point(79, 21);
            label3.Name = "label3";
            label3.Size = new Size(370, 40);
            label3.TabIndex = 0;
            label3.Text = "Regístrate en VirtualBook";
            // 
            // borderedPanel9
            // 
            borderedPanel9.BackColor = Color.White;
            borderedPanel9.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel9.BorderRadius = 5;
            borderedPanel9.BorderSize = 1;
            borderedPanel9.Controls.Add(BtnSeleccionarImagen);
            borderedPanel9.Controls.Add(PcbFotoPerfil);
            borderedPanel9.Controls.Add(borderedPanel8);
            borderedPanel9.Controls.Add(borderedPanel1);
            borderedPanel9.Location = new Point(79, 104);
            borderedPanel9.Name = "borderedPanel9";
            borderedPanel9.Padding = new Padding(3);
            borderedPanel9.Size = new Size(370, 314);
            borderedPanel9.TabIndex = 28;
            // 
            // BtnSeleccionarImagen
            // 
            BtnSeleccionarImagen.BackColor = Color.Transparent;
            BtnSeleccionarImagen.BackgroundImage = Properties.Resources.pencil;
            BtnSeleccionarImagen.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSeleccionarImagen.Cursor = Cursors.Hand;
            BtnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            BtnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            BtnSeleccionarImagen.Location = new Point(223, 144);
            BtnSeleccionarImagen.Name = "BtnSeleccionarImagen";
            BtnSeleccionarImagen.Size = new Size(40, 40);
            BtnSeleccionarImagen.TabIndex = 30;
            BtnSeleccionarImagen.UseVisualStyleBackColor = false;
            BtnSeleccionarImagen.Click += BtnSeleccionarImagen_Click;
            // 
            // PcbFotoPerfil
            // 
            PcbFotoPerfil.BackColor = Color.Transparent;
            PcbFotoPerfil.BorderColor = Color.Gray;
            PcbFotoPerfil.BorderSize = 0;
            PcbFotoPerfil.Cursor = Cursors.Hand;
            PcbFotoPerfil.Image = Properties.Resources.avatar;
            PcbFotoPerfil.Location = new Point(103, 24);
            PcbFotoPerfil.Name = "PcbFotoPerfil";
            PcbFotoPerfil.Size = new Size(160, 160);
            PcbFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            PcbFotoPerfil.TabIndex = 28;
            PcbFotoPerfil.TabStop = false;
            PcbFotoPerfil.Click += PcbFotoPerfil_Click;
            // 
            // borderedPanel8
            // 
            borderedPanel8.BackColor = Color.White;
            borderedPanel8.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel8.BorderRadius = 5;
            borderedPanel8.BorderSize = 2;
            borderedPanel8.Controls.Add(pictureBox2);
            borderedPanel8.Controls.Add(TxtApellidosUsuarios);
            borderedPanel8.Location = new Point(42, 257);
            borderedPanel8.Name = "borderedPanel8";
            borderedPanel8.Padding = new Padding(3);
            borderedPanel8.Size = new Size(281, 34);
            borderedPanel8.TabIndex = 27;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_formato_de_estilo_de_fuente_32__1_;
            pictureBox2.Location = new Point(4, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // TxtApellidosUsuarios
            // 
            TxtApellidosUsuarios.BorderStyle = BorderStyle.None;
            TxtApellidosUsuarios.Font = new Font("Segoe UI", 12F);
            TxtApellidosUsuarios.ForeColor = Color.FromArgb(64, 64, 64);
            TxtApellidosUsuarios.Location = new Point(32, 4);
            TxtApellidosUsuarios.Multiline = true;
            TxtApellidosUsuarios.Name = "TxtApellidosUsuarios";
            TxtApellidosUsuarios.PlaceholderText = "Apellidos";
            TxtApellidosUsuarios.Size = new Size(246, 26);
            TxtApellidosUsuarios.TabIndex = 8;
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel1.BorderRadius = 5;
            borderedPanel1.BorderSize = 2;
            borderedPanel1.Controls.Add(pictureBox1);
            borderedPanel1.Controls.Add(TxtNombreUsuario);
            borderedPanel1.Location = new Point(42, 207);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Padding = new Padding(3);
            borderedPanel1.Size = new Size(281, 34);
            borderedPanel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // TxtNombreUsuario
            // 
            TxtNombreUsuario.BorderStyle = BorderStyle.None;
            TxtNombreUsuario.Font = new Font("Segoe UI", 12F);
            TxtNombreUsuario.ForeColor = Color.FromArgb(64, 64, 64);
            TxtNombreUsuario.Location = new Point(32, 4);
            TxtNombreUsuario.Multiline = true;
            TxtNombreUsuario.Name = "TxtNombreUsuario";
            TxtNombreUsuario.PlaceholderText = "Nombres";
            TxtNombreUsuario.Size = new Size(246, 26);
            TxtNombreUsuario.TabIndex = 8;
            // 
            // UserInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 726);
            Controls.Add(panelDerecho);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserInformationForm";
            panelDerecho.ResumeLayout(false);
            panelDerecho.PerformLayout();
            borderedPanel10.ResumeLayout(false);
            borderedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            borderedPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            borderedPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            borderedPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).EndInit();
            borderedPanel8.ResumeLayout(false);
            borderedPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDerecho;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private Controls.BorderedPanel borderedPanel1;
        private Controls.RoundedTextBox TxtNombreUsuario;
        private Controls.RJButton BtnRegistrar;
        private Label label4;
        private Label label3;
        private Controls.BorderedPanel borderedPanel5;
        private ComboBox cbogenero;
        private Controls.BorderedPanel borderedPanel7;
        private ComboBox cborol;
        private Controls.BorderedPanel borderedPanel8;
        private Controls.RoundedTextBox TxtApellidosUsuarios;
        private Controls.BorderedPanel borderedPanel9;
        private Controls.BorderedPanel borderedPanel10;
        private FontAwesome.Sharp.IconButton BtnRegresar;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private Controls.BorderedPanel borderedPanel3;
        private PictureBox pictureBox5;
        private DateTimePicker dtmfechanacimiento;
        private Controls.RoundedPictureBox PcbFotoPerfil;
        private Controls.CircularButton BtnSeleccionarImagen;
    }
}