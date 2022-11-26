namespace QLSVKTX
{
    partial class fDashboard
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnNhanVienProfile = new System.Windows.Forms.Button();
            this.btnToa = new System.Windows.Forms.Button();
            this.btnPhong = new System.Windows.Forms.Button();
            this.btnHoaDon = new System.Windows.Forms.Button();
            this.btnThietBi = new System.Windows.Forms.Button();
            this.btnSinhVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Location = new System.Drawing.Point(100, 95);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(170, 67);
            this.btnNhanVien.TabIndex = 1;
            this.btnNhanVien.Text = "Quản lý nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnNhanVienProfile
            // 
            this.btnNhanVienProfile.Location = new System.Drawing.Point(311, 95);
            this.btnNhanVienProfile.Name = "btnNhanVienProfile";
            this.btnNhanVienProfile.Size = new System.Drawing.Size(170, 67);
            this.btnNhanVienProfile.TabIndex = 2;
            this.btnNhanVienProfile.Text = "Thông tin cá nhân";
            this.btnNhanVienProfile.UseVisualStyleBackColor = true;
            this.btnNhanVienProfile.Click += new System.EventHandler(this.btnNhanVienProfile_Click);
            // 
            // btnToa
            // 
            this.btnToa.Location = new System.Drawing.Point(524, 95);
            this.btnToa.Name = "btnToa";
            this.btnToa.Size = new System.Drawing.Size(170, 67);
            this.btnToa.TabIndex = 3;
            this.btnToa.Text = "Quản lý toa";
            this.btnToa.UseVisualStyleBackColor = true;
            this.btnToa.Click += new System.EventHandler(this.btnToa_Click);
            // 
            // btnPhong
            // 
            this.btnPhong.Location = new System.Drawing.Point(100, 250);
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(170, 67);
            this.btnPhong.TabIndex = 4;
            this.btnPhong.Text = "Quản lý phòng";
            this.btnPhong.UseVisualStyleBackColor = true;
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // btnHoaDon
            // 
            this.btnHoaDon.Location = new System.Drawing.Point(311, 250);
            this.btnHoaDon.Name = "btnHoaDon";
            this.btnHoaDon.Size = new System.Drawing.Size(170, 67);
            this.btnHoaDon.TabIndex = 5;
            this.btnHoaDon.Text = "Quản lý hóa đơn";
            this.btnHoaDon.UseVisualStyleBackColor = true;
            this.btnHoaDon.Click += new System.EventHandler(this.btnHoaDon_Click);
            // 
            // btnThietBi
            // 
            this.btnThietBi.Location = new System.Drawing.Point(524, 250);
            this.btnThietBi.Name = "btnThietBi";
            this.btnThietBi.Size = new System.Drawing.Size(170, 67);
            this.btnThietBi.TabIndex = 6;
            this.btnThietBi.Text = "Quản lý thiết bị";
            this.btnThietBi.UseVisualStyleBackColor = true;
            this.btnThietBi.Click += new System.EventHandler(this.btnThietBi_Click);
            // 
            // btnSinhVien
            // 
            this.btnSinhVien.Location = new System.Drawing.Point(311, 168);
            this.btnSinhVien.Name = "btnSinhVien";
            this.btnSinhVien.Size = new System.Drawing.Size(170, 67);
            this.btnSinhVien.TabIndex = 7;
            this.btnSinhVien.Text = "Quản lý sinh viên";
            this.btnSinhVien.UseVisualStyleBackColor = true;
            this.btnSinhVien.Click += new System.EventHandler(this.btnSinhVien_Click);
            // 
            // fDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSinhVien);
            this.Controls.Add(this.btnThietBi);
            this.Controls.Add(this.btnHoaDon);
            this.Controls.Add(this.btnPhong);
            this.Controls.Add(this.btnToa);
            this.Controls.Add(this.btnNhanVienProfile);
            this.Controls.Add(this.btnNhanVien);
            this.Name = "fDashboard";
            this.Text = "fDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnNhanVienProfile;
        private System.Windows.Forms.Button btnToa;
        private System.Windows.Forms.Button btnPhong;
        private System.Windows.Forms.Button btnHoaDon;
        private System.Windows.Forms.Button btnThietBi;
        private System.Windows.Forms.Button btnSinhVien;
    }
}