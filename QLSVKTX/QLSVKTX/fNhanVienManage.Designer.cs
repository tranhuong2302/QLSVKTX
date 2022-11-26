namespace QLSVKTX
{
    partial class fNhanVienManage
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
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbChucVu = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.btnAddNhanVien = new System.Windows.Forms.Button();
            this.dtgvNhanVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCCCD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEditNhanVien = new System.Windows.Forms.Button();
            this.btnDeleteNhanVien = new System.Windows.Forms.Button();
            this.btnListNhanVien = new System.Windows.Forms.Button();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.btnSearchNhanVienByHoTen = new System.Windows.Forms.Button();
            this.txbSearchHoTen = new System.Windows.Forms.TextBox();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(272, 47);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(100, 22);
            this.txbHoTen.TabIndex = 1;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(463, 44);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(114, 22);
            this.dtpNgaySinh.TabIndex = 2;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 11, 21, 9, 9, 29, 0);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(831, 50);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txbDiaChi.TabIndex = 3;
            // 
            // txbChucVu
            // 
            this.txbChucVu.Location = new System.Drawing.Point(109, 170);
            this.txbChucVu.Name = "txbChucVu";
            this.txbChucVu.Size = new System.Drawing.Size(100, 22);
            this.txbChucVu.TabIndex = 4;
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(629, 50);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(100, 22);
            this.txbSDT.TabIndex = 5;
            // 
            // btnAddNhanVien
            // 
            this.btnAddNhanVien.Location = new System.Drawing.Point(30, 89);
            this.btnAddNhanVien.Name = "btnAddNhanVien";
            this.btnAddNhanVien.Size = new System.Drawing.Size(130, 51);
            this.btnAddNhanVien.TabIndex = 6;
            this.btnAddNhanVien.Text = "Thêm nhân viên";
            this.btnAddNhanVien.UseVisualStyleBackColor = true;
            this.btnAddNhanVien.Click += new System.EventHandler(this.btnAddNhanVien_Click);
            // 
            // dtgvNhanVien
            // 
            this.dtgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvNhanVien.Location = new System.Drawing.Point(12, 245);
            this.dtgvNhanVien.Name = "dtgvNhanVien";
            this.dtgvNhanVien.RowHeadersWidth = 51;
            this.dtgvNhanVien.RowTemplate.Height = 24;
            this.dtgvNhanVien.Size = new System.Drawing.Size(1468, 224);
            this.dtgvNhanVien.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "manv";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "hoten";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "ngaysinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "sdt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(762, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "diachi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(963, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "gioitinh";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(1018, 50);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbGioiTinh.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1161, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "cmnd/cccd";
            // 
            // txbCCCD
            // 
            this.txbCCCD.Location = new System.Drawing.Point(1260, 56);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(100, 22);
            this.txbCCCD.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "chucvu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "trang thai";
            // 
            // btnEditNhanVien
            // 
            this.btnEditNhanVien.Location = new System.Drawing.Point(194, 89);
            this.btnEditNhanVien.Name = "btnEditNhanVien";
            this.btnEditNhanVien.Size = new System.Drawing.Size(130, 51);
            this.btnEditNhanVien.TabIndex = 20;
            this.btnEditNhanVien.Text = "Sửa";
            this.btnEditNhanVien.UseVisualStyleBackColor = true;
            this.btnEditNhanVien.Click += new System.EventHandler(this.btnEditNhanVien_Click);
            // 
            // btnDeleteNhanVien
            // 
            this.btnDeleteNhanVien.Location = new System.Drawing.Point(354, 89);
            this.btnDeleteNhanVien.Name = "btnDeleteNhanVien";
            this.btnDeleteNhanVien.Size = new System.Drawing.Size(130, 51);
            this.btnDeleteNhanVien.TabIndex = 21;
            this.btnDeleteNhanVien.Text = "Xóa";
            this.btnDeleteNhanVien.UseVisualStyleBackColor = true;
            this.btnDeleteNhanVien.Click += new System.EventHandler(this.btnDeleteNhanVien_Click);
            // 
            // btnListNhanVien
            // 
            this.btnListNhanVien.Location = new System.Drawing.Point(517, 89);
            this.btnListNhanVien.Name = "btnListNhanVien";
            this.btnListNhanVien.Size = new System.Drawing.Size(130, 51);
            this.btnListNhanVien.TabIndex = 22;
            this.btnListNhanVien.Text = "Xem";
            this.btnListNhanVien.UseVisualStyleBackColor = true;
            this.btnListNhanVien.Click += new System.EventHandler(this.btnListNhanVien_Click);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(106, 41);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(100, 22);
            this.txbMaNV.TabIndex = 23;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(675, 89);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(130, 51);
            this.btnResetPassword.TabIndex = 24;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // btnSearchNhanVienByHoTen
            // 
            this.btnSearchNhanVienByHoTen.Location = new System.Drawing.Point(1269, 153);
            this.btnSearchNhanVienByHoTen.Name = "btnSearchNhanVienByHoTen";
            this.btnSearchNhanVienByHoTen.Size = new System.Drawing.Size(130, 51);
            this.btnSearchNhanVienByHoTen.TabIndex = 25;
            this.btnSearchNhanVienByHoTen.Text = "Tìm kiếm theo tên";
            this.btnSearchNhanVienByHoTen.UseVisualStyleBackColor = true;
            this.btnSearchNhanVienByHoTen.Click += new System.EventHandler(this.btnSearchNhanVienByHoTen_Click);
            // 
            // txbSearchHoTen
            // 
            this.txbSearchHoTen.Location = new System.Drawing.Point(1148, 170);
            this.txbSearchHoTen.Name = "txbSearchHoTen";
            this.txbSearchHoTen.Size = new System.Drawing.Size(100, 22);
            this.txbSearchHoTen.TabIndex = 26;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Quản trị viên",
            "Khả Dụng",
            "Khóa"});
            this.cbTrangThai.Location = new System.Drawing.Point(314, 176);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cbTrangThai.TabIndex = 27;
            // 
            // fNhanVienManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 508);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.txbSearchHoTen);
            this.Controls.Add(this.btnSearchNhanVienByHoTen);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.btnListNhanVien);
            this.Controls.Add(this.btnDeleteNhanVien);
            this.Controls.Add(this.btnEditNhanVien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbCCCD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbGioiTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvNhanVien);
            this.Controls.Add(this.btnAddNhanVien);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbChucVu);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txbHoTen);
            this.Name = "fNhanVienManage";
            this.Text = "fNhanVienManage";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbChucVu;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Button btnAddNhanVien;
        private System.Windows.Forms.DataGridView dtgvNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCCCD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEditNhanVien;
        private System.Windows.Forms.Button btnDeleteNhanVien;
        private System.Windows.Forms.Button btnListNhanVien;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Button btnSearchNhanVienByHoTen;
        private System.Windows.Forms.TextBox txbSearchHoTen;
        private System.Windows.Forms.ComboBox cbTrangThai;
    }
}