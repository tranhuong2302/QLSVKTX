namespace QLSVKTX
{
    partial class fPhongManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPhongManage));
            this.cbMaToa = new System.Windows.Forms.ComboBox();
            this.nupHienTai = new System.Windows.Forms.NumericUpDown();
            this.txbSearchMaPhong = new System.Windows.Forms.TextBox();
            this.btnSearchMaPhong = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtgvPhong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nupToiDa = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbTinhTrangPhong = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupHienTai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbMaToa
            // 
            this.cbMaToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaToa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaToa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaToa.FormattingEnabled = true;
            this.cbMaToa.Location = new System.Drawing.Point(245, 161);
            this.cbMaToa.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaToa.Name = "cbMaToa";
            this.cbMaToa.Size = new System.Drawing.Size(229, 30);
            this.cbMaToa.TabIndex = 3;
            // 
            // nupHienTai
            // 
            this.nupHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupHienTai.Location = new System.Drawing.Point(773, 106);
            this.nupHienTai.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupHienTai.Name = "nupHienTai";
            this.nupHienTai.Size = new System.Drawing.Size(89, 27);
            this.nupHienTai.TabIndex = 55;
            // 
            // txbSearchMaPhong
            // 
            this.txbSearchMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchMaPhong.Location = new System.Drawing.Point(1062, 444);
            this.txbSearchMaPhong.Name = "txbSearchMaPhong";
            this.txbSearchMaPhong.Size = new System.Drawing.Size(150, 27);
            this.txbSearchMaPhong.TabIndex = 54;
            // 
            // btnSearchMaPhong
            // 
            this.btnSearchMaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMaPhong.Image = global::QLSVKTX.Properties.Resources.search_removebg_preview;
            this.btnSearchMaPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchMaPhong.Location = new System.Drawing.Point(1234, 432);
            this.btnSearchMaPhong.Name = "btnSearchMaPhong";
            this.btnSearchMaPhong.Size = new System.Drawing.Size(162, 51);
            this.btnSearchMaPhong.TabIndex = 53;
            this.btnSearchMaPhong.Text = "Tìm mã phòng";
            this.btnSearchMaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchMaPhong.UseVisualStyleBackColor = true;
            this.btnSearchMaPhong.Click += new System.EventHandler(this.btnSearchTen_Click);
            // 
            // btnList
            // 
            this.btnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.Image = global::QLSVKTX.Properties.Resources.load_removebg_preview;
            this.btnList.Location = new System.Drawing.Point(790, 435);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(85, 50);
            this.btnList.TabIndex = 52;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::QLSVKTX.Properties.Resources.thùng_rác_removebg_preview;
            this.btnDelete.Location = new System.Drawing.Point(623, 435);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 50);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::QLSVKTX.Properties.Resources.edit_removebg_preview;
            this.btnEdit.Location = new System.Drawing.Point(453, 435);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 50);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::QLSVKTX.Properties.Resources.add_removebg_preview1;
            this.btnAdd.Location = new System.Drawing.Point(285, 435);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 50);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvPhong
            // 
            this.dtgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhong.Location = new System.Drawing.Point(326, 513);
            this.dtgvPhong.Name = "dtgvPhong";
            this.dtgvPhong.RowHeadersWidth = 51;
            this.dtgvPhong.RowTemplate.Height = 24;
            this.dtgvPhong.Size = new System.Drawing.Size(911, 231);
            this.dtgvPhong.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(68, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 47;
            this.label4.Text = "Tòa nhà:    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(513, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Số lượng sinh viên hiện tại:     ";
            // 
            // txbMaPhong
            // 
            this.txbMaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaPhong.Location = new System.Drawing.Point(245, 57);
            this.txbMaPhong.Name = "txbMaPhong";
            this.txbMaPhong.Size = new System.Drawing.Size(229, 27);
            this.txbMaPhong.TabIndex = 1;
            this.txbMaPhong.TextChanged += new System.EventHandler(this.txbMaPhong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(68, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên phòng:    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(68, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã phòng:    ";
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenPhong.Location = new System.Drawing.Point(245, 106);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(229, 27);
            this.txbTenPhong.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(513, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Số lượng sinh viên tối đa:    ";
            // 
            // nupToiDa
            // 
            this.nupToiDa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupToiDa.Location = new System.Drawing.Point(773, 162);
            this.nupToiDa.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupToiDa.Name = "nupToiDa";
            this.nupToiDa.Size = new System.Drawing.Size(89, 27);
            this.nupToiDa.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(68, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 20);
            this.label6.TabIndex = 60;
            this.label6.Text = "Loài Phòng (Nam/Nữ):    ";
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbLoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(290, 217);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(184, 30);
            this.cbLoaiPhong.TabIndex = 61;
            // 
            // cbTinhTrangPhong
            // 
            this.cbTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrangPhong.FormattingEnabled = true;
            this.cbTinhTrangPhong.Items.AddRange(new object[] {
            "Hoạt động",
            "Bảo trì"});
            this.cbTinhTrangPhong.Location = new System.Drawing.Point(715, 214);
            this.cbTinhTrangPhong.Name = "cbTinhTrangPhong";
            this.cbTinhTrangPhong.Size = new System.Drawing.Size(147, 33);
            this.cbTinhTrangPhong.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(513, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 20);
            this.label9.TabIndex = 62;
            this.label9.Text = "Tình trạng phòng:    ";
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1480, 2);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(40, 40);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 69;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 51);
            this.label7.TabIndex = 70;
            this.label7.Text = "Quản lý phòng ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txbMaPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbTenPhong);
            this.groupBox1.Controls.Add(this.cbLoaiPhong);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbTinhTrangPhong);
            this.groupBox1.Controls.Add(this.cbMaToa);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nupHienTai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nupToiDa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(317, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 288);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Location = new System.Drawing.Point(939, 433);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(85, 50);
            this.btnXuatExcel.TabIndex = 117;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // fPhongManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1522, 768);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.txbSearchMaPhong);
            this.Controls.Add(this.btnSearchMaPhong);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvPhong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPhongManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPhongManage";
            ((System.ComponentModel.ISupportInitialize)(this.nupHienTai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaToa;
        private System.Windows.Forms.NumericUpDown nupHienTai;
        private System.Windows.Forms.TextBox txbSearchMaPhong;
        private System.Windows.Forms.Button btnSearchMaPhong;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nupToiDa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.ComboBox cbTinhTrangPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}