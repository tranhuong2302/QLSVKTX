namespace QLSVKTX
{
    partial class fToaManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fToaManage));
            this.txbMaToa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenToa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgvToa = new System.Windows.Forms.DataGridView();
            this.btnListToa = new System.Windows.Forms.Button();
            this.btnDeleteToa = new System.Windows.Forms.Button();
            this.btnEditToa = new System.Windows.Forms.Button();
            this.btnAddToa = new System.Windows.Forms.Button();
            this.txbSearchTenToa = new System.Windows.Forms.TextBox();
            this.btnSearchTenToa = new System.Windows.Forms.Button();
            this.nupSoPhong = new System.Windows.Forms.NumericUpDown();
            this.cbMaNguoiQuanLy = new System.Windows.Forms.ComboBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMaToa
            // 
            this.txbMaToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaToa.Location = new System.Drawing.Point(295, 53);
            this.txbMaToa.Name = "txbMaToa";
            this.txbMaToa.Size = new System.Drawing.Size(199, 27);
            this.txbMaToa.TabIndex = 1;
            this.txbMaToa.TextChanged += new System.EventHandler(this.txbMaToa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(142, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên tòa:    ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(142, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Mã tòa:    ";
            // 
            // txbTenToa
            // 
            this.txbTenToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenToa.Location = new System.Drawing.Point(295, 105);
            this.txbTenToa.Name = "txbTenToa";
            this.txbTenToa.Size = new System.Drawing.Size(199, 27);
            this.txbTenToa.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(142, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Số phòng:    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::QLSVKTX.Properties.Resources.dot_required;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(132, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Người Quản Lý:    ";
            // 
            // dtgvToa
            // 
            this.dtgvToa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvToa.Location = new System.Drawing.Point(278, 479);
            this.dtgvToa.Name = "dtgvToa";
            this.dtgvToa.RowHeadersWidth = 51;
            this.dtgvToa.RowTemplate.Height = 24;
            this.dtgvToa.Size = new System.Drawing.Size(955, 264);
            this.dtgvToa.TabIndex = 33;
            // 
            // btnListToa
            // 
            this.btnListToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListToa.Image = global::QLSVKTX.Properties.Resources.load_removebg_preview;
            this.btnListToa.Location = new System.Drawing.Point(776, 411);
            this.btnListToa.Name = "btnListToa";
            this.btnListToa.Size = new System.Drawing.Size(85, 50);
            this.btnListToa.TabIndex = 8;
            this.btnListToa.UseVisualStyleBackColor = true;
            this.btnListToa.Click += new System.EventHandler(this.btnListToa_Click);
            // 
            // btnDeleteToa
            // 
            this.btnDeleteToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteToa.Image = global::QLSVKTX.Properties.Resources.thùng_rác_removebg_preview;
            this.btnDeleteToa.Location = new System.Drawing.Point(625, 411);
            this.btnDeleteToa.Name = "btnDeleteToa";
            this.btnDeleteToa.Size = new System.Drawing.Size(85, 50);
            this.btnDeleteToa.TabIndex = 7;
            this.btnDeleteToa.UseVisualStyleBackColor = true;
            this.btnDeleteToa.Click += new System.EventHandler(this.btnDeleteToa_Click);
            // 
            // btnEditToa
            // 
            this.btnEditToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditToa.Image = global::QLSVKTX.Properties.Resources.edit_removebg_preview;
            this.btnEditToa.Location = new System.Drawing.Point(479, 411);
            this.btnEditToa.Name = "btnEditToa";
            this.btnEditToa.Size = new System.Drawing.Size(85, 50);
            this.btnEditToa.TabIndex = 6;
            this.btnEditToa.UseVisualStyleBackColor = true;
            this.btnEditToa.Click += new System.EventHandler(this.btnEditToa_Click);
            // 
            // btnAddToa
            // 
            this.btnAddToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToa.Image = global::QLSVKTX.Properties.Resources.add_removebg_preview1;
            this.btnAddToa.Location = new System.Drawing.Point(334, 411);
            this.btnAddToa.Name = "btnAddToa";
            this.btnAddToa.Size = new System.Drawing.Size(85, 50);
            this.btnAddToa.TabIndex = 5;
            this.btnAddToa.UseVisualStyleBackColor = true;
            this.btnAddToa.Click += new System.EventHandler(this.btnAddToa_Click);
            // 
            // txbSearchTenToa
            // 
            this.txbSearchTenToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSearchTenToa.Location = new System.Drawing.Point(1048, 423);
            this.txbSearchTenToa.Name = "txbSearchTenToa";
            this.txbSearchTenToa.Size = new System.Drawing.Size(177, 27);
            this.txbSearchTenToa.TabIndex = 9;
            // 
            // btnSearchTenToa
            // 
            this.btnSearchTenToa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchTenToa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTenToa.Image = global::QLSVKTX.Properties.Resources.search_removebg_preview;
            this.btnSearchTenToa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchTenToa.Location = new System.Drawing.Point(1253, 410);
            this.btnSearchTenToa.Name = "btnSearchTenToa";
            this.btnSearchTenToa.Size = new System.Drawing.Size(144, 51);
            this.btnSearchTenToa.TabIndex = 10;
            this.btnSearchTenToa.Text = "Tìm tên tòa";
            this.btnSearchTenToa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchTenToa.UseVisualStyleBackColor = true;
            this.btnSearchTenToa.Click += new System.EventHandler(this.btnSearchTenToa_Click);
            // 
            // nupSoPhong
            // 
            this.nupSoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupSoPhong.Location = new System.Drawing.Point(295, 155);
            this.nupSoPhong.Name = "nupSoPhong";
            this.nupSoPhong.Size = new System.Drawing.Size(199, 27);
            this.nupSoPhong.TabIndex = 3;
            // 
            // cbMaNguoiQuanLy
            // 
            this.cbMaNguoiQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaNguoiQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNguoiQuanLy.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNguoiQuanLy.FormattingEnabled = true;
            this.cbMaNguoiQuanLy.Location = new System.Drawing.Point(295, 205);
            this.cbMaNguoiQuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNguoiQuanLy.Name = "cbMaNguoiQuanLy";
            this.cbMaNguoiQuanLy.Size = new System.Drawing.Size(241, 27);
            this.cbMaNguoiQuanLy.TabIndex = 4;
            // 
            // pbExit
            // 
            this.pbExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(1479, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(40, 40);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 69;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(529, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(415, 46);
            this.label6.TabIndex = 112;
            this.label6.Text = "Quản lý tòa ký túc xá";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nupSoPhong);
            this.groupBox1.Controls.Add(this.txbTenToa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMaNguoiQuanLy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txbMaToa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(445, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 242);
            this.groupBox1.TabIndex = 113;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tòa nhà";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.Location = new System.Drawing.Point(911, 411);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(85, 50);
            this.btnXuatExcel.TabIndex = 114;
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // fToaManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1522, 768);
            this.Controls.Add(this.btnXuatExcel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.txbSearchTenToa);
            this.Controls.Add(this.btnSearchTenToa);
            this.Controls.Add(this.btnListToa);
            this.Controls.Add(this.btnDeleteToa);
            this.Controls.Add(this.btnEditToa);
            this.Controls.Add(this.btnAddToa);
            this.Controls.Add(this.dtgvToa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fToaManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fToaManage";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbMaToa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenToa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvToa;
        private System.Windows.Forms.Button btnListToa;
        private System.Windows.Forms.Button btnDeleteToa;
        private System.Windows.Forms.Button btnEditToa;
        private System.Windows.Forms.Button btnAddToa;
        private System.Windows.Forms.TextBox txbSearchTenToa;
        private System.Windows.Forms.Button btnSearchTenToa;
        private System.Windows.Forms.NumericUpDown nupSoPhong;
        private System.Windows.Forms.ComboBox cbMaNguoiQuanLy;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXuatExcel;
    }
}