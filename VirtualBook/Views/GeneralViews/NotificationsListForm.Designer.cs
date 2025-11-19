namespace VirtualBook.Views.GeneralViews
{
    partial class NotificationsListForm
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
            panel1 = new Panel();
            BtnCerrar = new FontAwesome.Sharp.IconButton();
            DgvNotificaciones = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvNotificaciones).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 177, 155);
            panel1.Controls.Add(BtnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 46);
            panel1.TabIndex = 0;
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Close;
            BtnCerrar.IconColor = Color.Black;
            BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCerrar.Location = new Point(431, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(47, 32);
            BtnCerrar.TabIndex = 0;
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // DgvNotificaciones
            // 
            DgvNotificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvNotificaciones.Dock = DockStyle.Fill;
            DgvNotificaciones.Location = new Point(0, 46);
            DgvNotificaciones.Name = "DgvNotificaciones";
            DgvNotificaciones.Size = new Size(481, 186);
            DgvNotificaciones.TabIndex = 1;
            // 
            // NotificationsListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 232);
            Controls.Add(DgvNotificaciones);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NotificationsListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NotificationsListForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DgvNotificaciones).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private DataGridView DgvNotificaciones;
    }
}