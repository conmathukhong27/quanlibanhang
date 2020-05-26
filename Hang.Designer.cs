namespace quanlibanhang
{
    partial class Hang
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
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.cmbChatLieu = new System.Windows.Forms.ComboBox();
            this.GridViewDanhmuchang = new System.Windows.Forms.DataGridView();
            this.mahang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.lozz = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDanhmuchang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Hàng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(226, 13);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(100, 20);
            this.txtMaHang.TabIndex = 1;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(226, 33);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(100, 20);
            this.txtTenHang.TabIndex = 1;
            // 
            // cmbChatLieu
            // 
            this.cmbChatLieu.FormattingEnabled = true;
            this.cmbChatLieu.Location = new System.Drawing.Point(225, 60);
            this.cmbChatLieu.Name = "cmbChatLieu";
            this.cmbChatLieu.Size = new System.Drawing.Size(121, 21);
            this.cmbChatLieu.TabIndex = 2;
            // 
            // GridViewDanhmuchang
            // 
            this.GridViewDanhmuchang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewDanhmuchang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mahang,
            this.DonGiaNhap,
            this.DonGiaBan,
            this.GhiChu,
            this.MaChatLieu,
            this.SoLuong,
            this.tenhang});
            this.GridViewDanhmuchang.Location = new System.Drawing.Point(23, 106);
            this.GridViewDanhmuchang.Name = "GridViewDanhmuchang";
            this.GridViewDanhmuchang.Size = new System.Drawing.Size(742, 231);
            this.GridViewDanhmuchang.TabIndex = 3;
            // 
            // mahang
            // 
            this.mahang.DataPropertyName = "MaHang";
            this.mahang.HeaderText = "Mã Hàng";
            this.mahang.Name = "mahang";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn Giá";
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // DonGiaBan
            // 
            this.DonGiaBan.DataPropertyName = "DonGiaBan";
            this.DonGiaBan.HeaderText = "Đơn bán";
            this.DonGiaBan.Name = "DonGiaBan";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // MaChatLieu
            // 
            this.MaChatLieu.DataPropertyName = "MaChatLieu";
            this.MaChatLieu.HeaderText = "Mã chất liệu";
            this.MaChatLieu.Name = "MaChatLieu";
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // tenhang
            // 
            this.tenhang.DataPropertyName = "TenHang";
            this.tenhang.HeaderText = "Tên Hàng";
            this.tenhang.Name = "tenhang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chất Liệu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá Nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá Bán";
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Location = new System.Drawing.Point(420, 13);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(100, 20);
            this.txtGiaNhap.TabIndex = 1;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(420, 66);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 20);
            this.txtGiaBan.TabIndex = 1;
            // 
            // lozz
            // 
            this.lozz.AutoSize = true;
            this.lozz.Location = new System.Drawing.Point(352, 40);
            this.lozz.Name = "lozz";
            this.lozz.Size = new System.Drawing.Size(53, 13);
            this.lozz.TabIndex = 0;
            this.lozz.Text = "Số Lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(420, 40);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 20);
            this.txtSoLuong.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(48, 384);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(191, 384);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Lưu";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(330, 384);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Sửa";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(460, 384);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(588, 384);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(634, 10);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(100, 20);
            this.txtGhiChu.TabIndex = 1;
            // 
            // Hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.GridViewDanhmuchang);
            this.Controls.Add(this.cmbChatLieu);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lozz);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Hang";
            this.Text = "Hang";
            this.Load += new System.EventHandler(this.Hang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewDanhmuchang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.ComboBox cmbChatLieu;
        private System.Windows.Forms.DataGridView GridViewDanhmuchang;
        private System.Windows.Forms.DataGridViewTextBoxColumn mahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Label lozz;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}