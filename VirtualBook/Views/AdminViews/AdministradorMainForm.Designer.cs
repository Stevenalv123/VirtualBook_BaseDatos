namespace VirtualBook.Views.AdminViews
{
    partial class AdministradorMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorMainForm));
            panel1 = new Panel();
            panel7 = new Panel();
            PcbCargandoUser = new PictureBox();
            PcbPerfilFoto = new VirtualBook.Controls.RoundedPictureBox();
            LblCorreo = new Label();
            LblNombre = new Label();
            panel10 = new Panel();
            PanelConfiguracion = new Panel();
            BtnCerrarSesion = new FontAwesome.Sharp.IconButton();
            BtnConfiguracion = new FontAwesome.Sharp.IconButton();
            BtnVerUsuarios = new FontAwesome.Sharp.IconButton();
            BtnMostrarMainForm = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PcbFotoPerfil = new VirtualBook.Controls.RoundedPictureBox();
            PanelTop = new Panel();
            BtnCambiarTema = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            BtnSwitchTheme = new FontAwesome.Sharp.IconButton();
            PanelCentral = new Panel();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargandoUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbPerfilFoto).BeginInit();
            panel10.SuspendLayout();
            PanelConfiguracion.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).BeginInit();
            PanelTop.SuspendLayout();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 778);
            panel1.TabIndex = 0;
            panel1.Tag = "NoCambiarTema";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel7.Controls.Add(PcbCargandoUser);
            panel7.Controls.Add(PcbPerfilFoto);
            panel7.Controls.Add(LblCorreo);
            panel7.Controls.Add(LblNombre);
            panel7.Location = new Point(0, 705);
            panel7.Name = "panel7";
            panel7.Size = new Size(289, 73);
            panel7.TabIndex = 3;
            panel7.Tag = "NoCambiarTema";
            // 
            // PcbCargandoUser
            // 
            PcbCargandoUser.Image = Properties.Resources.skeletonAnimation;
            PcbCargandoUser.Location = new Point(0, -3);
            PcbCargandoUser.Name = "PcbCargandoUser";
            PcbCargandoUser.Size = new Size(283, 73);
            PcbCargandoUser.SizeMode = PictureBoxSizeMode.StretchImage;
            PcbCargandoUser.TabIndex = 7;
            PcbCargandoUser.TabStop = false;
            // 
            // PcbPerfilFoto
            // 
            PcbPerfilFoto.BackColor = Color.Transparent;
            PcbPerfilFoto.BorderColor = Color.Transparent;
            PcbPerfilFoto.BorderSize = 0;
            PcbPerfilFoto.Location = new Point(19, 11);
            PcbPerfilFoto.Name = "PcbPerfilFoto";
            PcbPerfilFoto.Size = new Size(50, 50);
            PcbPerfilFoto.SizeMode = PictureBoxSizeMode.Zoom;
            PcbPerfilFoto.TabIndex = 3;
            PcbPerfilFoto.TabStop = false;
            // 
            // LblCorreo
            // 
            LblCorreo.AutoSize = true;
            LblCorreo.Cursor = Cursors.Hand;
            LblCorreo.ForeColor = Color.White;
            LblCorreo.Location = new Point(75, 39);
            LblCorreo.Name = "LblCorreo";
            LblCorreo.Size = new Size(0, 15);
            LblCorreo.TabIndex = 2;
            // 
            // LblNombre
            // 
            LblNombre.AutoSize = true;
            LblNombre.Cursor = Cursors.Hand;
            LblNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            LblNombre.ForeColor = Color.White;
            LblNombre.Location = new Point(75, 18);
            LblNombre.Name = "LblNombre";
            LblNombre.Size = new Size(0, 21);
            LblNombre.TabIndex = 1;
            // 
            // panel10
            // 
            panel10.Controls.Add(PanelConfiguracion);
            panel10.Controls.Add(BtnConfiguracion);
            panel10.Controls.Add(BtnVerUsuarios);
            panel10.Controls.Add(BtnMostrarMainForm);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 127);
            panel10.Name = "panel10";
            panel10.Padding = new Padding(10, 0, 10, 0);
            panel10.Size = new Size(289, 582);
            panel10.TabIndex = 2;
            panel10.Tag = "NoCambiarTema";
            // 
            // PanelConfiguracion
            // 
            PanelConfiguracion.Controls.Add(BtnCerrarSesion);
            PanelConfiguracion.Dock = DockStyle.Top;
            PanelConfiguracion.Location = new Point(10, 150);
            PanelConfiguracion.Name = "PanelConfiguracion";
            PanelConfiguracion.Padding = new Padding(10, 0, 10, 0);
            PanelConfiguracion.Size = new Size(269, 123);
            PanelConfiguracion.TabIndex = 6;
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
            BtnConfiguracion.Location = new Point(10, 100);
            BtnConfiguracion.Margin = new Padding(3, 2, 3, 2);
            BtnConfiguracion.Name = "BtnConfiguracion";
            BtnConfiguracion.Padding = new Padding(20, 0, 32, 0);
            BtnConfiguracion.Size = new Size(269, 50);
            BtnConfiguracion.TabIndex = 5;
            BtnConfiguracion.Text = "Configuración";
            BtnConfiguracion.UseVisualStyleBackColor = true;
            BtnConfiguracion.Click += BtnConfiguracion_Click;
            // 
            // BtnVerUsuarios
            // 
            BtnVerUsuarios.Dock = DockStyle.Top;
            BtnVerUsuarios.FlatAppearance.BorderSize = 0;
            BtnVerUsuarios.FlatStyle = FlatStyle.Flat;
            BtnVerUsuarios.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnVerUsuarios.ForeColor = Color.White;
            BtnVerUsuarios.IconChar = FontAwesome.Sharp.IconChar.Users;
            BtnVerUsuarios.IconColor = Color.White;
            BtnVerUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVerUsuarios.IconSize = 32;
            BtnVerUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            BtnVerUsuarios.Location = new Point(10, 50);
            BtnVerUsuarios.Name = "BtnVerUsuarios";
            BtnVerUsuarios.Padding = new Padding(20, 0, 20, 0);
            BtnVerUsuarios.Size = new Size(269, 50);
            BtnVerUsuarios.TabIndex = 2;
            BtnVerUsuarios.Text = "Ver Usuarios";
            BtnVerUsuarios.UseVisualStyleBackColor = true;
            BtnVerUsuarios.Click += BtnVerUsuarios_Click;
            // 
            // BtnMostrarMainForm
            // 
            BtnMostrarMainForm.Dock = DockStyle.Top;
            BtnMostrarMainForm.FlatAppearance.BorderSize = 0;
            BtnMostrarMainForm.FlatStyle = FlatStyle.Flat;
            BtnMostrarMainForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            BtnMostrarMainForm.ForeColor = Color.White;
            BtnMostrarMainForm.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnMostrarMainForm.IconColor = Color.White;
            BtnMostrarMainForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnMostrarMainForm.IconSize = 32;
            BtnMostrarMainForm.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMostrarMainForm.Location = new Point(10, 0);
            BtnMostrarMainForm.Margin = new Padding(3, 3, 3, 10);
            BtnMostrarMainForm.Name = "BtnMostrarMainForm";
            BtnMostrarMainForm.Padding = new Padding(20, 0, 20, 0);
            BtnMostrarMainForm.Size = new Size(269, 50);
            BtnMostrarMainForm.TabIndex = 0;
            BtnMostrarMainForm.Text = "Ver libros";
            BtnMostrarMainForm.UseVisualStyleBackColor = true;
            BtnMostrarMainForm.Click += MostraMenuPrincipalForms_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(58, 177, 155);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(pictureBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 127);
            panel5.TabIndex = 1;
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
            // PcbFotoPerfil
            // 
            PcbFotoPerfil.BackColor = Color.Transparent;
            PcbFotoPerfil.BorderColor = Color.Gray;
            PcbFotoPerfil.BorderSize = 2;
            PcbFotoPerfil.Location = new Point(0, 0);
            PcbFotoPerfil.Name = "PcbFotoPerfil";
            PcbFotoPerfil.Size = new Size(100, 50);
            PcbFotoPerfil.SizeMode = PictureBoxSizeMode.Zoom;
            PcbFotoPerfil.TabIndex = 0;
            PcbFotoPerfil.TabStop = false;
            // 
            // PanelTop
            // 
            PanelTop.BackColor = Color.White;
            PanelTop.Controls.Add(BtnCambiarTema);
            PanelTop.Controls.Add(label2);
            PanelTop.Controls.Add(BtnSwitchTheme);
            PanelTop.Dock = DockStyle.Top;
            PanelTop.Location = new Point(289, 0);
            PanelTop.Name = "PanelTop";
            PanelTop.Size = new Size(970, 68);
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
            BtnCambiarTema.Location = new Point(911, 14);
            BtnCambiarTema.Name = "BtnCambiarTema";
            BtnCambiarTema.Size = new Size(40, 40);
            BtnCambiarTema.TabIndex = 11;
            BtnCambiarTema.UseVisualStyleBackColor = true;
            BtnCambiarTema.Click += BtnCambiarTema_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(6, 20);
            label2.Name = "label2";
            label2.Size = new Size(288, 32);
            label2.TabIndex = 8;
            label2.Text = "Menú de Administrador";
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
            BtnSwitchTheme.Location = new Point(1666, 4);
            BtnSwitchTheme.Name = "BtnSwitchTheme";
            BtnSwitchTheme.Size = new Size(40, 40);
            BtnSwitchTheme.TabIndex = 6;
            BtnSwitchTheme.UseVisualStyleBackColor = true;
            // 
            // PanelCentral
            // 
            PanelCentral.Dock = DockStyle.Fill;
            PanelCentral.Location = new Point(289, 68);
            PanelCentral.Name = "PanelCentral";
            PanelCentral.Size = new Size(970, 710);
            PanelCentral.TabIndex = 3;
            // 
            // AdministradorMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1259, 778);
            Controls.Add(PanelCentral);
            Controls.Add(PanelTop);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AdministradorMainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VirtualBook";
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargandoUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbPerfilFoto).EndInit();
            panel10.ResumeLayout(false);
            PanelConfiguracion.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfil).EndInit();
            PanelTop.ResumeLayout(false);
            PanelTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel10;
        private FontAwesome.Sharp.IconButton BtnVerUsuarios;
        private FontAwesome.Sharp.IconButton BtnMostrarMainForm;
        private Panel panel7;
        private Controls.RoundedPictureBox PcbFotoPerfil;
        private Label LblCorreo;
        private Label LblNombre;
        private Panel PanelTop;
        private FontAwesome.Sharp.IconButton BtnSwitchTheme;
        private Controls.RJButton BtnAyuda;
        private Controls.RJButton BtnNotificaciones;
        private Label label2;
        private Panel PanelCentral;
        private PictureBox PcbCargandoUser;
        private FontAwesome.Sharp.IconButton BtnConfiguracion;
        private Panel PanelConfiguracion;
        private FontAwesome.Sharp.IconButton BtnCerrarSesion;
        private FontAwesome.Sharp.IconButton BtnCambiarTema;
        private Controls.RJButton rjButton1;
        private Controls.RJButton rjButton2;
        private Controls.RoundedPictureBox PcbPerfilFoto;
    }
}