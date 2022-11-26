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
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMaToa
            // 
            this.txbMaToa.Location = new System.Drawing.Point(103, 46);
            this.txbMaToa.Name = "txbMaToa";
            this.txbMaToa.Size = new System.Drawing.Size(100, 22);
            this.txbMaToa.TabIndex = 27;
            this.txbMaToa.TextChanged += new System.EventHandler(this.txbMaToa_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "ten toa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "ma toa";
            // 
            // txbTenToa
            // 
            this.txbTenToa.Location = new System.Drawing.Point(272, 46);
            this.txbTenToa.Name = "txbTenToa";
            this.txbTenToa.Size = new System.Drawing.Size(100, 22);
            this.txbTenToa.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Sophong";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Người Quản Lý";
            // 
            // dtgvToa
            // 
            this.dtgvToa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvToa.Location = new System.Drawing.Point(50, 225);
            this.dtgvToa.Name = "dtgvToa";
            this.dtgvToa.RowHeadersWidth = 51;
            this.dtgvToa.RowTemplate.Height = 24;
            this.dtgvToa.Size = new System.Drawing.Size(955, 199);
            this.dtgvToa.TabIndex = 33;
            // 
            // btnListToa
            // 
            this.btnListToa.Location = new System.Drawing.Point(701, 96);
            this.btnListToa.Name = "btnListToa";
            this.btnListToa.Size = new System.Drawing.Size(75, 50);
            this.btnListToa.TabIndex = 37;
            this.btnListToa.Text = "Xem";
            this.btnListToa.UseVisualStyleBackColor = true;
            this.btnListToa.Click += new System.EventHandler(this.btnListToa_Click);
            // 
            // btnDeleteToa
            // 
            this.btnDeleteToa.Location = new System.Drawing.Point(602, 96);
            this.btnDeleteToa.Name = "btnDeleteToa";
            this.btnDeleteToa.Size = new System.Drawing.Size(75, 50);
            this.btnDeleteToa.TabIndex = 36;
            this.btnDeleteToa.Text = "Xóa";
            this.btnDeleteToa.UseVisualStyleBackColor = true;
            this.btnDeleteToa.Click += new System.EventHandler(this.btnDeleteToa_Click);
            // 
            // btnEditToa
            // 
            this.btnEditToa.Location = new System.Drawing.Point(486, 93);
            this.btnEditToa.Name = "btnEditToa";
            this.btnEditToa.Size = new System.Drawing.Size(75, 50);
            this.btnEditToa.TabIndex = 35;
            this.btnEditToa.Text = "Sửa";
            this.btnEditToa.UseVisualStyleBackColor = true;
            this.btnEditToa.Click += new System.EventHandler(this.btnEditToa_Click);
            // 
            // btnAddToa
            // 
            this.btnAddToa.Location = new System.Drawing.Point(380, 93);
            this.btnAddToa.Name = "btnAddToa";
            this.btnAddToa.Size = new System.Drawing.Size(75, 50);
            this.btnAddToa.TabIndex = 34;
            this.btnAddToa.Text = "Thêm";
            this.btnAddToa.UseVisualStyleBackColor = true;
            this.btnAddToa.Click += new System.EventHandler(this.btnAddToa_Click);
            // 
            // txbSearchTenToa
            // 
            this.txbSearchTenToa.Location = new System.Drawing.Point(754, 167);
            this.txbSearchTenToa.Name = "txbSearchTenToa";
            this.txbSearchTenToa.Size = new System.Drawing.Size(100, 22);
            this.txbSearchTenToa.TabIndex = 39;
            // 
            // btnSearchTenToa
            // 
            this.btnSearchTenToa.Location = new System.Drawing.Point(875, 150);
            this.btnSearchTenToa.Name = "btnSearchTenToa";
            this.btnSearchTenToa.Size = new System.Drawing.Size(130, 51);
            this.btnSearchTenToa.TabIndex = 38;
            this.btnSearchTenToa.Text = "Tìm kiếm theo tên";
            this.btnSearchTenToa.UseVisualStyleBackColor = true;
            this.btnSearchTenToa.Click += new System.EventHandler(this.btnSearchTenToa_Click);
            // 
            // nupSoPhong
            // 
            this.nupSoPhong.Location = new System.Drawing.Point(471, 46);
            this.nupSoPhong.Name = "nupSoPhong";
            this.nupSoPhong.Size = new System.Drawing.Size(120, 22);
            this.nupSoPhong.TabIndex = 40;
            // 
            // cbMaNguoiQuanLy
            // 
            this.cbMaNguoiQuanLy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbMaNguoiQuanLy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNguoiQuanLy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNguoiQuanLy.FormattingEnabled = true;
            this.cbMaNguoiQuanLy.Location = new System.Drawing.Point(213, 150);
            this.cbMaNguoiQuanLy.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNguoiQuanLy.Name = "cbMaNguoiQuanLy";
            this.cbMaNguoiQuanLy.Size = new System.Drawing.Size(241, 30);
            this.cbMaNguoiQuanLy.TabIndex = 41;
            // 
            // fToaManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 450);
            this.Controls.Add(this.cbMaNguoiQuanLy);
            this.Controls.Add(this.nupSoPhong);
            this.Controls.Add(this.txbSearchTenToa);
            this.Controls.Add(this.btnSearchTenToa);
            this.Controls.Add(this.btnListToa);
            this.Controls.Add(this.btnDeleteToa);
            this.Controls.Add(this.btnEditToa);
            this.Controls.Add(this.btnAddToa);
            this.Controls.Add(this.dtgvToa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMaToa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenToa);
            this.Name = "fToaManage";
            this.Text = "fToaManage";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvToa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupSoPhong)).EndInit();
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
    }
}