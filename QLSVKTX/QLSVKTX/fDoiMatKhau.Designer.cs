namespace QLSVKTX
{
    partial class fDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDoiMatKhau));
            this.pbView = new System.Windows.Forms.PictureBox();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMatKhauCu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMatKhauMoi = new System.Windows.Forms.TextBox();
            this.txbNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            this.SuspendLayout();
            // 
            // pbView
            // 
            this.pbView.BackColor = System.Drawing.Color.Transparent;
            this.pbView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbView.Image = ((System.Drawing.Image)(resources.GetObject("pbView.Image")));
            this.pbView.Location = new System.Drawing.Point(419, 158);
            this.pbView.Margin = new System.Windows.Forms.Padding(4);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(31, 30);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbView.TabIndex = 50;
            this.pbView.TabStop = false;
            this.pbView.Click += new System.EventHandler(this.pbView_Click);
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.Transparent;
            this.pbHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHide.Image = ((System.Drawing.Image)(resources.GetObject("pbHide.Image")));
            this.pbHide.Location = new System.Drawing.Point(419, 158);
            this.pbHide.Margin = new System.Windows.Forms.Padding(4);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(31, 30);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHide.TabIndex = 49;
            this.pbHide.TabStop = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(184, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "matkhaucu";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbMatKhauCu
            // 
            this.txbMatKhauCu.Location = new System.Drawing.Point(285, 104);
            this.txbMatKhauCu.Name = "txbMatKhauCu";
            this.txbMatKhauCu.Size = new System.Drawing.Size(100, 22);
            this.txbMatKhauCu.TabIndex = 47;
            this.txbMatKhauCu.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "matkhaumoi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "nhap lai mat khau";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txbMatKhauMoi
            // 
            this.txbMatKhauMoi.Location = new System.Drawing.Point(285, 166);
            this.txbMatKhauMoi.Name = "txbMatKhauMoi";
            this.txbMatKhauMoi.Size = new System.Drawing.Size(100, 22);
            this.txbMatKhauMoi.TabIndex = 53;
            this.txbMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // txbNhapLaiMatKhau
            // 
            this.txbNhapLaiMatKhau.Location = new System.Drawing.Point(285, 232);
            this.txbNhapLaiMatKhau.Name = "txbNhapLaiMatKhau";
            this.txbNhapLaiMatKhau.Size = new System.Drawing.Size(100, 22);
            this.txbNhapLaiMatKhau.TabIndex = 54;
            this.txbNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(249, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(145, 38);
            this.btnSubmit.TabIndex = 55;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txbNhapLaiMatKhau);
            this.Controls.Add(this.txbMatKhauMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbView);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txbMatKhauCu);
            this.Name = "fDoiMatKhau";
            this.Text = "fDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbView;
        private System.Windows.Forms.PictureBox pbHide;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMatKhauCu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMatKhauMoi;
        private System.Windows.Forms.TextBox txbNhapLaiMatKhau;
        private System.Windows.Forms.Button btnSubmit;
    }
}