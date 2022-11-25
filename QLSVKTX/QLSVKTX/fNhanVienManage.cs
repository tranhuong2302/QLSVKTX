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
    public partial class fNhanVienManage : Form
    {
        BindingSource nhanVienList = new BindingSource();
        public NhanVien loginNhanVien;
        public fNhanVienManage(NhanVien nhanVien)
        {
            InitializeComponent();
            LoadInfo();
            this.loginNhanVien = nhanVien;
            dtgvNhanVien.Columns["MatKhau"].Visible = true;
        }
        void LoadInfo()
        {
            dtgvNhanVien.DataSource = nhanVienList;
            LoadNhanVien();
            AddNhanVienBinding();
        }
        void LoadNhanVien()
        {
            nhanVienList.DataSource = NhanVienDAO.Instance.GetListNhanVien();
        }
        void AddNhanVienBinding()
        {
            txbMaNV.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "maNV", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "hoTen", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "ngaySinh", true, DataSourceUpdateMode.Never));
            txbSDT.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "sdt", true, DataSourceUpdateMode.Never));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            txbCCCD.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "cccd", true, DataSourceUpdateMode.Never));
            txbChucVu.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
            cbTrangThai.DataBindings.Add(new Binding("Text", dtgvNhanVien.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
        
        }
        void AddNhanVien(string maNV, string hoTen, string ngaySinh, string sdt, string diaChi, string gioiTinh, string cccd, string chucVu, string matKhau, string trangThai)
        {
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
            else if(txbChucVu.Text == null || txbChucVu.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Chức vụ", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (NhanVienDAO.Instance.InsertNhanVien(maNV, hoTen, ngaySinh, sdt, diaChi, gioiTinh, cccd, chucVu, "1", trangThai))
            {
                MessageBox.Show("Thêm nhân viên thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadNhanVien();
        }

        private void btnAddNhanVien_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNV.Text;
            string hoTen = txbHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string convertNgaySinh = ngaySinh.ToString("yyyy-MM-dd");
            string sdt = txbSDT.Text;
            string diaChi = txbDiaChi.Text;
            string gioiTinh = cbGioiTinh.Text;
            string cccd = txbCCCD.Text;
            string chucVu = txbChucVu.Text;
            string trangThai = cbTrangThai.Text;
            AddNhanVien(maNV, hoTen, convertNgaySinh, sdt, diaChi, gioiTinh, cccd, chucVu, "1", trangThai);

        }
        void EditNhanVien(string maNV, string hoTen, string ngaySinh, string sdt, string diaChi, string gioiTinh, string cccd, string chucVu, string trangThai)
        {
            if (txbMaNV.Text == null || txbMaNV.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã Nhân Viên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbHoTen.Text == null || txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Họ Tên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txbSDT.Text == null || txbSDT.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số điện thoại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbSDT.Text.Length != 10)
            {
                MessageBox.Show("Bạn vui lòng nhập đúng định dạng số điện thoại (10 số)", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txbDiaChi.Text == null || txbDiaChi.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Địa Chỉ", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txbCCCD.Text == null || txbCCCD.Text == "")
            {
                MessageBox.Show("Bạn không được để trống CMND/CCCD", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbCCCD.TextLength < 9 || txbCCCD.TextLength == 10 || txbCCCD.TextLength == 11 || txbCCCD.TextLength > 12)
            {
                MessageBox.Show("Bạn vui lòng nhập đúng định dạng CMND(9 số), CCCD(12 số)", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(txbChucVu.Text == null || txbChucVu.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Chức vụ", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (NhanVienDAO.Instance.UpdateNhanVien(maNV, hoTen, ngaySinh, sdt, diaChi, gioiTinh, cccd, chucVu, trangThai))
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thất bại!", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadNhanVien();


        }

        private void btnEditNhanVien_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNV.Text;
            string hoTen = txbHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string convertNgaySinh = ngaySinh.ToString("yyyy-MM-dd");
            string sdt = txbSDT.Text;
            string diaChi = txbDiaChi.Text;
            string gioiTinh = cbGioiTinh.Text;
            string cccd = txbCCCD.Text;
            string chucVu = txbChucVu.Text;
            string trangThai = cbTrangThai.Text;
            EditNhanVien(maNV, hoTen, convertNgaySinh, sdt, diaChi, gioiTinh, cccd, chucVu, trangThai);
        }
        void DeleteNhanVien(string maNV)
        {

            if (MessageBox.Show("Bạn có chắc là xóa nhân viên này?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else {
                if (loginNhanVien.MaNV.Equals(maNV))
                {
                    MessageBox.Show("Bạn không thể xóa bản thân", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (NhanVienDAO.Instance.DeleteNhanVien(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadNhanVien();
            }
        }

        private void btnDeleteNhanVien_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNV.Text;
            DeleteNhanVien(maNV);
        }
        void ResetPasswordNhanVien(string maNV)
        {
            if (MessageBox.Show("Bạn có chắc là muốn đặt lại mật khẩu nhân viên này?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if(txbMaNV.TextLength < 0)
                {
                    MessageBox.Show("Bạn không được để trống Mã Nhân Viên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
                }
                else if (NhanVienDAO.Instance.ResetPassword(maNV))
                {
                    MessageBox.Show("Đặt lại mật khẩu nhân viên thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
             
                LoadNhanVien();
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string maNV = txbMaNV.Text;
            ResetPasswordNhanVien(maNV);
        }
        List<NhanVien> SearchNhanVienByHoTen(string hoTen)
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.SearchNhanVienByHoTen(hoTen);
            return listNhanVien;
        }

        private void btnSearchNhanVienByHoTen_Click(object sender, EventArgs e)
        {
            string hoTen = txbSearchHoTen.Text;
            nhanVienList.DataSource = SearchNhanVienByHoTen(hoTen);
        }

        private void btnListNhanVien_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
    }
}
