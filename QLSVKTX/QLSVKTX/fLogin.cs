using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSVKTX.DAO;
using QLSVKTX.DTO;
namespace QLSVKTX
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        bool Login(string maNV, string MatKhau)
        {
            return NhanVienDAO.Instance.Login(maNV, MatKhau);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNV.Text;
            string MatKhau = txbMatKhau.Text;
            if(Login(maNV, MatKhau))
            {
                NhanVien loginNhanVien = NhanVienDAO.Instance.GetNhanVienByMaNhanVien(maNV);
                fDashboard f = new fDashboard(loginNhanVien);
                if (loginNhanVien.TrangThai == "Khóa")
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khóa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai tài khoản hoặc mật khẩu.", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void pbView_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.UseSystemPasswordChar == true)
            {
                pbHide.BringToFront();
                txbMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void pbHide_Click(object sender, EventArgs e)
        {
            if (txbMatKhau.UseSystemPasswordChar == false)
            {
                pbView.BringToFront();
                txbMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
