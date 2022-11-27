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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHoaDonManage));
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.nupTienNuoc = new System.Windows.Forms.NumericUpDown();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.nupTienDien = new System.Windows.Forms.NumericUpDown();
            this.txbSearchMaPhong = new System.Windows.Forms.TextBox();
            this.dtgvHoaDon = new System.Windows.Forms.DataGridView();
            this.txbMaHoaDon = new System.Windows.Forms.TextBox();
            this.txbTenHoaDon = new System.Windows.Forms.TextBox();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btnSearchMaPhong = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupTienNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTienDien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cbTrangThai.Location = new System.Drawing.Point(652, 135);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(228, 28);
            this.cbTrangThai.TabIndex = 7;
            // 
            // nupTienNuoc
            // 
            this.nupTienNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTienNuoc.Location = new System.Drawing.Point(188, 180);
            this.nupTienNuoc.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nupTienNuoc.Name = "nupTienNuoc";
            this.nupTienNuoc.Size = new System.Drawing.Size(194, 27);
            this.nupTienNuoc.TabIndex = 4;
            this.nupTienNuoc.ThousandsSeparator = true;
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(652, 88);
            this.cbMaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(201, 28);
            this.cbMaPhong.TabIndex = 6;
            // 
            // nupTienDien
            // 
            this.nupTienDien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupTienDien.Location = new System.Drawing.Point(188, 135);
            this.nupTienDien.Maximum = new decimal(new int[] {
            1241513983,
            370409800,
            542101,
            0});
            this.nupTienDien.Name = "nupTienDien";
            this.nupTienDien.Size = new System.Drawing.Size(194, 27);
            this.nupTienDien.TabIndex = 3;
            this.nupTienDien.ThousandsSeparator = true;
            // 
            // txbSearchMaPhong
            // 
            this.txbSearchMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMaPhong.Location = new System.Drawing.Point(994, 486);
            this.txbSearchMaPhong.Name = "txbSearchMaPhong";
            this.txbSearchMaPhong.Size = new System.Drawing.Size(199, 27);
            this.txbSearchMaPhong.TabIndex = 12;
            // 
            // dtgvHoaDon
            // 
            this.dtgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvHoaDon.Location = new System.Drawing.Point(252, 557);
            this.dtgvHoaDon.Name = "dtgvHoaDon";
            this.dtgvHoaDon.RowHeadersWidth = 51;
            this.dtgvHoaDon.RowTemplate.Height = 24;
            this.dtgvHoaDon.Size = new System.Drawing.Size(1041, 199);
            this.dtgvHoaDon.TabIndex = 70;
            // 
            // txbMaHoaDon
            // 
            this.txbMaHoaDon.Enabled = false;
            this.txbMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaHoaDon.Location = new System.Drawing.Point(188, 44);
            this.txbMaHoaDon.Name = "txbMaHoaDon";
            this.txbMaHoaDon.Size = new System.Drawing.Size(194, 27);
            this.txbMaHoaDon.TabIndex = 1;
            this.txbMaHoaDon.TextChanged += new System.EventHandler(this.txbMaHoaDon_TextChanged);
            // 
            // txbTenHoaDon
            // 
            this.txbTenHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenHoaDon.Location = new System.Drawing.Point(188, 89);
            this.txbTenHoaDon.Name = "txbTenHoaDon";
            this.txbTenHoaDon.Size = new System.Drawing.Size(194, 27);
            this.txbTenHoaDon.TabIndex = 2;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTao.Location = new System.Drawing.Point(652, 44);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(201, 27);
            this.dtpNgayTao.TabIndex = 5;
            this.dtpNgayTao.Value = new System.DateTime(2022, 11, 21, 9, 9, 29, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMaHoaDon);
            this.groupBox1.Controls.Add(this.txbTenHoaDon);
            this.groupBox1.Controls.Add(this.dtpNgayTao);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMaPhong);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nupTienDien);
            this.groupBox1.Controls.Add(this.nupTienNuoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(291, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 244);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn Điện nước";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(452, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "Ngày Tạo hóa đơn:    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(55, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Mã hóa đơn:    ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(55, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 66;
            this.label2.Text = "Tên hóa đơn:    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(55, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Tiền Điện:    ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(452, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 20);
            this.label9.TabIndex = 83;
            this.label9.Text = "Tình trạng hóa đơn:    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(55, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Tiền nước:    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(452, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "Mã Phòng:    ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(505, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(523, 46);
            this.label7.TabIndex = 89;
            this.label7.Text = "Quản lý hóa đơn điện nước";
            // 
            // pbExit
            // 
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1481, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(40, 40);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 87;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // btnSearchMaPhong
            // 
            this.btnSearchMaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMaPhong.Image = global::QLSVKTX.Properties.Resources.search_removebg_preview;
            this.btnSearchMaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMaPhong.Location = new System.Drawing.Point(1210, 472);
            this.btnSearchMaPhong.Name = "btnSearchMaPhong";
            this.btnSearchMaPhong.Size = new System.Drawing.Size(165, 51);
            this.btnSearchMaPhong.TabIndex = 13;
            this.btnSearchMaPhong.Text = "Tìm mã phòng";
            this.btnSearchMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchMaPhong.UseVisualStyleBackColor = true;
            this.btnSearchMaPhong.Click += new System.EventHandler(this.btnSearchMaPhong_Click);
            // 
            // btnList
            // 
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Image = global::QLSVKTX.Properties.Resources.load_removebg_preview;
            this.btnList.Location = new System.Drawing.Point(717, 474);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(85, 50);
            this.btnList.TabIndex = 11;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::QLSVKTX.Properties.Resources.thùng_rác_removebg_preview;
            this.btnDelete.Location = new System.Drawing.Point(565, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::QLSVKTX.Properties.Resources.edit_removebg_preview;
            this.btnEdit.Location = new System.Drawing.Point(411, 474);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 50);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::QLSVKTX.Properties.Resources.add_removebg_preview1;
            this.btnAdd.Location = new System.Drawing.Point(265, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 50);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Location = new System.Drawing.Point(860, 473);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(85, 50);
            this.btnXuatExcel.TabIndex = 117;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // fHoaDonManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1522, 768);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.txbSearchMaPhong);
            this.Controls.Add(this.btnSearchMaPhong);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvHoaDon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fHoaDonManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fHoaDonManage";
            this.Click += new System.EventHandler(this.pbExit_Click);
            ((System.ComponentModel.ISupportInitialize)(this.nupTienNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTienDien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
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
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}