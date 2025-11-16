namespace VirtualBook.Views
{
    partial class MenuPrincipalFormcs
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
            pnlTabs = new Panel();
            btnRecommended = new Button();
            btnRecentlyViewed = new Button();
            btnBrowseBooks = new Button();
            flpLibros = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            PcbCargando = new PictureBox();
            pnlTabs.SuspendLayout();
            flpLibros.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PcbCargando).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(245, 25);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a Virtual Book";
            // 
            // pnlTabs
            // 
            pnlTabs.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlTabs.Controls.Add(btnRecommended);
            pnlTabs.Controls.Add(btnRecentlyViewed);
            pnlTabs.Controls.Add(btnBrowseBooks);
            pnlTabs.Location = new Point(31, 5);
            pnlTabs.Margin = new Padding(3, 2, 3, 2);
            pnlTabs.Name = "pnlTabs";
            pnlTabs.Size = new Size(382, 34);
            pnlTabs.TabIndex = 8;
            // 
            // btnRecommended
            // 
            btnRecommended.FlatAppearance.BorderSize = 0;
            btnRecommended.FlatStyle = FlatStyle.Flat;
            btnRecommended.Location = new Point(256, 2);
            btnRecommended.Margin = new Padding(3, 2, 3, 2);
            btnRecommended.Name = "btnRecommended";
            btnRecommended.Size = new Size(118, 29);
            btnRecommended.TabIndex = 2;
            btnRecommended.Text = "Recomendados";
            btnRecommended.UseVisualStyleBackColor = true;
            // 
            // btnRecentlyViewed
            // 
            btnRecentlyViewed.FlatAppearance.BorderSize = 0;
            btnRecentlyViewed.FlatStyle = FlatStyle.Flat;
            btnRecentlyViewed.Location = new Point(124, 2);
            btnRecentlyViewed.Margin = new Padding(3, 2, 3, 2);
            btnRecentlyViewed.Name = "btnRecentlyViewed";
            btnRecentlyViewed.Size = new Size(108, 30);
            btnRecentlyViewed.TabIndex = 1;
            btnRecentlyViewed.Text = "Vistos recien";
            btnRecentlyViewed.UseVisualStyleBackColor = true;
            // 
            // btnBrowseBooks
            // 
            btnBrowseBooks.FlatAppearance.BorderSize = 0;
            btnBrowseBooks.FlatStyle = FlatStyle.Flat;
            btnBrowseBooks.Location = new Point(3, 2);
            btnBrowseBooks.Margin = new Padding(3, 2, 3, 2);
            btnBrowseBooks.Name = "btnBrowseBooks";
            btnBrowseBooks.Size = new Size(108, 28);
            btnBrowseBooks.TabIndex = 0;
            btnBrowseBooks.Text = "Todos los libros";
            btnBrowseBooks.UseVisualStyleBackColor = true;
            // 
            // flpLibros
            // 
            flpLibros.AutoScroll = true;
            flpLibros.BackColor = Color.White;
            flpLibros.Controls.Add(PcbCargando);
            flpLibros.Dock = DockStyle.Fill;
            flpLibros.Location = new Point(0, 90);
            flpLibros.Margin = new Padding(3, 2, 3, 2);
            flpLibros.Name = "flpLibros";
            flpLibros.Size = new Size(967, 506);
            flpLibros.TabIndex = 6;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 42);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(pnlTabs);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(967, 48);
            panel2.TabIndex = 10;
            // 
            // PcbCargando
            // 
            PcbCargando.Image = Properties.Resources.LoadinScreen;
            PcbCargando.Location = new Point(3, 3);
            PcbCargando.Name = "PcbCargando";
            PcbCargando.Size = new Size(964, 503);
            PcbCargando.SizeMode = PictureBoxSizeMode.CenterImage;
            PcbCargando.TabIndex = 0;
            PcbCargando.TabStop = false;
            PcbCargando.Visible = false;
            // 
            // MenuPrincipalFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(967, 596);
            Controls.Add(flpLibros);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuPrincipalFormcs";
            Text = "MenuPrincipalFormcs";
            pnlTabs.ResumeLayout(false);
            flpLibros.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PcbCargando).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Panel pnlTabs;
        private Button btnRecommended;
        private Button btnRecentlyViewed;
        private Button btnBrowseBooks;
        private FlowLayoutPanel flpLibros;
        private Panel panel1;
        private Panel panel2;
        private PictureBox PcbCargando;
    }
}