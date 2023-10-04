
namespace Lab5
{
    partial class timkiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvchuyennganh = new System.Windows.Forms.DataGridView();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.cmbchuyennganh = new System.Windows.Forms.ComboBox();
            this.btndangky = new System.Windows.Forms.Button();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvchuyennganh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(144, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký chuyên ngành";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyên ngành";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dgvchuyennganh
            // 
            this.dgvchuyennganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvchuyennganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.mssv,
            this.hoten,
            this.khoa,
            this.dtb});
            this.dgvchuyennganh.Location = new System.Drawing.Point(24, 190);
            this.dgvchuyennganh.Name = "dgvchuyennganh";
            this.dgvchuyennganh.Size = new System.Drawing.Size(718, 317);
            this.dgvchuyennganh.TabIndex = 1;
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Items.AddRange(new object[] {
            "Cong nghe thong tin",
            "Quan Tri Kinh Doanh"});
            this.cmbkhoa.Location = new System.Drawing.Point(259, 104);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(375, 21);
            this.cmbkhoa.TabIndex = 2;
            this.cmbkhoa.Text = "Ngon Ngu Anh";
            // 
            // cmbchuyennganh
            // 
            this.cmbchuyennganh.FormattingEnabled = true;
            this.cmbchuyennganh.Items.AddRange(new object[] {
            "Công nghệ phầm mềm",
            "Hệ thống thông tin",
            "Tiếng Anh Truyền Thông",
            "An toàn thông tin"});
            this.cmbchuyennganh.Location = new System.Drawing.Point(259, 155);
            this.cmbchuyennganh.Name = "cmbchuyennganh";
            this.cmbchuyennganh.Size = new System.Drawing.Size(375, 21);
            this.cmbchuyennganh.TabIndex = 2;
            this.cmbchuyennganh.Text = "Tieng Anh Thuong Mai";
            // 
            // btndangky
            // 
            this.btndangky.Location = new System.Drawing.Point(112, 538);
            this.btndangky.Name = "btndangky";
            this.btndangky.Size = new System.Drawing.Size(75, 23);
            this.btndangky.TabIndex = 3;
            this.btndangky.Text = "Register";
            this.btndangky.UseVisualStyleBackColor = true;
            this.btndangky.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            // 
            // mssv
            // 
            this.mssv.HeaderText = "MSSV";
            this.mssv.Name = "mssv";
            this.mssv.Width = 150;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            this.hoten.Width = 200;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "Khoa";
            this.khoa.Name = "khoa";
            this.khoa.Width = 120;
            // 
            // dtb
            // 
            this.dtb.HeaderText = "DTB";
            this.dtb.Name = "dtb";
            // 
            // timkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 588);
            this.Controls.Add(this.btndangky);
            this.Controls.Add(this.cmbchuyennganh);
            this.Controls.Add(this.cmbkhoa);
            this.Controls.Add(this.dgvchuyennganh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "timkiem";
            this.Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.dgvchuyennganh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvchuyennganh;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.ComboBox cmbchuyennganh;
        private System.Windows.Forms.Button btndangky;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
    }
}