namespace VirtualBook.Views
{
    partial class ProfileForm
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
            prfFormPnl = new Panel();
            PanelPrincipal = new Panel();
            BtnSeleccionarImagen = new VirtualBook.Controls.CircularButton();
            PcbFotoPerfil = new VirtualBook.Controls.RoundedPictureBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            LblGenero = new Label();
            label15 = new Label();
            LblEditarPerfil = new Label();
            LblFechaNacimiento = new Label();
            label10 = new Label();
            LblEmail = new Label();
            label6 = new Label();
            LblRol = new Label();
            label4 = new Label();
            LblNombre = new Label();
            label2 = new Label();
            label1 = new Label();
            PanelLateral = new Panel();
            borderedPanel3 = new VirtualBook.Controls.BorderedPanel();
            pictureBox3 = new PictureBox();
            dtmfechanacimiento = new DateTimePicker();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            borderedPanel9 = new VirtualBook.Controls.BorderedPanel();
            pictureBox9 = new PictureBox();
            TxtApellidos = new VirtualBook.Controls.RoundedTextBox();
            BtnRegresar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            borderedPanel5 = new VirtualBook.Controls.BorderedPanel();
            CmbGenero = new ComboBox();
            pictureBox5 = new PictureBox();
            borderedPanel2 = new VirtualBook.Controls.BorderedPanel();
            pictureBox2 = new PictureBox();
            TxtEmail = new VirtualBook.Controls.RoundedTextBox();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            pictureBox1 = new PictureBox();
            TxtNombres = new VirtualBook.Controls.RoundedTextBox();
            toolTip1 = new ToolTip(components);
            ErrorValidaciones = new ErrorProvider(components);
            prfFormPnl.SuspendLayout();
            PanelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            PanelLateral.SuspendLayout();
            borderedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).BeginInit();
            borderedPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            borderedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            borderedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorValidaciones).BeginInit();
            SuspendLayout();
            // 
            // prfFormPnl
            // 
            prfFormPnl.Controls.Add(PanelPrincipal);
            prfFormPnl.Controls.Add(PanelLateral);
            prfFormPnl.Dock = DockStyle.Fill;
            prfFormPnl.Location = new Point(0, 0);
            prfFormPnl.Name = "prfFormPnl";
            prfFormPnl.Size = new Size(970, 670);
            prfFormPnl.TabIndex = 0;
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.BackColor = Color.White;
            PanelPrincipal.Controls.Add(BtnSeleccionarImagen);
            PanelPrincipal.Controls.Add(PcbFotoPerfil);
            PanelPrincipal.Controls.Add(iconPictureBox1);
            PanelPrincipal.Controls.Add(LblGenero);
            PanelPrincipal.Controls.Add(label15);
            PanelPrincipal.Controls.Add(LblEditarPerfil);
            PanelPrincipal.Controls.Add(LblFechaNacimiento);
            PanelPrincipal.Controls.Add(label10);
            PanelPrincipal.Controls.Add(LblEmail);
            PanelPrincipal.Controls.Add(label6);
            PanelPrincipal.Controls.Add(LblRol);
            PanelPrincipal.Controls.Add(label4);
            PanelPrincipal.Controls.Add(LblNombre);
            PanelPrincipal.Controls.Add(label2);
            PanelPrincipal.Controls.Add(label1);
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(619, 670);
            PanelPrincipal.TabIndex = 2;
            // 
            // BtnSeleccionarImagen
            // 
            BtnSeleccionarImagen.BackColor = Color.Transparent;
            BtnSeleccionarImagen.BackgroundImage = Properties.Resources.pencil;
            BtnSeleccionarImagen.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSeleccionarImagen.Cursor = Cursors.Hand;
            BtnSeleccionarImagen.FlatAppearance.BorderSize = 0;
            BtnSeleccionarImagen.FlatStyle = FlatStyle.Flat;
            BtnSeleccionarImagen.Location = new Point(177, 262);
            BtnSeleccionarImagen.Name = "BtnSeleccionarImagen";
            BtnSeleccionarImagen.Size = new Size(40, 40);
            BtnSeleccionarImagen.TabIndex = 15;
            toolTip1.SetToolTip(BtnSeleccionarImagen, "Sube una foto de perfil desde tu dispositivo");
            BtnSeleccionarImagen.UseVisualStyleBackColor = false;
            BtnSeleccionarImagen.Click += BtnSeleccionarImagen_Click;
            // 
            // PcbFotoPerfil
            // 
            PcbFotoPerfil.BackColor = Color.Transparent;
            PcbFotoPerfil.BorderColor = Color.Transparent;
            PcbFotoPerfil.BorderSize = 0;
            PcbFotoPerfil.Image = Properties.Resources.avatar;
            PcbFotoPerfil.Location = new Point(19, 76);
            PcbFotoPerfil.Name = "PcbFotoPerfil";
            PcbFotoPerfil.Size = new Size(220, 220);
            PcbFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            PcbFotoPerfil.TabIndex = 25;
            PcbFotoPerfil.TabStop = false;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.Anchor = AnchorStyles.Bottom;
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.ForeColor = SystemColors.Highlight;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconPictureBox1.IconColor = SystemColors.Highlight;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(271, 607);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 25);
            iconPictureBox1.TabIndex = 24;
            iconPictureBox1.TabStop = false;
            // 
            // LblGenero
            // 
            LblGenero.AutoSize = true;
            LblGenero.Font = new Font("Segoe UI", 12F);
            LblGenero.ForeColor = SystemColors.ControlDarkDark;
            LblGenero.Location = new Point(271, 300);
            LblGenero.Name = "LblGenero";
            LblGenero.Size = new Size(81, 21);
            LblGenero.TabIndex = 19;
            LblGenero.Text = "Masculino";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label15.Location = new Point(271, 283);
            label15.Name = "label15";
            label15.Size = new Size(64, 21);
            label15.TabIndex = 18;
            label15.Text = "Género";
            // 
            // LblEditarPerfil
            // 
            LblEditarPerfil.Anchor = AnchorStyles.Bottom;
            LblEditarPerfil.AutoSize = true;
            LblEditarPerfil.Cursor = Cursors.Hand;
            LblEditarPerfil.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
            LblEditarPerfil.ForeColor = SystemColors.Highlight;
            LblEditarPerfil.Location = new Point(295, 611);
            LblEditarPerfil.Name = "LblEditarPerfil";
            LblEditarPerfil.Size = new Size(85, 21);
            LblEditarPerfil.TabIndex = 12;
            LblEditarPerfil.Text = "Edit profile";
            LblEditarPerfil.Click += LblEditarPerfil_Click;
            // 
            // LblFechaNacimiento
            // 
            LblFechaNacimiento.AutoSize = true;
            LblFechaNacimiento.Font = new Font("Segoe UI", 12F);
            LblFechaNacimiento.ForeColor = SystemColors.ControlDarkDark;
            LblFechaNacimiento.Location = new Point(271, 241);
            LblFechaNacimiento.Name = "LblFechaNacimiento";
            LblFechaNacimiento.Size = new Size(94, 21);
            LblFechaNacimiento.TabIndex = 11;
            LblFechaNacimiento.Text = "10/08/2007";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(271, 224);
            label10.Name = "label10";
            label10.Size = new Size(163, 21);
            label10.TabIndex = 10;
            label10.Text = "Fecha de Nacimiento";
            // 
            // LblEmail
            // 
            LblEmail.AutoSize = true;
            LblEmail.Font = new Font("Segoe UI", 12F);
            LblEmail.ForeColor = SystemColors.ControlDarkDark;
            LblEmail.Location = new Point(275, 182);
            LblEmail.Name = "LblEmail";
            LblEmail.Size = new Size(171, 21);
            LblEmail.TabIndex = 8;
            LblEmail.Text = "stevenalv9@gmail.com";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(275, 165);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 7;
            label6.Text = "Email";
            // 
            // LblRol
            // 
            LblRol.AutoSize = true;
            LblRol.Font = new Font("Segoe UI", 12F);
            LblRol.ForeColor = SystemColors.ControlDarkDark;
            LblRol.Location = new Point(275, 131);
            LblRol.Name = "LblRol";
            LblRol.Size = new Size(82, 21);
            LblRol.TabIndex = 6;
            LblRol.Text = "Estudiante";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(275, 114);
            label4.Name = "label4";
            label4.Size = new Size(34, 21);
            label4.TabIndex = 5;
            label4.Text = "Rol";
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Font = new Font("Segoe UI", 12F);
            LblNombre.ForeColor = SystemColors.ControlDarkDark;
            LblNombre.Location = new Point(275, 83);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(256, 21);
            LblNombre.TabIndex = 4;
            LblNombre.Text = "Steven Alejandro Álvarez Avendaño";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(275, 66);
            label2.Name = "label2";
            label2.Size = new Size(71, 21);
            label2.TabIndex = 3;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(114, 37);
            label1.TabIndex = 2;
            label1.Text = "Mí Perfíl";
            // 
            // PanelLateral
            // 
            PanelLateral.BackColor = Color.FromArgb(58, 177, 155);
            PanelLateral.Controls.Add(borderedPanel3);
            PanelLateral.Controls.Add(BtnGuardar);
            PanelLateral.Controls.Add(iconPictureBox2);
            PanelLateral.Controls.Add(borderedPanel9);
            PanelLateral.Controls.Add(BtnRegresar);
            PanelLateral.Controls.Add(label3);
            PanelLateral.Controls.Add(borderedPanel5);
            PanelLateral.Controls.Add(borderedPanel2);
            PanelLateral.Controls.Add(borderedPanel1);
            PanelLateral.Dock = DockStyle.Right;
            PanelLateral.Location = new Point(619, 0);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(351, 670);
            PanelLateral.TabIndex = 1;
            PanelLateral.Tag = "NoCambiarTema";
            PanelLateral.Visible = false;
            // 
            // borderedPanel3
            // 
            borderedPanel3.BackColor = Color.White;
            borderedPanel3.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel3.BorderRadius = 5;
            borderedPanel3.BorderSize = 2;
            borderedPanel3.Controls.Add(pictureBox3);
            borderedPanel3.Controls.Add(dtmfechanacimiento);
            borderedPanel3.Location = new Point(6, 249);
            borderedPanel3.Name = "borderedPanel3";
            borderedPanel3.Padding = new Padding(3);
            borderedPanel3.Size = new Size(337, 36);
            borderedPanel3.TabIndex = 42;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_calendario1;
            pictureBox3.Location = new Point(6, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // dtmfechanacimiento
            // 
            dtmfechanacimiento.CalendarForeColor = Color.FromArgb(64, 64, 64);
            dtmfechanacimiento.CalendarTitleForeColor = Color.FromArgb(64, 64, 64);
            dtmfechanacimiento.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtmfechanacimiento.Format = DateTimePickerFormat.Short;
            dtmfechanacimiento.Location = new Point(34, 5);
            dtmfechanacimiento.Margin = new Padding(3, 2, 3, 2);
            dtmfechanacimiento.Name = "dtmfechanacimiento";
            dtmfechanacimiento.Size = new Size(297, 25);
            dtmfechanacimiento.TabIndex = 14;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Anchor = AnchorStyles.Bottom;
            BtnGuardar.BackColor = Color.FromArgb(58, 177, 155);
            BtnGuardar.Cursor = Cursors.Hand;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.White;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.IconSize = 36;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(114, 618);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(136, 40);
            BtnGuardar.TabIndex = 41;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click_1;
            // 
            // iconPictureBox2
            // 
            iconPictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconPictureBox2.BackColor = Color.FromArgb(58, 177, 155);
            iconPictureBox2.Cursor = Cursors.Hand;
            iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconPictureBox2.IconColor = Color.White;
            iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox2.IconSize = 25;
            iconPictureBox2.Location = new Point(256, 16);
            iconPictureBox2.Name = "iconPictureBox2";
            iconPictureBox2.Size = new Size(25, 25);
            iconPictureBox2.TabIndex = 40;
            iconPictureBox2.TabStop = false;
            // 
            // borderedPanel9
            // 
            borderedPanel9.BackColor = Color.White;
            borderedPanel9.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel9.BorderRadius = 5;
            borderedPanel9.BorderSize = 2;
            borderedPanel9.Controls.Add(pictureBox9);
            borderedPanel9.Controls.Add(TxtApellidos);
            borderedPanel9.Location = new Point(6, 103);
            borderedPanel9.Name = "borderedPanel9";
            borderedPanel9.Padding = new Padding(3);
            borderedPanel9.Size = new Size(336, 34);
            borderedPanel9.TabIndex = 37;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.user;
            pictureBox9.Location = new Point(5, 4);
            pictureBox9.Margin = new Padding(3, 2, 3, 2);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(26, 26);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 27;
            pictureBox9.TabStop = false;
            // 
            // TxtApellidos
            // 
            TxtApellidos.BorderStyle = BorderStyle.None;
            TxtApellidos.Font = new Font("Segoe UI", 12F);
            TxtApellidos.ForeColor = Color.FromArgb(64, 64, 64);
            TxtApellidos.Location = new Point(32, 4);
            TxtApellidos.Multiline = true;
            TxtApellidos.Name = "TxtApellidos";
            TxtApellidos.PlaceholderText = "Apellidos";
            TxtApellidos.Size = new Size(298, 26);
            TxtApellidos.TabIndex = 8;
            // 
            // BtnRegresar
            // 
            BtnRegresar.Cursor = Cursors.Hand;
            BtnRegresar.FlatAppearance.BorderSize = 0;
            BtnRegresar.FlatStyle = FlatStyle.Flat;
            BtnRegresar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            BtnRegresar.IconColor = Color.White;
            BtnRegresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRegresar.IconSize = 30;
            BtnRegresar.Location = new Point(6, 14);
            BtnRegresar.Name = "BtnRegresar";
            BtnRegresar.Size = new Size(31, 23);
            BtnRegresar.TabIndex = 36;
            BtnRegresar.UseVisualStyleBackColor = true;
            BtnRegresar.Click += BtnRegresar_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(101, 9);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 34;
            label3.Text = "Editar Perfíl";
            // 
            // borderedPanel5
            // 
            borderedPanel5.BackColor = Color.White;
            borderedPanel5.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel5.BorderRadius = 5;
            borderedPanel5.BorderSize = 2;
            borderedPanel5.Controls.Add(CmbGenero);
            borderedPanel5.Controls.Add(pictureBox5);
            borderedPanel5.Location = new Point(6, 200);
            borderedPanel5.Name = "borderedPanel5";
            borderedPanel5.Padding = new Padding(3);
            borderedPanel5.Size = new Size(339, 34);
            borderedPanel5.TabIndex = 31;
            // 
            // CmbGenero
            // 
            CmbGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbGenero.FormattingEnabled = true;
            CmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            CmbGenero.Location = new Point(35, 6);
            CmbGenero.Name = "CmbGenero";
            CmbGenero.Size = new Size(296, 23);
            CmbGenero.TabIndex = 29;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.genero;
            pictureBox5.Location = new Point(5, 8);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 21);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 28;
            pictureBox5.TabStop = false;
            // 
            // borderedPanel2
            // 
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel2.BorderRadius = 5;
            borderedPanel2.BorderSize = 2;
            borderedPanel2.Controls.Add(pictureBox2);
            borderedPanel2.Controls.Add(TxtEmail);
            borderedPanel2.Location = new Point(6, 153);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Padding = new Padding(3);
            borderedPanel2.Size = new Size(336, 32);
            borderedPanel2.TabIndex = 28;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.email;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // TxtEmail
            // 
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.Font = new Font("Segoe UI", 12F);
            TxtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            TxtEmail.Location = new Point(32, 3);
            TxtEmail.Multiline = true;
            TxtEmail.Name = "TxtEmail";
            TxtEmail.PlaceholderText = "Email";
            TxtEmail.Size = new Size(223, 26);
            TxtEmail.TabIndex = 12;
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel1.BorderRadius = 5;
            borderedPanel1.BorderSize = 2;
            borderedPanel1.Controls.Add(pictureBox1);
            borderedPanel1.Controls.Add(TxtNombres);
            borderedPanel1.Location = new Point(6, 53);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Padding = new Padding(3);
            borderedPanel1.Size = new Size(336, 34);
            borderedPanel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // TxtNombres
            // 
            TxtNombres.BorderStyle = BorderStyle.None;
            TxtNombres.Font = new Font("Segoe UI", 12F);
            TxtNombres.ForeColor = Color.FromArgb(64, 64, 64);
            TxtNombres.Location = new Point(32, 4);
            TxtNombres.Multiline = true;
            TxtNombres.Name = "TxtNombres";
            TxtNombres.PlaceholderText = "Nombres";
            TxtNombres.Size = new Size(298, 26);
            TxtNombres.TabIndex = 8;
            // 
            // ErrorValidaciones
            // 
            ErrorValidaciones.ContainerControl = this;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 670);
            Controls.Add(prfFormPnl);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProfileForm";
            Text = "ProfileForm";
            Load += ProfileForm_Load;
            prfFormPnl.ResumeLayout(false);
            PanelPrincipal.ResumeLayout(false);
            PanelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            PanelLateral.ResumeLayout(false);
            PanelLateral.PerformLayout();
            borderedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox2).EndInit();
            borderedPanel9.ResumeLayout(false);
            borderedPanel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            borderedPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            borderedPanel2.ResumeLayout(false);
            borderedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorValidaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel prfFormPnl;
        private Panel sideBarPnl;
        private Panel PanelLateral;
        private Panel indexPrfPnl;
        private PictureBox pixBxInfo;
        private Panel PanelPrincipal;
        private Label LblNombre;
        private Label label2;
        private Label label1;
        private Label LblEditarPerfil;
        private Label LblFechaNacimiento;
        private Label label10;
        private Label LblEmail;
        private Label label6;
        private Label LblRol;
        private Label label4;
        private Controls.CircularButton BtnSeleccionarImagen;
        private Label LblGenero;
        private Label label15;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Controls.BorderedPanel borderedPanel5;
        private PictureBox pictureBox5;
        private Controls.BorderedPanel borderedPanel2;
        private PictureBox pictureBox2;
        private Controls.RoundedTextBox TxtEmail;
        private Controls.BorderedPanel borderedPanel1;
        private PictureBox pictureBox1;
        private Controls.RoundedTextBox TxtNombres;
        private Label label3;
        private FontAwesome.Sharp.IconButton BtnRegresar;
        private Controls.BorderedPanel borderedPanel9;
        private PictureBox pictureBox9;
        private Controls.RoundedTextBox TxtApellidos;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private Controls.RoundedPictureBox PcbFotoPerfil;
        private ToolTip toolTip1;
        private Controls.BorderedPanel borderedPanel3;
        private PictureBox pictureBox3;
        private DateTimePicker dtmfechanacimiento;
        private ComboBox CmbGenero;
        private ErrorProvider ErrorValidaciones;
    }
}