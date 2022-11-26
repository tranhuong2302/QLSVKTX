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
            ((System.ComponentModel.ISupportInitialize)(this.nupHienTai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToiDa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaToa
            // 
            this.cbMaToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaToa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaToa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaToa.FormattingEnabled = true;
            this.cbMaToa.Location = new System.Drawing.Point(77, 119);
            this.cbMaToa.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaToa.Name = "cbMaToa";
            this.cbMaToa.Size = new System.Drawing.Size(201, 30);
            this.cbMaToa.TabIndex = 56;
            // 
            // nupHienTai
            // 
            this.nupHienTai.Location = new System.Drawing.Point(559, 37);
            this.nupHienTai.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupHienTai.Name = "nupHienTai";
            this.nupHienTai.Size = new System.Drawing.Size(120, 22);
            this.nupHienTai.TabIndex = 55;
            // 
            // txbSearchMaPhong
            // 
            this.txbSearchMaPhong.Location = new System.Drawing.Point(991, 156);
            this.txbSearchMaPhong.Name = "txbSearchMaPhong";
            this.txbSearchMaPhong.Size = new System.Drawing.Size(100, 22);
            this.txbSearchMaPhong.TabIndex = 54;
            // 
            // btnSearchMaPhong
            // 
            this.btnSearchMaPhong.Location = new System.Drawing.Point(1112, 139);
            this.btnSearchMaPhong.Name = "btnSearchMaPhong";
            this.btnSearchMaPhong.Size = new System.Drawing.Size(130, 51);
            this.btnSearchMaPhong.TabIndex = 53;
            this.btnSearchMaPhong.Text = "Tìm kiếm mã phòng";
            this.btnSearchMaPhong.UseVisualStyleBackColor = true;
            this.btnSearchMaPhong.Click += new System.EventHandler(this.btnSearchTen_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(938, 85);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 50);
            this.btnList.TabIndex = 52;
            this.btnList.Text = "Xem";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(839, 85);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 50);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(723, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 50);
            this.btnEdit.TabIndex = 50;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(617, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 50);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtgvPhong
            // 
            this.dtgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvPhong.Location = new System.Drawing.Point(52, 212);
            this.dtgvPhong.Name = "dtgvPhong";
            this.dtgvPhong.RowHeadersWidth = 51;
            this.dtgvPhong.RowTemplate.Height = 24;
            this.dtgvPhong.Size = new System.Drawing.Size(817, 199);
            this.dtgvPhong.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Toa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "SoLuongsinhvienhientai";
            // 
            // txbMaPhong
            // 
            this.txbMaPhong.Location = new System.Drawing.Point(105, 33);
            this.txbMaPhong.Name = "txbMaPhong";
            this.txbMaPhong.Size = new System.Drawing.Size(100, 22);
            this.txbMaPhong.TabIndex = 45;
            this.txbMaPhong.TextChanged += new System.EventHandler(this.txbMaPhong_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(211, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "ten Phong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 43;
            this.label1.Text = "ma phong";
            // 
            // txbTenPhong
            // 
            this.txbTenPhong.Location = new System.Drawing.Point(289, 39);
            this.txbTenPhong.Name = "txbTenPhong";
            this.txbTenPhong.Size = new System.Drawing.Size(100, 22);
            this.txbTenPhong.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(707, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Soluongsinhvientoida";
            // 
            // nupToiDa
            // 
            this.nupToiDa.Location = new System.Drawing.Point(849, 33);
            this.nupToiDa.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nupToiDa.Name = "nupToiDa";
            this.nupToiDa.Size = new System.Drawing.Size(120, 22);
            this.nupToiDa.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 60;
            this.label6.Text = "loai phong";
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
            this.cbLoaiPhong.Location = new System.Drawing.Point(400, 128);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(144, 30);
            this.cbLoaiPhong.TabIndex = 61;
            // 
            // cbTinhTrangPhong
            // 
            this.cbTinhTrangPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTinhTrangPhong.FormattingEnabled = true;
            this.cbTinhTrangPhong.Items.AddRange(new object[] {
            "Hoạt động",
            "Bảo trì"});
            this.cbTinhTrangPhong.Location = new System.Drawing.Point(1141, 36);
            this.cbTinhTrangPhong.Name = "cbTinhTrangPhong";
            this.cbTinhTrangPhong.Size = new System.Drawing.Size(121, 24);
            this.cbTinhTrangPhong.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1013, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "tinh trang phong";
            // 
            // fPhongManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 450);
            this.Controls.Add(this.cbTinhTrangPhong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nupToiDa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMaToa);
            this.Controls.Add(this.nupHienTai);
            this.Controls.Add(this.txbSearchMaPhong);
            this.Controls.Add(this.btnSearchMaPhong);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtgvPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMaPhong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenPhong);
            this.Name = "fPhongManage";
            this.Text = "fPhongManage";
            ((System.ComponentModel.ISupportInitialize)(this.nupHienTai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupToiDa)).EndInit();
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
    }
}