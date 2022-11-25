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
            // fDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}