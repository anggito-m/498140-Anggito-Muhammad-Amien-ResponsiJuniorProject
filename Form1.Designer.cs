namespace Responsi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dgvKaryawan = new DataGridView();
            btnLoad = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            cbDepartemen = new ComboBox();
            txtName = new TextBox();
            label5 = new Label();
            label2 = new Label();
            idDepartemen = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvKaryawan
            // 
            dgvKaryawan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKaryawan.Location = new Point(37, 271);
            dgvKaryawan.Margin = new Padding(3, 2, 3, 2);
            dgvKaryawan.Name = "dgvKaryawan";
            dgvKaryawan.RowHeadersWidth = 51;
            dgvKaryawan.Size = new Size(533, 170);
            dgvKaryawan.TabIndex = 43;
            dgvKaryawan.CellClick += dgvKaryawan_CellClick;
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Cyan;
            btnLoad.Location = new Point(464, 461);
            btnLoad.Margin = new Padding(3, 2, 3, 2);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(106, 31);
            btnLoad.TabIndex = 41;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Location = new Point(464, 209);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 44);
            btnDelete.TabIndex = 40;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(128, 128, 255);
            btnUpdate.Location = new Point(258, 209);
            btnUpdate.Margin = new Padding(3, 2, 3, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(105, 44);
            btnUpdate.TabIndex = 39;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(128, 255, 128);
            btnInsert.Location = new Point(37, 209);
            btnInsert.Margin = new Padding(3, 2, 3, 2);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(104, 44);
            btnInsert.TabIndex = 38;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // cbDepartemen
            // 
            cbDepartemen.FormattingEnabled = true;
            cbDepartemen.Items.AddRange(new object[] { "HR", "ENG", "DEV", "PM", "FIN" });
            cbDepartemen.Location = new Point(173, 176);
            cbDepartemen.Margin = new Padding(3, 2, 3, 2);
            cbDepartemen.Name = "cbDepartemen";
            cbDepartemen.Size = new Size(164, 23);
            cbDepartemen.TabIndex = 37;
            // 
            // txtName
            // 
            txtName.Location = new Point(173, 132);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(164, 23);
            txtName.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 176);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 33;
            label5.Text = "Departemen";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 135);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 30;
            label2.Text = "Nama";
            // 
            // idDepartemen
            // 
            idDepartemen.FormattingEnabled = true;
            idDepartemen.ItemHeight = 15;
            idDepartemen.Items.AddRange(new object[] { "ID Departemen:", "HR: HR", "ENG: Engineer", "DEV: Developer", "PM: Product Manager", "FIN: Finance" });
            idDepartemen.Location = new Point(433, 30);
            idDepartemen.Name = "idDepartemen";
            idDepartemen.Size = new Size(137, 169);
            idDepartemen.TabIndex = 44;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 503);
            Controls.Add(pictureBox1);
            Controls.Add(idDepartemen);
            Controls.Add(dgvKaryawan);
            Controls.Add(btnLoad);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(cbDepartemen);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKaryawan).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvKaryawan;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        public ComboBox cbDepartemen;
        public TextBox txtName;
        private Label label5;
        private Label label2;
        private ListBox idDepartemen;
        private PictureBox pictureBox1;
    }
}
