namespace VirtualBook.Views
{
    partial class AdminFormUsers
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            borderedPanel1 = new Controls.BorderedPanel();
            borderedPanel2 = new Controls.BorderedPanel();
            roundedPictureBox2 = new Controls.RoundedPictureBox();
            lblusuariosregistrados = new Label();
            label7 = new Label();
            borderedPanel5 = new Controls.BorderedPanel();
            btnBuscar = new FontAwesome.Sharp.IconPictureBox();
            dgvUsuarios = new DataGridView();
            label2 = new Label();
            TxtBucarUsuarios = new TextBox();
            borderedPanel1.SuspendLayout();
            borderedPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox2).BeginInit();
            borderedPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // borderedPanel1
            // 
            borderedPanel1.BackColor = Color.White;
            borderedPanel1.BorderColor = Color.Black;
            borderedPanel1.BorderRadius = 20;
            borderedPanel1.BorderSize = 1;
            borderedPanel1.Controls.Add(borderedPanel2);
            borderedPanel1.Controls.Add(borderedPanel5);
            borderedPanel1.Controls.Add(dgvUsuarios);
            borderedPanel1.Controls.Add(label2);
            borderedPanel1.Dock = DockStyle.Fill;
            borderedPanel1.Location = new Point(40, 40);
            borderedPanel1.Name = "borderedPanel1";
            borderedPanel1.Padding = new Padding(5);
            borderedPanel1.Size = new Size(1060, 605);
            borderedPanel1.TabIndex = 0;
            // 
            // borderedPanel2
            // 
            borderedPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            borderedPanel2.BackColor = Color.White;
            borderedPanel2.BorderColor = Color.FromArgb(58, 177, 155);
            borderedPanel2.BorderRadius = 10;
            borderedPanel2.BorderSize = 2;
            borderedPanel2.Controls.Add(roundedPictureBox2);
            borderedPanel2.Controls.Add(lblusuariosregistrados);
            borderedPanel2.Controls.Add(label7);
            borderedPanel2.Location = new Point(818, 15);
            borderedPanel2.Name = "borderedPanel2";
            borderedPanel2.Padding = new Padding(3);
            borderedPanel2.Size = new Size(234, 71);
            borderedPanel2.TabIndex = 25;
            // 
            // roundedPictureBox2
            // 
            roundedPictureBox2.BackColor = Color.Transparent;
            roundedPictureBox2.BorderColor = Color.Gray;
            roundedPictureBox2.BorderSize = 0;
            roundedPictureBox2.Image = Properties.Resources.Imagen_de_WhatsApp_2025_06_05_a_las_20_01_46_ce0776e2;
            roundedPictureBox2.Location = new Point(177, 17);
            roundedPictureBox2.Margin = new Padding(3, 2, 3, 2);
            roundedPictureBox2.Name = "roundedPictureBox2";
            roundedPictureBox2.Size = new Size(42, 40);
            roundedPictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            roundedPictureBox2.TabIndex = 35;
            roundedPictureBox2.TabStop = false;
            // 
            // lblusuariosregistrados
            // 
            lblusuariosregistrados.AutoSize = true;
            lblusuariosregistrados.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuariosregistrados.Location = new Point(27, 34);
            lblusuariosregistrados.Name = "lblusuariosregistrados";
            lblusuariosregistrados.Size = new Size(52, 30);
            lblusuariosregistrados.TabIndex = 34;
            lblusuariosregistrados.Text = "000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(27, 13);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 33;
            label7.Text = "Usuarios registrados";
            // 
            // borderedPanel5
            // 
            borderedPanel5.BackColor = Color.White;
            borderedPanel5.BorderColor = Color.FromArgb(113, 113, 122);
            borderedPanel5.BorderRadius = 10;
            borderedPanel5.BorderSize = 1;
            borderedPanel5.Controls.Add(TxtBucarUsuarios);
            borderedPanel5.Controls.Add(btnBuscar);
            borderedPanel5.Location = new Point(18, 49);
            borderedPanel5.Name = "borderedPanel5";
            borderedPanel5.Padding = new Padding(5);
            borderedPanel5.Size = new Size(452, 38);
            borderedPanel5.TabIndex = 28;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.White;
            btnBuscar.Dock = DockStyle.Left;
            btnBuscar.ForeColor = Color.FromArgb(113, 113, 122);
            btnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnBuscar.IconColor = Color.FromArgb(113, 113, 122);
            btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBuscar.IconSize = 28;
            btnBuscar.Location = new Point(5, 5);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(32, 28);
            btnBuscar.TabIndex = 3;
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.BorderStyle = BorderStyle.None;
            dgvUsuarios.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(58, 177, 155);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuarios.EnableHeadersVisualStyles = false;
            dgvUsuarios.GridColor = Color.White;
            dgvUsuarios.Location = new Point(29, 110);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.ScrollBars = ScrollBars.None;
            dgvUsuarios.Size = new Size(994, 459);
            dgvUsuarios.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 15);
            label2.Name = "label2";
            label2.Size = new Size(219, 30);
            label2.TabIndex = 2;
            label2.Text = "Gestion de Usuarios";
            // 
            // TxtBucarUsuarios
            // 
            TxtBucarUsuarios.BorderStyle = BorderStyle.None;
            TxtBucarUsuarios.Font = new Font("Segoe UI", 12F);
            TxtBucarUsuarios.Location = new Point(42, 7);
            TxtBucarUsuarios.Name = "TxtBucarUsuarios";
            TxtBucarUsuarios.PlaceholderText = "Buscar usuarios, por nombre";
            TxtBucarUsuarios.Size = new Size(402, 22);
            TxtBucarUsuarios.TabIndex = 4;
            // 
            // AdminFormUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1140, 685);
            Controls.Add(borderedPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminFormUsers";
            Padding = new Padding(40);
            Text = "AdminFormUsers";
            Load += AdminFormUsers_Load;
            borderedPanel1.ResumeLayout(false);
            borderedPanel1.PerformLayout();
            borderedPanel2.ResumeLayout(false);
            borderedPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roundedPictureBox2).EndInit();
            borderedPanel5.ResumeLayout(false);
            borderedPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnBuscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Controls.BorderedPanel borderedPanel1;
        private Label label2;
        private DataGridView dgvUsuarios;
        private Controls.BorderedPanel borderedPanel2;
        private Controls.RoundedPictureBox roundedPictureBox2;
        private Label lblusuariosregistrados;
        private Label label7;
        private Controls.BorderedPanel borderedPanel5;
        private FontAwesome.Sharp.IconPictureBox btnBuscar;
        private TextBox TxtBucarUsuarios;
    }
}