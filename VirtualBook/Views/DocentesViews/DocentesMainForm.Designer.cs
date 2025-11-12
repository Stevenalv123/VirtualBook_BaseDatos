namespace VirtualBook.Views.DocentesViews
{
    partial class DocentesMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocentesMainForm));
            panel1 = new Panel();
            panel2 = new Panel();
            PcbCargandoUser = new PictureBox();
            LblCorreoUsuario = new Label();
            LblNombreUsuario = new Label();
            PcbFotoUsuario = new VirtualBook.Controls.RoundedPictureBox();
            panel7 = new Panel();
            panel10 = new Panel();
            PanelConfiguracion = new Panel();
            BtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            BtnConfiguracion = new FontAwesome.Sharp.IconButton();
            BtnMiperfil = new FontAwesome.Sharp.IconButton();
            BtnVerLibros = new FontAwesome.Sharp.IconButton();
            MostraMenuPrincipalForms = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PanelTop = new Panel();
            BtnCambiarTema = new FontAwesome.Sharp.IconButton();
            rjButton1 = new VirtualBook.Controls.RJButton();
            rjButton2 = new VirtualBook.Controls.RJButton();
            BtnSwitchTheme = new FontAwesome.Sharp.IconButton();
            BtnAyuda = new VirtualBook.Controls.RJButton();
            BtnNotificaciones = new VirtualBook.Controls.RJButton();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            TxtBucarLibros = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            PanelCentral = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargandoUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoUsuario).BeginInit();
            panel10.SuspendLayout();
            PanelConfiguracion.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTop.SuspendLayout();
            borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 177, 155);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 778);
            panel1.TabIndex = 1;
            panel1.Tag = "NoCambiarTema";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(PcbCargandoUser);
            panel2.Controls.Add(LblCorreoUsuario);
            panel2.Controls.Add(LblNombreUsuario);
            panel2.Controls.Add(PcbFotoUsuario);
            panel2.Location = new Point(21, 718);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 57);
            panel2.TabIndex = 3;
            // 
            // PcbCargandoUser
            // 
            PcbCargandoUser.Image = Properties.Resources.skeletonAnimation;
            PcbCargandoUser.Location = new Point(0, -3);
            PcbCargandoUser.Name = "PcbCargandoUser";
            PcbCargandoUser.Size = new Size(235, 62);
            PcbCargandoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbCargandoUser.TabIndex = 7;
            PcbCargandoUser.TabStop = false;
            // 
            // LblCorreoUsuario
            // 
            LblCorreoUsuario.AutoSize = true;
            LblCorreoUsuario.Font = new Font("Segoe UI", 10F);
            LblCorreoUsuario.ForeColor = Color.White;
            LblCorreoUsuario.Location = new Point(59, 25);
            LblCorreoUsuario.Name = "LblCorreoUsuario";
            LblCorreoUsuario.Size = new Size(45, 19);
            LblCorreoUsuario.TabIndex = 2;
            LblCorreoUsuario.Text = "label2";
            // 
            // LblNombreUsuario
            // 
            LblNombreUsuario.AutoSize = true;
            LblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblNombreUsuario.ForeColor = Color.White;
            LblNombreUsuario.Location = new Point(59, 4);
            LblNombreUsuario.Name = "LblNombreUsuario";
            LblNombreUsuario.Size = new Size(57, 21);
            LblNombreUsuario.TabIndex = 1;
            LblNombreUsuario.Text = "label2";
            // 
            // PcbFotoUsuario
            // 
            PcbFotoUsuario.BackColor = Color.Transparent;
            PcbFotoUsuario.BorderColor = Color.Transparent;
            PcbFotoUsuario.BorderSize = 0;
            PcbFotoUsuario.Location = new Point(3, 4);
            PcbFotoUsuario.Name = "PcbFotoUsuario";
            PcbFotoUsuario.Size = new Size(50, 50);
            PcbFotoUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            PcbFotoUsuario.TabIndex = 0;
            PcbFotoUsuario.TabStop = false;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.Location = new Point(0, 1383);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 73);
            panel7.TabIndex = 2;
            panel7.Tag = "NoCambiarTema";
            // 
            // panel10
            // 
            panel10.Controls.Add(PanelConfiguracion);
            panel10.Controls.Add(BtnConfiguracion);
            panel10.Controls.Add(BtnMiperfil);
            panel10.Controls.Add(BtnVerLibros);
            panel10.Controls.Add(MostraMenuPrincipalForms);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 127);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(10, 0, 10, 0);
            panel10.Size = new Size(289, 582);
            panel10.TabIndex = 1;
            panel10.Tag = "NoCambiarTema";
            // 
            // PanelConfiguracion
            // 
            PanelConfiguracion.Controls.Add(BtnCerrarSesion);
            PanelConfiguracion.Dock = DockStyle.Top;
            PanelConfiguracion.Location = new Point(10, 200);
            PanelConfiguracion.Name = "PanelConfiguracion";
            PanelConfiguracion.Padding = new Padding(10, 0, 10, 0);
            PanelConfiguracion.Size = new Size(269, 123);
            PanelConfiguracion.TabIndex = 5;
            PanelConfiguracion.Visible = false;
            // 
            // BtnCerrarSesion
            // 
            BtnCerrarSesion.Cursor = Cursors.Hand;
            BtnCerrarSesion.Dock = DockStyle.Top;
            BtnCerrarSesion.FlatAppearance.BorderSize = 0;
            BtnCerrarSesion.FlatStyle = FlatStyle.Flat;
            BtnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnCerrarSesion.ForeColor = Color.White;
            BtnCerrarSesion.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            BtnCerrarSesion.IconColor = Color.White;
            BtnCerrarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCerrarSesion.IconSize = 32;
            BtnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCerrarSesion.Location = new Point(10, 0);
            BtnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Padding = new Padding(20, 0, 32, 0);
            BtnCerrarSesion.Size = new Size(249, 50);
            BtnCerrarSesion.TabIndex = 4;
            BtnCerrarSesion.Text = "Cerrar Sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // BtnConfiguracion
            // 
            BtnConfiguracion.Cursor = Cursors.Hand;
            BtnConfiguracion.Dock = DockStyle.Top;
            BtnConfiguracion.FlatAppearance.BorderSize = 0;
            BtnConfiguracion.FlatStyle = FlatStyle.Flat;
            BtnConfiguracion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnConfiguracion.ForeColor = Color.White;
            BtnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.Tools;
            BtnConfiguracion.IconColor = Color.White;
            BtnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnConfiguracion.IconSize = 32;
            BtnConfiguracion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnConfiguracion.Location = new Point(10, 150);
            BtnConfiguracion.Margin = new Padding(3, 2, 3, 2);
            BtnConfiguracion.Name = "BtnConfiguracion";
            BtnConfiguracion.Padding = new Padding(20, 0, 32, 0);
            BtnConfiguracion.Size = new Size(269, 50);
            BtnConfiguracion.TabIndex = 4;
            BtnConfiguracion.Text = "Configuración";
            BtnConfiguracion.UseVisualStyleBackColor = true;
            BtnConfiguracion.Click += BtnConfiguracion_Click;
            // 
            // BtnMiperfil
            // 
            BtnMiperfil.Dock = DockStyle.Top;
            BtnMiperfil.FlatAppearance.BorderSize = 0;
            BtnMiperfil.FlatStyle = FlatStyle.Flat;
            BtnMiperfil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnMiperfil.ForeColor = Color.White;
            BtnMiperfil.IconChar = FontAwesome.Sharp.IconChar.User;
            BtnMiperfil.IconColor = Color.White;
            BtnMiperfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMiperfil.IconSize = 32;
            BtnMiperfil.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMiperfil.Location = new Point(10, 100);
            BtnMiperfil.Margin = new Padding(3, 2, 3, 2);
            BtnMiperfil.Name = "BtnMiperfil";
            BtnMiperfil.Padding = new Padding(20, 0, 72, 0);
            BtnMiperfil.Size = new Size(269, 50);
            BtnMiperfil.TabIndex = 3;
            BtnMiperfil.Text = "Mi perfil";
            BtnMiperfil.UseVisualStyleBackColor = true;
            BtnMiperfil.Click += BtnMiperfil_Click;
            // 
            // BtnVerLibros
            // 
            BtnVerLibros.Dock = DockStyle.Top;
            BtnVerLibros.FlatAppearance.BorderSize = 0;
            BtnVerLibros.FlatStyle = FlatStyle.Flat;
            BtnVerLibros.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnVerLibros.ForeColor = Color.White;
            BtnVerLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnVerLibros.IconColor = Color.White;
            BtnVerLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVerLibros.IconSize = 32;
            BtnVerLibros.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVerLibros.Location = new Point(10, 50);
            BtnVerLibros.Margin = new Padding(3, 2, 3, 2);
            BtnVerLibros.Name = "BtnVerLibros";
            BtnVerLibros.Padding = new Padding(20, 0, 65, 0);
            BtnVerLibros.Size = new Size(269, 50);
            BtnVerLibros.TabIndex = 2;
            BtnVerLibros.Text = "Ver libros";
            BtnVerLibros.UseVisualStyleBackColor = true;
            BtnVerLibros.Click += BtnVerLibros_Click;
            // 
            // MostraMenuPrincipalForms
            // 
            MostraMenuPrincipalForms.Dock = DockStyle.Top;
            MostraMenuPrincipalForms.FlatAppearance.BorderSize = 0;
            MostraMenuPrincipalForms.FlatStyle = FlatStyle.Flat;
            MostraMenuPrincipalForms.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MostraMenuPrincipalForms.ForeColor = Color.White;
            MostraMenuPrincipalForms.IconChar = FontAwesome.Sharp.IconChar.House;
            MostraMenuPrincipalForms.IconColor = Color.White;
            MostraMenuPrincipalForms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MostraMenuPrincipalForms.IconSize = 32;
            MostraMenuPrincipalForms.ImageAlign = ContentAlignment.MiddleLeft;
            MostraMenuPrincipalForms.Location = new Point(10, 0);
            MostraMenuPrincipalForms.Margin = new Padding(3, 3, 3, 10);
            MostraMenuPrincipalForms.Name = "MostraMenuPrincipalForms";
            MostraMenuPrincipalForms.Padding = new Padding(20, 0, 20, 0);
            MostraMenuPrincipalForms.Size = new Size(269, 50);
            MostraMenuPrincipalForms.TabIndex = 0;
            MostraMenuPrincipalForms.Text = "Menu principal";
            MostraMenuPrincipalForms.UseVisualStyleBackColor = true;
            MostraMenuPrincipalForms.Click += MostraMenuPrincipalForms_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 127);
            panel5.TabIndex = 0;
            panel5.Tag = "NoCambiarTema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(75, 26);
            label1.Name = "label1";
            label1.Size = new Size(178, 37);
            label1.TabIndex = 1;
            label1.Text = "Virtual Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(87, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.White;
            PanelTop.Controls.Add(BtnCambiarTema);
            PanelTop.Controls.Add(rjButton1);
            PanelTop.Controls.Add(rjButton2);
            PanelTop.Controls.Add(BtnSwitchTheme);
            PanelTop.Controls.Add(BtnAyuda);
            PanelTop.Controls.Add(BtnNotificaciones);
            PanelTop.Controls.Add(borderedPanel1);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(289, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(970, 74);
            PanelTop.TabIndex = 2;
            // 
            // BtnCambiarTema
            // 
            BtnCambiarTema.Anchor = AnchorStyles.Right;
            BtnCambiarTema.Cursor = Cursors.Hand;
            BtnCambiarTema.FlatAppearance.BorderSize = 0;
            BtnCambiarTema.FlatStyle = FlatStyle.Flat;
            BtnCambiarTema.IconChar = FontAwesome.Sharp.IconChar.Moon;
            BtnCambiarTema.IconColor = Color.Black;
            BtnCambiarTema.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnCambiarTema.IconSize = 30;
            BtnCambiarTema.Location = new Point(921, 20);
            BtnCambiarTema.Name = "BtnCambiarTema";
            BtnCambiarTema.Size = new Size(40, 40);
            BtnCambiarTema.TabIndex = 9;
            BtnCambiarTema.UseVisualStyleBackColor = true;
            BtnCambiarTema.Click += BtnSwitchTheme_Click;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Right;
            rjButton1.BackColor = Color.White;
            rjButton1.BackgroundColor = Color.White;
            rjButton1.BorderColor = Color.Black;
            rjButton1.BorderRadius = 10;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 12F);
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(801, 18);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(114, 40);
            rjButton1.TabIndex = 8;
            rjButton1.Text = "Ayuda";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            // 
            // rjButton2
            // 
            rjButton2.Anchor = AnchorStyles.Right;
            rjButton2.BackColor = Color.White;
            rjButton2.BackgroundColor = Color.White;
            rjButton2.BorderColor = Color.Black;
            rjButton2.BorderRadius = 10;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 12F);
            rjButton2.ForeColor = Color.Black;
            rjButton2.Location = new Point(645, 18);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(150, 40);
            rjButton2.TabIndex = 7;
            rjButton2.Text = "Notificaciones";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            // 
            // BtnSwitchTheme
            // 
            BtnSwitchTheme.Anchor = AnchorStyles.Right;
            BtnSwitchTheme.Cursor = Cursors.Hand;
            BtnSwitchTheme.FlatAppearance.BorderSize = 0;
            BtnSwitchTheme.FlatStyle = FlatStyle.Flat;
            BtnSwitchTheme.IconChar = FontAwesome.Sharp.IconChar.Moon;
            BtnSwitchTheme.IconColor = Color.Black;
            BtnSwitchTheme.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnSwitchTheme.IconSize = 30;
            BtnSwitchTheme.Location = new Point(1666, 7);
            BtnSwitchTheme.Name = "BtnSwitchTheme";
            BtnSwitchTheme.Size = new Size(40, 40);
            BtnSwitchTheme.TabIndex = 6;
            BtnSwitchTheme.UseVisualStyleBackColor = true;
            // 
            // BtnAyuda
            // 
            BtnAyuda.Anchor = AnchorStyles.Right;
            BtnAyuda.BackColor = Color.White;
            BtnAyuda.BackgroundColor = Color.White;
            BtnAyuda.BorderColor = Color.Black;
            BtnAyuda.BorderRadius = 10;
            BtnAyuda.BorderSize = 0;
            BtnAyuda.FlatAppearance.BorderSize = 0;
            BtnAyuda.FlatStyle = FlatStyle.Flat;
            BtnAyuda.Font = new Font("Segoe UI", 12F);
            BtnAyuda.ForeColor = Color.Black;
            BtnAyuda.Location = new Point(1546, 5);
            BtnAyuda.Name = "BtnAyuda";
            BtnAyuda.Size = new Size(114, 40);
            BtnAyuda.TabIndex = 5;
            BtnAyuda.Text = "Ayuda";
            BtnAyuda.TextColor = Color.Black;
            BtnAyuda.UseVisualStyleBackColor = false;
            // 
            // BtnNotificaciones
            // 
            BtnNotificaciones.Anchor = AnchorStyles.Right;
            BtnNotificaciones.BackColor = Color.White;
            BtnNotificaciones.BackgroundColor = Color.White;
            BtnNotificaciones.BorderColor = Color.Black;
            BtnNotificaciones.BorderRadius = 10;
            BtnNotificaciones.BorderSize = 0;
            BtnNotificaciones.FlatAppearance.BorderSize = 0;
            BtnNotificaciones.FlatStyle = FlatStyle.Flat;
            BtnNotificaciones.Font = new Font("Segoe UI", 12F);
            BtnNotificaciones.ForeColor = Color.Black;
            BtnNotificaciones.Location = new Point(1390, 5);
            BtnNotificaciones.Name = "BtnNotificaciones";
            BtnNotificaciones.Size = new Size(150, 40);
            BtnNotificaciones.TabIndex = 4;
            BtnNotificaciones.Text = "Notificaciones";
            BtnNotificaciones.TextColor = Color.Black;
            BtnNotificaciones.UseVisualStyleBackColor = false;
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel1.BorderRadius = 10;
            borderedPanel1.BorderSize = 1;
            borderedPanel1.Controls.Add(TxtBucarLibros);
            borderedPanel1.Controls.Add(iconPictureBox1);
            borderedPanel1.Location = new Point(6, 20);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Padding = new Padding(5);
            borderedPanel1.Size = new Size(528, 38);
            borderedPanel1.TabIndex = 3;
            // 
            // TxtBucarLibros
            // 
            TxtBucarLibros.BorderStyle = BorderStyle.None;
            TxtBucarLibros.Font = new Font("Segoe UI", 12F);
            TxtBucarLibros.Location = new Point(43, 8);
            TxtBucarLibros.Name = "TxtBucarLibros";
            TxtBucarLibros.PlaceholderText = "Buscar libros, autores, o generos";
            TxtBucarLibros.Size = new Size(442, 22);
            TxtBucarLibros.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.White;
            iconPictureBox1.Dock = DockStyle.Left;
            iconPictureBox1.ForeColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            iconPictureBox1.IconColor = Color.FromArgb(113, 113, 122);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 28;
            iconPictureBox1.Location = new Point(5, 5);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(32, 28);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // PanelCentral
            // 
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Location = new Point(289, 74);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(970, 704);
            PanelCentral.TabIndex = 5;
            // 
            // DocentesMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 778);
            Controls.Add(PanelCentral);
            Controls.Add(PanelTop);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DocentesMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VirtualBook";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargandoUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoUsuario).EndInit();
            panel10.ResumeLayout(false);
            PanelConfiguracion.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTop.ResumeLayout(false);
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel7;
        private Panel panel10;
        private Panel PanelConfiguracion;
        private FontAwesome.Sharp.IconButton BtnCerrarSesion;
        private FontAwesome.Sharp.IconButton BtnConfiguracion;
        private FontAwesome.Sharp.IconButton BtnMiperfil;
        private FontAwesome.Sharp.IconButton BtnVerLibros;
        private FontAwesome.Sharp.IconButton MostraMenuPrincipalForms;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel PanelTop;
        private FontAwesome.Sharp.IconButton BtnSwitchTheme;
        private Controls.RJButton BtnAyuda;
        private Controls.RJButton BtnNotificaciones;
        private Controls.BorderedPanel borderedPanel1;
        private TextBox TxtBucarLibros;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Panel PanelCentral;
        private FontAwesome.Sharp.IconButton BtnCambiarTema;
        private Controls.RJButton rjButton1;
        private Controls.RJButton rjButton2;
        private Panel panel2;
        private Label LblNombreUsuario;
        private Controls.RoundedPictureBox PcbFotoUsuario;
        private Label LblCorreoUsuario;
        private PictureBox PcbCargandoUser;
    }
}