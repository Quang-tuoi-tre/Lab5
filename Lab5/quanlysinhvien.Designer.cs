
namespace Lab5
{
    partial class quanlysinhvien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlysinhvien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýKhoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.cmbkhoa = new System.Windows.Forms.ComboBox();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.tbdtb = new System.Windows.Forms.TextBox();
            this.tbht = new System.Windows.Forms.TextBox();
            this.tbmsv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.dgvsinhvien = new System.Windows.Forms.DataGridView();
            this.mssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyennganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chdangki = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(299, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý sinh viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ma sinh vien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ho ten";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khoa";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(943, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýKhoaToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // quảnLýKhoaToolStripMenuItem
            // 
            this.quảnLýKhoaToolStripMenuItem.Name = "quảnLýKhoaToolStripMenuItem";
            this.quảnLýKhoaToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.quảnLýKhoaToolStripMenuItem.Text = "Quản lý khoa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picAvatar);
            this.groupBox1.Controls.Add(this.cmbkhoa);
            this.groupBox1.Controls.Add(this.btnAvatar);
            this.groupBox1.Controls.Add(this.tbdtb);
            this.groupBox1.Controls.Add(this.tbht);
            this.groupBox1.Controls.Add(this.tbmsv);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // picAvatar
            // 
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picAvatar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picAvatar.ErrorImage")));
            this.picAvatar.Location = new System.Drawing.Point(139, 228);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(150, 129);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 7;
            this.picAvatar.TabStop = false;
            this.picAvatar.UseWaitCursor = true;
            this.picAvatar.Click += new System.EventHandler(this.picAvatar_Click);
            // 
            // cmbkhoa
            // 
            this.cmbkhoa.FormattingEnabled = true;
            this.cmbkhoa.Items.AddRange(new object[] {
            "Ngon Ngu Anh",
            "Quan Tri Kinh Doanh"});
            this.cmbkhoa.Location = new System.Drawing.Point(139, 114);
            this.cmbkhoa.Name = "cmbkhoa";
            this.cmbkhoa.Size = new System.Drawing.Size(140, 21);
            this.cmbkhoa.TabIndex = 6;
            this.cmbkhoa.Text = "Cong nghe thong tin";
            // 
            // btnAvatar
            // 
            this.btnAvatar.Location = new System.Drawing.Point(329, 287);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(55, 23);
            this.btnAvatar.TabIndex = 3;
            this.btnAvatar.Text = "...";
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // tbdtb
            // 
            this.tbdtb.Location = new System.Drawing.Point(139, 159);
            this.tbdtb.Name = "tbdtb";
            this.tbdtb.Size = new System.Drawing.Size(116, 20);
            this.tbdtb.TabIndex = 1;
            // 
            // tbht
            // 
            this.tbht.Location = new System.Drawing.Point(139, 79);
            this.tbht.Name = "tbht";
            this.tbht.Size = new System.Drawing.Size(116, 20);
            this.tbht.TabIndex = 1;
            // 
            // tbmsv
            // 
            this.tbmsv.Location = new System.Drawing.Point(139, 33);
            this.tbmsv.Name = "tbmsv";
            this.tbmsv.Size = new System.Drawing.Size(116, 20);
            this.tbmsv.TabIndex = 1;
            this.tbmsv.TextChanged += new System.EventHandler(this.tbmsv_TextChanged);
            this.tbmsv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbmsv_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ảnh đại diện";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Diem trung binh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(182, 572);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(87, 23);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Add/Update";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(307, 572);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(87, 23);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvsinhvien
            // 
            this.dgvsinhvien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvsinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mssv,
            this.hoten,
            this.khoa,
            this.dtb,
            this.chuyennganh});
            this.dgvsinhvien.Location = new System.Drawing.Point(436, 181);
            this.dgvsinhvien.Name = "dgvsinhvien";
            this.dgvsinhvien.Size = new System.Drawing.Size(476, 360);
            this.dgvsinhvien.TabIndex = 4;
            this.dgvsinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsinhvien_CellContentClick);
            // 
            // mssv
            // 
            this.mssv.HeaderText = "MSSV";
            this.mssv.Name = "mssv";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            this.hoten.Width = 120;
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
            // chuyennganh
            // 
            this.chuyennganh.HeaderText = "Chuyên ngành";
            this.chuyennganh.Name = "chuyennganh";
            this.chuyennganh.Width = 120;
            // 
            // chdangki
            // 
            this.chdangki.AutoSize = true;
            this.chdangki.Location = new System.Drawing.Point(734, 143);
            this.chdangki.Name = "chdangki";
            this.chdangki.Size = new System.Drawing.Size(160, 17);
            this.chdangki.TabIndex = 5;
            this.chdangki.Text = "Chưa ĐK chuyên ngành";
            this.chdangki.UseVisualStyleBackColor = true;
            this.chdangki.CheckedChanged += new System.EventHandler(this.chdangki_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // quanlysinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 636);
            this.Controls.Add(this.chdangki);
            this.Controls.Add(this.dgvsinhvien);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "quanlysinhvien";
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.quanlysinhvien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbkhoa;
        private System.Windows.Forms.TextBox tbdtb;
        private System.Windows.Forms.TextBox tbht;
        private System.Windows.Forms.TextBox tbmsv;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.DataGridView dgvsinhvien;
        private System.Windows.Forms.CheckBox chdangki;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem quảnLýKhoaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn mssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtb;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyennganh;
        private System.Windows.Forms.Button btnAvatar;
    }
}

