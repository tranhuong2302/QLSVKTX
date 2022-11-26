namespace QLSVKTX
{
    partial class fHoaDonManage
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
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nupTienNuoc = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.nupTienDien = new System.Windows.Forms.NumericUpDown();
            this.txbSearchMaPhong = new System.Windows.Forms.TextBox();
            this.btnSearchMaPhong = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenHoaDon = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nupTienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTienDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbTrangThai.Location = new System.Drawing.Point(948, 34);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(121, 24);
            this.cbTrangThai.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(859, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 83;
            this.label9.Text = "Trang Thai";
            // 
            // nupTienNuoc
            // 
            this.nupTienNuoc.Location = new System.Drawing.Point(713, 34);
            this.nupTienNuoc.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nupTienNuoc.Name = "nupTienNuoc";
            this.nupTienNuoc.Size = new System.Drawing.Size(120, 22);
            this.nupTienNuoc.TabIndex = 80;
            this.nupTienNuoc.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(624, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "TienNuoc";
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(123, 86);
            this.cbMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(201, 30);
            this.cbMaPhong.TabIndex = 78;
            // 
            // nupTienDien
            // 
            this.nupTienDien.Location = new System.Drawing.Point(478, 34);
            this.nupTienDien.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nupTienDien.Name = "nupTienDien";
            this.nupTienDien.Size = new System.Drawing.Size(120, 22);
            this.nupTienDien.TabIndex = 77;
            this.nupTienDien.ThousandsSeparator = true;
            // 
            // txbSearchMaPhong
            // 
            this.txbSearchMaPhong.Location = new System.Drawing.Point(1001, 187);
            this.txbSearchMaPhong.Name = "txbSearchMaPhong";
            this.txbSearchMaPhong.Size = new System.Drawing.Size(100, 22);
            this.txbSearchMaPhong.TabIndex = 76;
            // 
            // btnSearchMaPhong
            // 
            this.btnSearchMaPhong.Location = new System.Drawing.Point(1122, 170);
            this.btnSearchMaPhong.Name = "btnSearchMaPhong";
            this.btnSearchMaPhong.Size = new System.Drawing.Size(130, 51);
            this.btnSearchMaPhong.TabIndex = 75;
            this.btnSearchMaPhong.Text = "Tìm kiếm theo mã phòng";
            this.btnSearchMaPhong.UseVisualStyleBackColor = true;
            this.btnSearchMaPhong.Click += new System.EventHandler(this.btnSearchMaPhong_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(948, 116);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 50);
            this.btnList.TabIndex = 74;
            this.btnList.Text = "Xem";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(849, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(733, 113);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 50);
            this.btnEdit.TabIndex = 72;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(627, 113);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 50);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(62, 245);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersWidth = 51;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(1143, 199);
            this.dtgvHoaDon.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 69;
            this.label4.Text = "Ma Phong";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(407, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tien Dien";
            // 
            // txbMaHoaDon
            // 
            this.txbMaHoaDon.Enabled = false;
            this.txbMaHoaDon.Location = new System.Drawing.Point(94, 25);
            this.txbMaHoaDon.Name = "txbMaHoaDon";
            this.txbMaHoaDon.Size = new System.Drawing.Size(100, 22);
            this.txbMaHoaDon.TabIndex = 67;
            this.txbMaHoaDon.TextChanged += new System.EventHandler(this.txbMaHoaDon_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 66;
            this.label2.Text = "ten hoa don";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "ma hoa don";
            // 
            // txbTenHoaDon
            // 
            this.txbTenHoaDon.Location = new System.Drawing.Point(283, 31);
            this.txbTenHoaDon.Name = "txbTenHoaDon";
            this.txbTenHoaDon.Size = new System.Drawing.Size(100, 22);
            this.txbTenHoaDon.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 85;
            this.label6.Text = "Ngay Tao";
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(421, 88);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(114, 22);
            this.dtpNgayTao.TabIndex = 86;
            this.dtpNgayTao.Value = new System.DateTime(2022, 11, 21, 9, 9, 29, 0);
            // 
            // fHoaDonManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 507);
            this.Controls.Add(this.dtpNgayTao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nupTienNuoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaPhong);
            this.Controls.Add(this.nupTienDien);
            this.Controls.Add(this.txbSearchMaPhong);
            this.Controls.Add(this.btnSearchMaPhong);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvHoaDon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMaHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenHoaDon);
            this.Name = "fHoaDonManage";
            this.Text = "fHoaDonManage";
            ((System.ComponentModel.ISupportInitialize)(this.nupTienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTienDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTrangThai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nupTienNuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.NumericUpDown nupTienDien;
        private System.Windows.Forms.TextBox txbSearchMaPhong;
        private System.Windows.Forms.Button btnSearchMaPhong;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvHoaDon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenHoaDon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
    }
}