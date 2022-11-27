using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSVKTX.DTO;
using QLSVKTX.DAO;
namespace QLSVKTX
{
    public partial class fNhanVienProfile : Form
    {
        private NhanVien loginNhanVien;

        public NhanVien LoginNhanVien 
        {
            get { return loginNhanVien; }
            set { loginNhanVien = value; ChangeNhanVien(loginNhanVien); }
        }

        public fNhanVienProfile(NhanVien nhanVien)
        {
            InitializeComponent();
            this.LoginNhanVien = nhanVien;
        }
        void ChangeNhanVien(NhanVien nhanVien)
        {
            txbMaNV.Text = nhanVien.MaNV;
            txbHoTen.Text = nhanVien.HoTen;
            dtpNgaySinh.Value = nhanVien.NgaySinh;
            txbSDT.Text = nhanVien.Sdt;
            txbDiaChi.Text = nhanVien.DiaChi;
            cbGioiTinh.Text = nhanVien.GioiTinh;
            txbCCCD.Text = nhanVien.Cccd;
            txbChucVu.Text = nhanVien.ChucVu;
        }
        void UpdateProfileNhanVien()
        {
            string maNV = txbMaNV.Text;
            string matKhau = txbMatKhau.Text;
            string hoTen = txbHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string convertNgaySinh = ngaySinh.ToString("yyyy-MM-dd");
            string sdt = txbSDT.Text;
            string diaChi = txbDiaChi.Text;
            string gioiTinh = cbGioiTinh.Text;
            string cccd = txbCCCD.Text;
            string chucVu = txbChucVu.Text;

            if (txbMaNV.Text == null || txbMaNV.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã Nhân Viên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbHoTen.Text == null || txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Họ Tên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbSDT.Text == null || txbSDT.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số điện thoại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbSDT.Text.Length != 10)
            {
                MessageBox.Show("Bạn vui lòng nhập đúng định dạng số điện thoại (10 số)", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbDiaChi.Text == null || txbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Địa Chỉ", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbCCCD.Text == null || txbCCCD.Text == "")
            {
                MessageBox.Show("Bạn không được để trống CMND/CCCD", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbCCCD.TextLength < 9 || txbCCCD.TextLength == 10 || txbCCCD.TextLength == 11 || txbCCCD.TextLength > 12)
            {
                MessageBox.Show("Bạn vui lòng nhập đúng định dạng CMND(9 số), CCCD(12 số)", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbChucVu.Text == null || txbChucVu.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Chức vụ", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (NhanVienDAO.Instance.ChangeProfileNhanVien(maNV, matKhau, hoTen, convertNgaySinh, sdt, diaChi, gioiTinh, cccd, chucVu))
            {
                MessageBox.Show("Thay đổi thông tin thành công bạn hãy đăng nhập lại để cập nhật thông tin tài khoản", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if(matKhau == ""){
                MessageBox.Show("Không được để trống mật khẩu", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn nhập sai mật khẩu", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UpdateProfileNhanVien();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            fDoiMatKhau f = new fDoiMatKhau(LoginNhanVien);
            f.ShowDialog();
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
