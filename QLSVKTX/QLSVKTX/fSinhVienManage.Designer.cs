namespace QLSVKTX
{
    partial class fSinhVienManage
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
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.txbSearchHoTen = new System.Windows.Forms.TextBox();
            this.btnSearchByHoTen = new System.Windows.Forms.Button();
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCCCD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbGioiTinh = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvSinhVien = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nupNamHoc = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpNgayLamHopDong = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpNgayKetThucHopDong = new System.Windows.Forms.DateTimePicker();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.txbSearchByMaSV = new System.Windows.Forms.TextBox();
            this.btnSearchByMaSV = new System.Windows.Forms.Button();
            this.txbSeachByMaPhong = new System.Windows.Forms.TextBox();
            this.btnSearchByMaPhong = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txbToa = new System.Windows.Forms.TextBox();
            this.btnNullNgayKetThucHopDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNamHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKhoa
            // 
            this.cbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Sư Phạm Tin"});
            this.cbKhoa.Location = new System.Drawing.Point(409, 146);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 24);
            this.cbKhoa.TabIndex = 53;
            // 
            // txbSearchHoTen
            // 
            this.txbSearchHoTen.Location = new System.Drawing.Point(1163, 140);
            this.txbSearchHoTen.Name = "txbSearchHoTen";
            this.txbSearchHoTen.Size = new System.Drawing.Size(100, 22);
            this.txbSearchHoTen.TabIndex = 52;
            // 
            // btnSearchByHoTen
            // 
            this.btnSearchByHoTen.Location = new System.Drawing.Point(1284, 119);
            this.btnSearchByHoTen.Name = "btnSearchByHoTen";
            this.btnSearchByHoTen.Size = new System.Drawing.Size(130, 51);
            this.btnSearchByHoTen.TabIndex = 51;
            this.btnSearchByHoTen.Text = "Tìm kiếm theo tên";
            this.btnSearchByHoTen.UseVisualStyleBackColor = true;
            this.btnSearchByHoTen.Click += new System.EventHandler(this.btnSearchByHoTen_Click);
            // 
            // txbMaSV
            // 
            this.txbMaSV.Location = new System.Drawing.Point(75, 11);
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.Size = new System.Drawing.Size(100, 22);
            this.txbMaSV.TabIndex = 49;
            this.txbMaSV.TextChanged += new System.EventHandler(this.txbMaSV_TextChanged);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(1339, 51);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(130, 51);
            this.btnList.TabIndex = 48;
            this.btnList.Text = "Xem";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1176, 51);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 51);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(1016, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 51);
            this.btnEdit.TabIndex = 46;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(322, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "Khoa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 44;
            this.label8.Text = "maPhong";
            // 
            // txbCCCD
            // 
            this.txbCCCD.Location = new System.Drawing.Point(124, 71);
            this.txbCCCD.Name = "txbCCCD";
            this.txbCCCD.Size = new System.Drawing.Size(100, 22);
            this.txbCCCD.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 16);
            this.label7.TabIndex = 42;
            this.label7.Text = "cmnd/cccd";
            // 
            // cbGioiTinh
            // 
            this.cbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioiTinh.FormattingEnabled = true;
            this.cbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioiTinh.Location = new System.Drawing.Point(645, 17);
            this.cbGioiTinh.Name = "cbGioiTinh";
            this.cbGioiTinh.Size = new System.Drawing.Size(121, 24);
            this.cbGioiTinh.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "gioitinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1168, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "diachi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(996, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "sdt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "ngaysinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "hoten";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "maSv";
            // 
            // dtgvSinhVien
            // 
            this.dtgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSinhVien.Location = new System.Drawing.Point(28, 261);
            this.dtgvSinhVien.Name = "dtgvSinhVien";
            this.dtgvSinhVien.RowHeadersWidth = 51;
            this.dtgvSinhVien.RowTemplate.Height = 24;
            this.dtgvSinhVien.Size = new System.Drawing.Size(1468, 224);
            this.dtgvSinhVien.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(852, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 51);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(1045, 20);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(100, 22);
            this.txbSDT.TabIndex = 32;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(1237, 18);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(100, 22);
            this.txbDiaChi.TabIndex = 30;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd-MM-yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(454, 14);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(114, 22);
            this.dtpNgaySinh.TabIndex = 29;
            this.dtpNgaySinh.Value = new System.DateTime(2022, 11, 21, 9, 9, 29, 0);
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(245, 14);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(100, 22);
            this.txbHoTen.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(784, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 16);
            this.label10.TabIndex = 54;
            this.label10.Text = "namhoc";
            // 
            // nupNamHoc
            // 
            this.nupNamHoc.Location = new System.Drawing.Point(857, 19);
            this.nupNamHoc.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nupNamHoc.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupNamHoc.Name = "nupNamHoc";
            this.nupNamHoc.Size = new System.Drawing.Size(120, 22);
            this.nupNamHoc.TabIndex = 55;
            this.nupNamHoc.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(242, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "ngaylamhopdong";
            // 
            // dtpNgayLamHopDong
            // 
            this.dtpNgayLamHopDong.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayLamHopDong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLamHopDong.Location = new System.Drawing.Point(381, 77);
            this.dtpNgayLamHopDong.Name = "dtpNgayLamHopDong";
            this.dtpNgayLamHopDong.Size = new System.Drawing.Size(114, 22);
            this.dtpNgayLamHopDong.TabIndex = 56;
            this.dtpNgayLamHopDong.Value = new System.DateTime(2022, 11, 21, 9, 9, 29, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(527, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "ngayketthuchopdong";
            // 
            // dtpNgayKetThucHopDong
            // 
            this.dtpNgayKetThucHopDong.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayKetThucHopDong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKetThucHopDong.Location = new System.Drawing.Point(676, 80);
            this.dtpNgayKetThucHopDong.Name = "dtpNgayKetThucHopDong";
            this.dtpNgayKetThucHopDong.Size = new System.Drawing.Size(114, 22);
            this.dtpNgayKetThucHopDong.TabIndex = 58;
            this.dtpNgayKetThucHopDong.Value = new System.DateTime(2022, 11, 21, 9, 9, 29, 0);
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(357, 197);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(121, 24);
            this.cbMaPhong.TabIndex = 60;
            // 
            // txbSearchByMaSV
            // 
            this.txbSearchByMaSV.Location = new System.Drawing.Point(1163, 197);
            this.txbSearchByMaSV.Name = "txbSearchByMaSV";
            this.txbSearchByMaSV.Size = new System.Drawing.Size(100, 22);
            this.txbSearchByMaSV.TabIndex = 62;
            // 
            // btnSearchByMaSV
            // 
            this.btnSearchByMaSV.Location = new System.Drawing.Point(1284, 180);
            this.btnSearchByMaSV.Name = "btnSearchByMaSV";
            this.btnSearchByMaSV.Size = new System.Drawing.Size(130, 51);
            this.btnSearchByMaSV.TabIndex = 61;
            this.btnSearchByMaSV.Text = "Tìm kiếm mã sinh viên";
            this.btnSearchByMaSV.UseVisualStyleBackColor = true;
            this.btnSearchByMaSV.Click += new System.EventHandler(this.btnSearchByMaSV_Click);
            // 
            // txbSeachByMaPhong
            // 
            this.txbSeachByMaPhong.Location = new System.Drawing.Point(843, 163);
            this.txbSeachByMaPhong.Name = "txbSeachByMaPhong";
            this.txbSeachByMaPhong.Size = new System.Drawing.Size(100, 22);
            this.txbSeachByMaPhong.TabIndex = 64;
            // 
            // btnSearchByMaPhong
            // 
            this.btnSearchByMaPhong.Location = new System.Drawing.Point(964, 146);
            this.btnSearchByMaPhong.Name = "btnSearchByMaPhong";
            this.btnSearchByMaPhong.Size = new System.Drawing.Size(130, 51);
            this.btnSearchByMaPhong.TabIndex = 63;
            this.btnSearchByMaPhong.Text = "tìm kiếm theo mã phòng";
            this.btnSearchByMaPhong.UseVisualStyleBackColor = true;
            this.btnSearchByMaPhong.Click += new System.EventHandler(this.btnSearchByMaPhong_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(72, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 16);
            this.label13.TabIndex = 65;
            this.label13.Text = "Tòa";
            // 
            // txbToa
            // 
            this.txbToa.Enabled = false;
            this.txbToa.Location = new System.Drawing.Point(110, 194);
            this.txbToa.Name = "txbToa";
            this.txbToa.Size = new System.Drawing.Size(100, 22);
            this.txbToa.TabIndex = 66;
            // 
            // btnNullNgayKetThucHopDong
            // 
            this.btnNullNgayKetThucHopDong.Location = new System.Drawing.Point(645, 177);
            this.btnNullNgayKetThucHopDong.Name = "btnNullNgayKetThucHopDong";
            this.btnNullNgayKetThucHopDong.Size = new System.Drawing.Size(130, 51);
            this.btnNullNgayKetThucHopDong.TabIndex = 67;
            this.btnNullNgayKetThucHopDong.Text = "Kết thúc hợp đồng";
            this.btnNullNgayKetThucHopDong.UseVisualStyleBackColor = true;
            this.btnNullNgayKetThucHopDong.Click += new System.EventHandler(this.btnNullNgayKetThucHopDong_Click);
            // 
            // fSinhVienManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 506);
            this.Controls.Add(this.btnNullNgayKetThucHopDong);
            this.Controls.Add(this.txbToa);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txbSeachByMaPhong);
            this.Controls.Add(this.btnSearchByMaPhong);
            this.Controls.Add(this.txbSearchByMaSV);
            this.Controls.Add(this.btnSearchByMaSV);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpNgayKetThucHopDong);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpNgayLamHopDong);
            this.Controls.Add(this.nupNamHoc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbKhoa);
            this.Controls.Add(this.txbSearchHoTen);
            this.Controls.Add(this.btnSearchByHoTen);
            this.Controls.Add(this.txbMaSV);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
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
            this.Controls.Add(this.dtgvSinhVien);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txbHoTen);
            this.Name = "fSinhVienManage";
            this.Text = "fSinhVienManage";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupNamHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox txbSearchHoTen;
        private System.Windows.Forms.Button btnSearchByHoTen;
        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbCCCD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbGioiTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvSinhVien;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nupNamHoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpNgayLamHopDong;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThucHopDong;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.TextBox txbSearchByMaSV;
        private System.Windows.Forms.Button btnSearchByMaSV;
        private System.Windows.Forms.TextBox txbSeachByMaPhong;
        private System.Windows.Forms.Button btnSearchByMaPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbToa;
        private System.Windows.Forms.Button btnNullNgayKetThucHopDong;
    }
}