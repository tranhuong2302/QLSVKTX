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
    public partial class fDoiMatKhau : Form
    {
        private NhanVien loginNhanVien;

        public fDoiMatKhau(NhanVien nhanVien)
        {
            InitializeComponent();
            this.LoginNhanVien = nhanVien;
        }
        public NhanVien LoginNhanVien { get => loginNhanVien; set => loginNhanVien = value; }

        //Hàm cập nhật mật khẩu mới
        void DoiMatKhauNhanVien()
        {
            string maNV = this.LoginNhanVien.MaNV;
            string matKhau = txbMatKhauCu.Text;
            string matKhauMoi = txbMatKhauMoi.Text;
            string nhapLaiMatKhau = txbNhapLaiMatKhau.Text;
            if (!matKhauMoi.Equals(nhapLaiMatKhau))
            {
                MessageBox.Show("Nhập lại mật khẩu không trùng với mật khẩu mới", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (matKhauMoi == "" || matKhauMoi == null || nhapLaiMatKhau == null || nhapLaiMatKhau == "")
            {

                MessageBox.Show("Mật khẩu mới không được để trống", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (NhanVienDAO.Instance.DoiMatKhauByMaNhanVien(maNV, matKhau, matKhauMoi))
                {
                    MessageBox.Show("Thay đổi mật khẩu thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Xin hãy nhập đúng mật khẩu củ", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void pbHide_Click(object sender, EventArgs e)
        {
            if (txbMatKhauCu.UseSystemPasswordChar == false || txbMatKhauMoi.UseSystemPasswordChar == false || txbNhapLaiMatKhau.UseSystemPasswordChar == false)
            {
                pbView.BringToFront();
                txbMatKhauCu.UseSystemPasswordChar = true;
                txbMatKhauMoi.UseSystemPasswordChar = true;
                txbNhapLaiMatKhau.UseSystemPasswordChar = true;
            }
        }

        private void pbView_Click(object sender, EventArgs e)
        {
            if (txbMatKhauCu.UseSystemPasswordChar == true || txbMatKhauMoi.UseSystemPasswordChar == true || txbNhapLaiMatKhau.UseSystemPasswordChar == true)
            {
                pbHide.BringToFront();
                txbMatKhauCu.UseSystemPasswordChar = false;
                txbMatKhauMoi.UseSystemPasswordChar = false;
                txbNhapLaiMatKhau.UseSystemPasswordChar = false;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DoiMatKhauNhanVien();
        }
    }
}
