namespace VirtualBook.Views.GeneralViews
{
    partial class NuevoAutorForm
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
            label1 = new Label();
            panel1 = new Panel();
            BtnCerrar = new Button();
            panel2 = new Panel();
            BtnGuardar = new VirtualBook.Controls.RJButton();
            borderedPanel1 = new VirtualBook.Controls.BorderedPanel();
            TxtNombreAutor = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            borderedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(153, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Autor:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 177, 155);
            panel1.Controls.Add(BtnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(453, 33);
            panel1.TabIndex = 1;
            // 
            // BtnCerrar
            // 
            BtnCerrar.FlatAppearance.BorderSize = 0;
            BtnCerrar.FlatStyle = FlatStyle.Flat;
            BtnCerrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnCerrar.ForeColor = Color.White;
            BtnCerrar.Location = new Point(405, 3);
            BtnCerrar.Name = "BtnCerrar";
            BtnCerrar.Size = new Size(36, 24);
            BtnCerrar.TabIndex = 0;
            BtnCerrar.Text = "X";
            BtnCerrar.UseVisualStyleBackColor = true;
            BtnCerrar.Click += BtnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(BtnGuardar);
            panel2.Controls.Add(borderedPanel1);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 103);
            panel2.TabIndex = 2;
            // 
            // BtnGuardar
            // 
            BtnGuardar.BackColor = Color.FromArgb(58, 177, 155);
            BtnGuardar.BackgroundColor = Color.FromArgb(58, 177, 155);
            BtnGuardar.BorderColor = Color.PaleVioletRed;
            BtnGuardar.BorderRadius = 5;
            BtnGuardar.BorderSize = 0;
            BtnGuardar.FlatAppearance.BorderSize = 0;
            BtnGuardar.FlatStyle = FlatStyle.Flat;
            BtnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnGuardar.ForeColor = Color.White;
            BtnGuardar.Location = new Point(306, 60);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(125, 31);
            BtnGuardar.TabIndex = 3;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.TextColor = Color.White;
            BtnGuardar.UseVisualStyleBackColor = false;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.DarkGray;
            borderedPanel1.BorderRadius = 10;
            borderedPanel1.BorderSize = 1;
            borderedPanel1.Controls.Add(TxtNombreAutor);
            borderedPanel1.Location = new Point(171, 17);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Size = new Size(260, 30);
            borderedPanel1.TabIndex = 2;
            // 
            // TxtNombreAutor
            // 
            TxtNombreAutor.BorderStyle = BorderStyle.None;
            TxtNombreAutor.Font = new Font("Segoe UI", 12F);
            TxtNombreAutor.Location = new Point(12, 5);
            TxtNombreAutor.Name = "TxtNombreAutor";
            TxtNombreAutor.PlaceholderText = "Ingrese el nombre del autor";
            TxtNombreAutor.Size = new Size(245, 22);
            TxtNombreAutor.TabIndex = 1;
            // 
            // NuevoAutorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 136);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoAutorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoAutorForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Controls.RJButton BtnGuardar;
        private Controls.BorderedPanel borderedPanel1;
        private TextBox TxtNombreAutor;
        private Button BtnCerrar;
    }
}