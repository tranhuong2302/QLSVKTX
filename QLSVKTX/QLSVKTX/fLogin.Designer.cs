namespace QLSVKTX
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.pbHide = new System.Windows.Forms.PictureBox();
            this.pbView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(447, 178);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(145, 38);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(331, 65);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(100, 22);
            this.txbMaNV.TabIndex = 1;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(331, 135);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(100, 22);
            this.txbMatKhau.TabIndex = 2;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // pbHide
            // 
            this.pbHide.BackColor = System.Drawing.Color.Transparent;
            this.pbHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHide.Image = ((System.Drawing.Image)(resources.GetObject("pbHide.Image")));
            this.pbHide.Location = new System.Drawing.Point(385, 210);
            this.pbHide.Margin = new System.Windows.Forms.Padding(4);
            this.pbHide.Name = "pbHide";
            this.pbHide.Size = new System.Drawing.Size(31, 30);
            this.pbHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHide.TabIndex = 18;
            this.pbHide.TabStop = false;
            this.pbHide.Click += new System.EventHandler(this.pbHide_Click);
            // 
            // pbView
            // 
            this.pbView.BackColor = System.Drawing.Color.Transparent;
            this.pbView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbView.Image = ((System.Drawing.Image)(resources.GetObject("pbView.Image")));
            this.pbView.Location = new System.Drawing.Point(385, 210);
            this.pbView.Margin = new System.Windows.Forms.Padding(4);
            this.pbView.Name = "pbView";
            this.pbView.Size = new System.Drawing.Size(31, 30);
            this.pbView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbView.TabIndex = 19;
            this.pbView.TabStop = false;
            this.pbView.Click += new System.EventHandler(this.pbView_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbView);
            this.Controls.Add(this.pbHide);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.btnLogin);
            this.Name = "fLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.PictureBox pbHide;
        private System.Windows.Forms.PictureBox pbView;
    }
}

