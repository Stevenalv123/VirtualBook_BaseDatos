namespace VirtualBook.Views
{
    partial class FavoritosForm
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
            label2 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            flpLibros = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(177, 30);
            label1.TabIndex = 0;
            label1.Text = "MIS FAVORITOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(22, 51);
            label2.Name = "label2";
            label2.Size = new Size(483, 15);
            label2.TabIndex = 2;
            label2.Text = "Administra tus libros favoritos y accede rápidamente a tus materiales de lectura preferidos.";
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Heart;
            iconButton1.IconColor = Color.Red;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(22, 8);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(48, 40);
            iconButton1.TabIndex = 7;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(iconButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(925, 74);
            panel1.TabIndex = 7;
            // 
            // flpLibros
            // 
            flpLibros.Dock = DockStyle.Fill;
            flpLibros.Location = new Point(0, 74);
            flpLibros.Name = "flpLibros";
            flpLibros.Size = new Size(925, 347);
            flpLibros.TabIndex = 8;
            // 
            // FavoritosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(925, 421);
            Controls.Add(flpLibros);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FavoritosForm";
            Text = "FavoritosForm1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel1;
        private FlowLayoutPanel flpLibros;
    }
}