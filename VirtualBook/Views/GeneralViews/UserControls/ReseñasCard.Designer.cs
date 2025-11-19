namespace VirtualBook.Views.GeneralViews.UserControls
{
    partial class ReseñasCard
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            PcbFotoPerfilUsuario = new VirtualBook.Controls.RoundedPictureBox();
            lblNombreUsuario = new Label();
            lblComentario = new Label();
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfilUsuario).BeginInit();
            SuspendLayout();
            // 
            // PcbFotoPerfilUsuario
            // 
            PcbFotoPerfilUsuario.BackColor = Color.Transparent;
            PcbFotoPerfilUsuario.BorderColor = Color.Transparent;
            PcbFotoPerfilUsuario.BorderSize = 0;
            PcbFotoPerfilUsuario.Location = new Point(12, 3);
            PcbFotoPerfilUsuario.Name = "PcbFotoPerfilUsuario";
            PcbFotoPerfilUsuario.Size = new Size(30, 30);
            PcbFotoPerfilUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            PcbFotoPerfilUsuario.TabIndex = 25;
            PcbFotoPerfilUsuario.TabStop = false;
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreUsuario.Location = new Point(48, 18);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(59, 15);
            lblNombreUsuario.TabIndex = 26;
            lblNombreUsuario.Text = "Moises05";
            // 
            // lblComentario
            // 
            lblComentario.AutoSize = true;
            lblComentario.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComentario.Location = new Point(113, 18);
            lblComentario.Name = "lblComentario";
            lblComentario.Size = new Size(56, 15);
            lblComentario.TabIndex = 27;
            lblComentario.Text = "Moises05";
            // 
            // ReseñasCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(lblComentario);
            Controls.Add(lblNombreUsuario);
            Controls.Add(PcbFotoPerfilUsuario);
            Name = "ReseñasCard";
            Size = new Size(429, 45);
            ((System.ComponentModel.ISupportInitialize)PcbFotoPerfilUsuario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.RoundedPictureBox PcbFotoPerfilUsuario;
        private Label lblNombreUsuario;
        private Label lblComentario;
    }
}
