using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QLSVKTX.DAO;
using QLSVKTX.DTO;

namespace QLSVKTX
{
    public partial class fSinhVienManage : Form
    {
        BindingSource sinhVienList = new BindingSource();
        public fSinhVienManage()
        {
            InitializeComponent();
            LoadInfo();
            LoadPhongIntoCombobox(cbMaPhong);
        }
        void LoadInfo()
        {
            dtgvSinhVien.DataSource = sinhVienList;
            LoadSinhVien();
            AddSinhVienBinding();
        }
        void LoadSinhVien()
        {
            sinhVienList.DataSource = SinhVienDAO.Instance.GetListSinhVien();
        }
        void AddSinhVienBinding()
        {
            txbMaSV.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            txbHoTen.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            cbGioiTinh.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            nupNamHoc.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "NamHoc", true, DataSourceUpdateMode.Never));
            txbSDT.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txbDiaChi.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            txbCCCD.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "cccd", true, DataSourceUpdateMode.Never));
            dtpNgayLamHopDong.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "NgayLamHopDong", true, DataSourceUpdateMode.Never));
            dtpNgayKetThucHopDong.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "NgayKetThucHopDong", true, DataSourceUpdateMode.Never));
            cbKhoa.DataBindings.Add(new Binding("Text", dtgvSinhVien.DataSource, "Khoa", true, DataSourceUpdateMode.Never));
        }
        void LoadToaByMaToa(string maToa)
        {
            Toa toa = ToaDAO.Instance.GetToaByMaToa(maToa);
            txbToa.Text = toa.TenToa.ToString();
            
        }
        void LoadPhongIntoCombobox(ComboBox cb)
        {
            cb.DataSource = PhongDAO.Instance.GetListPhong();
            cb.DisplayMember = "MaPhong";
        }
        private void txbMaSV_TextChanged(object sender, EventArgs e)
        {
            if (dtgvSinhVien.SelectedCells.Count > 0)
            {
                if (dtgvSinhVien.SelectedCells[0].OwningRow.Cells["MaPhong"].Value != null)
                {
                    string maPhong = dtgvSinhVien.SelectedCells[0].OwningRow.Cells["MaPhong"].Value.ToString();
                    Phong phong = PhongDAO.Instance.GetPhongByMaPhong(maPhong);
                    cbMaPhong.SelectedItem = phong;
                    ComboBox cb = sender as ComboBox;
                    
                    if (phong != null)
                    {
                        LoadToaByMaToa(phong.MaToa);
                    }
                    
                    int index = -1;
                    int i = 0;
                    foreach (Phong item in cbMaPhong.Items)
                    {
                        if (phong != null)
                        {
                            if (item.MaPhong == phong.MaPhong)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }

                    }

                    cbMaPhong.SelectedIndex = index;
                }
            }
        }
        public static bool hasSpecialChar(string input)
        {
            string specialChar = @"\|!#$%&/()=?»«@£§€{}.-;'<>_,";
            foreach (var item in specialChar)
            {
                if (input.Contains(item)) return true;
            }

            return false;
        }

        void AddSinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, int namHoc, string sdt, string diaChi, string cccd, string ngayLamHopDong, string ngayKetThucHopDong, string maPhong, string khoa)
        {
            Phong phong = PhongDAO.Instance.GetPhongByMaPhong(maPhong);
            if (txbMaSV.Text == null || txbMaSV.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã sinh viên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbHoTen.Text == null || txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Họ Tên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbSDT.Text == null || txbSDT.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số điện thoại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(Regex.IsMatch(txbSDT.Text, @"^[a-zA-Z]+$") || hasSpecialChar(txbSDT.Text))
            {
                MessageBox.Show("Không được nhập chữ hoặc kí tự đặc biệt", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if(phong.SoLuongSinhVienHienTai >= phong.SoLuongSinhVienToiDa)
            {
                MessageBox.Show("Phòng bạn chọn đã hết chỗ xin vui lòng chọn phòng khác", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SinhVienDAO.Instance.InsertSinhVien(maSV, hoTen, ngaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, ngayLamHopDong, ngayKetThucHopDong, maPhong, khoa))
            {
                MessageBox.Show("Thêm sinh viên thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("Thêm sinh viên thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maSV = txbMaSV.Text;
            string hoTen = txbHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string convertNgaySinh = ngaySinh.ToString("yyyy-MM-dd");
            string gioiTinh = cbGioiTinh.Text;
            int namHoc = Convert.ToInt32(nupNamHoc.Value);
            string sdt = txbSDT.Text;
            string diaChi = txbDiaChi.Text;
            string cccd = txbCCCD.Text;
            DateTime ngayLamHopDong = dtpNgayLamHopDong.Value;
            string convertNgayLamHopDong = ngayLamHopDong.ToString("yyyy-MM-dd");
            DateTime ngayKetThucHopDong = dtpNgayKetThucHopDong.Value;
            string convertNgayKetThucHopDong = ngayKetThucHopDong.ToString("yyyy-MM-dd");
            string khoa = cbKhoa.Text;
            if (cbMaPhong.SelectedItem as Phong == null)
            {
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                AddSinhVien(maSV, hoTen, convertNgaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, convertNgayLamHopDong, convertNgayKetThucHopDong, maPhong, khoa);
            }

        }
        void EditSinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, int namHoc, string sdt, string diaChi, string cccd, string ngayLamHopDong, string ngayKetThucHopDong, string maPhong, string khoa)
        {
            if (txbMaSV.Text == null || txbMaSV.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã sinh viên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbHoTen.Text == null || txbHoTen.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Họ Tên", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbSDT.Text == null || txbSDT.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số điện thoại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (Regex.IsMatch(txbSDT.Text, @"^[a-zA-Z]+$") || hasSpecialChar(txbSDT.Text))
            {
                MessageBox.Show("Không được nhập chữ hoặc kí tự đặc biệt", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else if (SinhVienDAO.Instance.UpdateSinhVien(maSV, hoTen, ngaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, ngayLamHopDong, ngayKetThucHopDong, maPhong, khoa))
            {
                MessageBox.Show("Thay đổi thông tin sinh viên thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("thay đổi thông tin sinh viên thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadSinhVien();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maSV = txbMaSV.Text;
            string hoTen = txbHoTen.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string convertNgaySinh = ngaySinh.ToString("yyyy-MM-dd");
            string gioiTinh = cbGioiTinh.Text;
            int namHoc = Convert.ToInt32(nupNamHoc.Value);
            string sdt = txbSDT.Text;
            string diaChi = txbDiaChi.Text;
            string cccd = txbCCCD.Text;
            DateTime ngayLamHopDong = dtpNgayLamHopDong.Value;
            string convertNgayLamHopDong = ngayLamHopDong.ToString("yyyy-MM-dd");
            DateTime ngayKetThucHopDong = dtpNgayKetThucHopDong.Value;
            string convertNgayKetThucHopDong = ngayKetThucHopDong.ToString("yyyy-MM-dd");
            string khoa = cbKhoa.Text;
            if (cbMaPhong.SelectedItem as Phong == null)
            {
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                EditSinhVien(maSV, hoTen, convertNgaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, convertNgayLamHopDong, convertNgayKetThucHopDong, maPhong, khoa);
            }
        }
        void DeleteSinhVien(string maSV)
        {
            if (MessageBox.Show("Bạn có chắc là xóa sinh viên này?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                
                if (SinhVienDAO.Instance.DeleteSinhVienByMaSinhVien(maSV))
                {
                    MessageBox.Show("Xóa thành công thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadSinhVien();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSV = txbMaSV.Text;
            DeleteSinhVien(maSV);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadSinhVien();
        }
        List<SinhVien> SearchSinhVienByHoTen(string hoTen)
        {
            List<SinhVien> listSinhVien = SinhVienDAO.Instance.SearchSinhVienByHoTen(hoTen);
            return listSinhVien;
        }
        private void btnSearchByHoTen_Click(object sender, EventArgs e)
        {
            string hoTen = txbSearchHoTen.Text;
            sinhVienList.DataSource = SearchSinhVienByHoTen(hoTen);
        }
        List<SinhVien> SearchSinhVienByMaSV(string maSV)
        {
            List<SinhVien> listSinhVien = SinhVienDAO.Instance.SearchSinhVienByMaSinhVien(maSV);
            return listSinhVien;
        }
        private void btnSearchByMaSV_Click(object sender, EventArgs e)
        {
            string maSV = txbSearchByMaSV.Text;
            sinhVienList.DataSource = SearchSinhVienByMaSV(maSV);
        }
        List<SinhVien> SearchSinhVienByMaPhong(string maPhong)
        {
            List<SinhVien> listSinhVien = SinhVienDAO.Instance.SearchSinhVienByMaPhong(maPhong);
            return listSinhVien;
        }

        private void btnSearchByMaPhong_Click(object sender, EventArgs e)
        {
            string maPhong = txbSeachByMaPhong.Text;
            sinhVienList.DataSource = SearchSinhVienByMaPhong(maPhong);
        }
        void KetThucHopDong(string maSV, string ngayKetThucHopDong)
        {
            if (MessageBox.Show("Bạn có chắc là muốn kết thúc hợp đồng?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {

                if (SinhVienDAO.Instance.UpdateNgayKetThucHopDongToNull(maSV, ngayKetThucHopDong))
                {
                    MessageBox.Show("Kết thúc hợp đồng thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Kết thúc hợp đồng thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadSinhVien();
            }
        }
        private void btnNullNgayKetThucHopDong_Click(object sender, EventArgs e)
        {
            string maSV = txbMaSV.Text;
            DateTime ngayKetThucHopDong = DateTime.Now;
            string convertNgayKetThucHopDong = ngayKetThucHopDong.ToString("yyyy-MM-dd");
            KetThucHopDong(maSV, convertNgayKetThucHopDong);
        }
    } 
}
