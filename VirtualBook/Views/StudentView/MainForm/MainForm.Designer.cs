namespace VirtualBook.Views
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panel7 = new Panel();
            PcbCargandoUser = new PictureBox();
            PcbFotoPerfil = new VirtualBook.Controls.RoundedPictureBox();
            LblCorreo = new Label();
            LblNombre = new Label();
            panel10 = new Panel();
            PanelConfiguracion = new Panel();
            BtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            BtnConfiguracion = new FontAwesome.Sharp.IconButton();
            BtnMiperfil = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            MostraMenuPrincipalForms = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PanelTop = new Panel();
            BtnNotificaciones = new FontAwesome.Sharp.IconButton();
            BtnSwitchTheme = new FontAwesome.Sharp.IconButton();
            BtnAyuda = new VirtualBook.Controls.RJButton();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            TxtBucarLibros = new TextBox();
            btnBuscarlibro = new FontAwesome.Sharp.IconPictureBox();
            LblDerechosReservados = new Label();
            PanelBottom = new Panel();
            PanelCentral = new Panel();
            tmrNotificaciones = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargandoUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).BeginInit();
            panel10.SuspendLayout();
            PanelConfiguracion.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelTop.SuspendLayout();
            borderedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarlibro).BeginInit();
            PanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 177, 155);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(panel5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(330, 1037);
            panel1.TabIndex = 0;
            panel1.Tag = "NoCambiarTema";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.Controls.Add(PcbCargandoUser);
            panel7.Controls.Add(PcbFotoPerfil);
            panel7.Controls.Add(LblCorreo);
            panel7.Controls.Add(LblNombre);
            panel7.Location = new Point(0, 940);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(330, 97);
            panel7.TabIndex = 2;
            panel7.Tag = "NoCambiarTema";
            // 
            // PcbCargandoUser
            // 
            PcbCargandoUser.Image = Properties.Resources.skeletonAnimation;
            PcbCargandoUser.Location = new Point(7, 0);
            PcbCargandoUser.Margin = new Padding(3, 4, 3, 4);
            PcbCargandoUser.Name = "PcbCargandoUser";
            PcbCargandoUser.Size = new Size(323, 97);
            PcbCargandoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbCargandoUser.TabIndex = 6;
            PcbCargandoUser.TabStop = false;
            // 
            // PcbFotoPerfil
            // 
            PcbFotoPerfil.BackColor = Color.Transparent;
            PcbFotoPerfil.BorderColor = Color.Transparent;
            PcbFotoPerfil.BorderSize = 0;
            PcbFotoPerfil.Cursor = Cursors.Hand;
            PcbFotoPerfil.Image = Properties.Resources.user;
            PcbFotoPerfil.Location = new Point(19, 23);
            PcbFotoPerfil.Name = "PcbFotoPerfil";
            PcbFotoPerfil.Size = new Size(57, 67);
            PcbFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            PcbFotoPerfil.TabIndex = 4;
            PcbFotoPerfil.TabStop = false;
            PcbFotoPerfil.Click += PcbFotoPerfil_Click;
            // 
            // LblCorreo
            // 
            LblCorreo.AutoSize = true;
            LblCorreo.Cursor = Cursors.Hand;
            LblCorreo.ForeColor = Color.White;
            LblCorreo.Location = new Point(86, 52);
            LblCorreo.Name = "LblCorreo";
            LblCorreo.Size = new Size(0, 20);
            LblCorreo.TabIndex = 2;
            LblCorreo.Click += LblStudentId_Click;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Cursor = Cursors.Hand;
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblNombre.ForeColor = Color.White;
            LblNombre.Location = new Point(86, 24);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(0, 28);
            LblNombre.TabIndex = 1;
            LblNombre.Click += LblNombre_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(PanelConfiguracion);
            panel10.Controls.Add(BtnConfiguracion);
            panel10.Controls.Add(BtnMiperfil);
            panel10.Controls.Add(iconButton3);
            panel10.Controls.Add(MostraMenuPrincipalForms);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 169);
            panel10.Margin = new Padding(3, 4, 3, 4);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(11, 0, 11, 0);
            panel10.Size = new Size(330, 776);
            panel10.TabIndex = 1;
            panel10.Tag = "NoCambiarTema";
            // 
            // PanelConfiguracion
            // 
            PanelConfiguracion.Controls.Add(BtnCerrarSesion);
            PanelConfiguracion.Dock = DockStyle.Top;
            PanelConfiguracion.Location = new Point(11, 268);
            PanelConfiguracion.Margin = new Padding(3, 4, 3, 4);
            PanelConfiguracion.Name = "PanelConfiguracion";
            PanelConfiguracion.Padding = new Padding(11, 0, 11, 0);
            PanelConfiguracion.Size = new Size(308, 164);
            PanelConfiguracion.TabIndex = 5;
            PanelConfiguracion.Visible = false;
            // 
            // BtnCerrarSesion
            // 
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
            BtnCerrarSesion.Location = new Point(11, 0);
            BtnCerrarSesion.Name = "BtnCerrarSesion";
            BtnCerrarSesion.Padding = new Padding(23, 0, 37, 0);
            BtnCerrarSesion.Size = new Size(286, 67);
            BtnCerrarSesion.TabIndex = 4;
            BtnCerrarSesion.Text = "Cerrar Sesión";
            BtnCerrarSesion.UseVisualStyleBackColor = true;
            BtnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // BtnConfiguracion
            // 
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
            BtnConfiguracion.Location = new Point(11, 201);
            BtnConfiguracion.Name = "BtnConfiguracion";
            BtnConfiguracion.Padding = new Padding(23, 0, 37, 0);
            BtnConfiguracion.Size = new Size(308, 67);
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
            BtnMiperfil.Location = new Point(11, 134);
            BtnMiperfil.Name = "BtnMiperfil";
            BtnMiperfil.Padding = new Padding(23, 0, 82, 0);
            BtnMiperfil.Size = new Size(308, 67);
            BtnMiperfil.TabIndex = 3;
            BtnMiperfil.Text = "Mi perfil";
            BtnMiperfil.UseVisualStyleBackColor = true;
            BtnMiperfil.Click += BtnMiperfil_Click;
            // 
            // iconButton3
            // 
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            iconButton3.ForeColor = Color.White;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            iconButton3.IconColor = Color.White;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 32;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(11, 67);
            iconButton3.Name = "iconButton3";
            iconButton3.Padding = new Padding(23, 0, 40, 0);
            iconButton3.Size = new Size(308, 67);
            iconButton3.TabIndex = 2;
            iconButton3.Text = "Mis favoritos";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
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
            MostraMenuPrincipalForms.Location = new Point(11, 0);
            MostraMenuPrincipalForms.Margin = new Padding(3, 4, 3, 13);
            MostraMenuPrincipalForms.Name = "MostraMenuPrincipalForms";
            MostraMenuPrincipalForms.Padding = new Padding(23, 0, 23, 0);
            MostraMenuPrincipalForms.Size = new Size(308, 67);
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
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(330, 169);
            panel5.TabIndex = 0;
            panel5.Tag = "NoCambiarTema";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 35);
            label1.Name = "label1";
            label1.Size = new Size(222, 46);
            label1.TabIndex = 1;
            label1.Text = "Virtual Book";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.White;
            PanelTop.Controls.Add(BtnNotificaciones);
            PanelTop.Controls.Add(BtnSwitchTheme);
            PanelTop.Controls.Add(BtnAyuda);
            PanelTop.Controls.Add(borderedPanel1);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(330, 0);
            PanelTop.Margin = new Padding(3, 4, 3, 4);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(1109, 99);
            PanelTop.TabIndex = 1;
            // 
            // BtnNotificaciones
            // 
            BtnNotificaciones.Anchor = AnchorStyles.Right;
            BtnNotificaciones.FlatAppearance.BorderSize = 0;
            BtnNotificaciones.FlatStyle = FlatStyle.Flat;
            BtnNotificaciones.Font = new Font("Segoe UI", 12F);
            BtnNotificaciones.IconChar = FontAwesome.Sharp.IconChar.Bell;
            BtnNotificaciones.IconColor = Color.Black;
            BtnNotificaciones.IconFont = FontAwesome.Sharp.IconFont.Regular;
            BtnNotificaciones.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNotificaciones.Location = new Point(693, 16);
            BtnNotificaciones.Margin = new Padding(3, 4, 3, 4);
            BtnNotificaciones.Name = "BtnNotificaciones";
            BtnNotificaciones.Size = new Size(187, 65);
            BtnNotificaciones.TabIndex = 7;
            BtnNotificaciones.Text = "Notificaciones";
            BtnNotificaciones.TextAlign = ContentAlignment.MiddleRight;
            BtnNotificaciones.UseVisualStyleBackColor = true;
            BtnNotificaciones.Click += BtnNotificaciones_Click_1;
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
            BtnSwitchTheme.Location = new Point(971, 28);
            BtnSwitchTheme.Margin = new Padding(3, 4, 3, 4);
            BtnSwitchTheme.Name = "BtnSwitchTheme";
            BtnSwitchTheme.Size = new Size(46, 53);
            BtnSwitchTheme.TabIndex = 6;
            BtnSwitchTheme.UseVisualStyleBackColor = true;
            BtnSwitchTheme.Click += BtnSwitchTheme_Click;
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
            BtnAyuda.Location = new Point(887, 24);
            BtnAyuda.Margin = new Padding(3, 4, 3, 4);
            BtnAyuda.Name = "BtnAyuda";
            BtnAyuda.Size = new Size(130, 53);
            BtnAyuda.TabIndex = 5;
            BtnAyuda.Text = "Ayuda";
            BtnAyuda.TextColor = Color.Black;
            BtnAyuda.UseVisualStyleBackColor = false;
            BtnAyuda.Visible = false;
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel1.BorderRadius = 10;
            borderedPanel1.BorderSize = 1;
            borderedPanel1.Controls.Add(TxtBucarLibros);
            borderedPanel1.Controls.Add(btnBuscarlibro);
            borderedPanel1.Location = new Point(7, 27);
            borderedPanel1.Margin = new Padding(3, 4, 3, 4);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Padding = new Padding(6, 7, 6, 7);
            borderedPanel1.Size = new Size(603, 51);
            borderedPanel1.TabIndex = 3;
            // 
            // TxtBucarLibros
            // 
            TxtBucarLibros.BorderStyle = BorderStyle.None;
            TxtBucarLibros.Font = new Font("Segoe UI", 12F);
            TxtBucarLibros.Location = new Point(49, 11);
            TxtBucarLibros.Margin = new Padding(3, 4, 3, 4);
            TxtBucarLibros.Name = "TxtBucarLibros";
            TxtBucarLibros.PlaceholderText = "Buscar libros, autores, o generos";
            TxtBucarLibros.Size = new Size(505, 27);
            TxtBucarLibros.TabIndex = 1;
            TxtBucarLibros.TextChanged += TxtBucarLibros_TextChanged;
            // 
            // btnBuscarlibro
            // 
            btnBuscarlibro.BackColor = Color.White;
            btnBuscarlibro.Dock = DockStyle.Left;
            btnBuscarlibro.ForeColor = Color.FromArgb(113, 113, 122);
            btnBuscarlibro.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscarlibro.IconColor = Color.FromArgb(113, 113, 122);
            btnBuscarlibro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscarlibro.IconSize = 37;
            btnBuscarlibro.Location = new Point(6, 7);
            btnBuscarlibro.Margin = new Padding(3, 4, 3, 4);
            btnBuscarlibro.Name = "btnBuscarlibro";
            btnBuscarlibro.Size = new Size(37, 37);
            btnBuscarlibro.TabIndex = 2;
            btnBuscarlibro.TabStop = false;
            btnBuscarlibro.Click += btnBuscarlibro_Click;
            // 
            // LblDerechosReservados
            // 
            LblDerechosReservados.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LblDerechosReservados.AutoSize = true;
            LblDerechosReservados.ForeColor = Color.FromArgb(113, 113, 122);
            LblDerechosReservados.Location = new Point(458, 16);
            LblDerechosReservados.Name = "LblDerechosReservados";
            LblDerechosReservados.Size = new Size(319, 20);
            LblDerechosReservados.TabIndex = 0;
            LblDerechosReservados.Text = "© 2025 VirtualBook System. All rights reserved.";
            // 
            // PanelBottom
            // 
            PanelBottom.Controls.Add(LblDerechosReservados);
            PanelBottom.Dock = DockStyle.Bottom;
            PanelBottom.Location = new Point(330, 992);
            PanelBottom.Margin = new Padding(3, 4, 3, 4);
            PanelBottom.Name = "PanelBottom";
            PanelBottom.Size = new Size(1109, 45);
            PanelBottom.TabIndex = 3;
            // 
            // PanelCentral
            // 
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Location = new Point(330, 99);
            PanelCentral.Margin = new Padding(3, 4, 3, 4);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(1109, 893);
            PanelCentral.TabIndex = 4;
            // 
            // tmrNotificaciones
            // 
            tmrNotificaciones.Enabled = true;
            tmrNotificaciones.Interval = 5000;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1439, 1037);
            Controls.Add(PanelCentral);
            Controls.Add(PanelBottom);
            Controls.Add(PanelTop);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VirtualBook";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            Resize += MainForm_Resize;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargandoUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).EndInit();
            panel10.ResumeLayout(false);
            PanelConfiguracion.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelTop.ResumeLayout(false);
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscarlibro).EndInit();
            PanelBottom.ResumeLayout(false);
            PanelBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel PanelTop;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel7;
        private Panel panel10;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton MostraMenuPrincipalForms;
        private FontAwesome.Sharp.IconButton BtnMiperfil;
        private Label LblCorreo;
        private Label LblNombre;
        private TextBox TxtBucarLibros;
        private Label LblDerechosReservados;
        private Panel PanelBottom;
        private Panel PanelCentral;
        private Controls.RoundedPictureBox PcbFotoPerfil;
        private Controls.BorderedPanel borderedPanel1;
        private FontAwesome.Sharp.IconPictureBox btnBuscarlibro;
        private Controls.RJButton BtnAyuda;
        private FontAwesome.Sharp.IconButton BtnSwitchTheme;
        private Panel PanelConfiguracion;
        private FontAwesome.Sharp.IconButton BtnCerrarSesion;
        private FontAwesome.Sharp.IconButton BtnConfiguracion;
        private PictureBox PcbCargandoUser;
        private System.Windows.Forms.Timer tmrNotificaciones;
        private FontAwesome.Sharp.IconButton BtnNotificaciones;
    }
}