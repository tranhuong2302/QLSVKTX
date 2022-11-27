using System;
using System.IO;
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
            dtgvSinhVien.Columns[0].HeaderText = "Mã SV";
            dtgvSinhVien.Columns[1].HeaderText = "Họ Tên";
            dtgvSinhVien.Columns[2].HeaderText = "Ngày sinh";
            dtgvSinhVien.Columns[3].HeaderText = "Giới tính";
            dtgvSinhVien.Columns[4].HeaderText = "Năm học";
            dtgvSinhVien.Columns[5].HeaderText = "Số ĐT";
            dtgvSinhVien.Columns[6].HeaderText = "Địa chỉ";
            dtgvSinhVien.Columns[7].HeaderText = "CCCD";
            dtgvSinhVien.Columns[8].HeaderText = "Ngày làm HĐ";
            dtgvSinhVien.Columns[9].HeaderText = "Ngày kết thúc HĐ";
            dtgvSinhVien.Columns[10].HeaderText = "Mã Phòng";
            dtgvSinhVien.Columns[11].HeaderText = "Khoa";

        }
        void LoadInfo()
        {
            dtgvSinhVien.DataSource = sinhVienList;
            LoadSinhVien();
            LoadPhongIntoCombobox(cbMaPhong);
          
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

        void LoadPhongIntoCombobox(ComboBox cb)
        {
            cb.DataSource = PhongDAO.Instance.GetListPhong();
            cb.DisplayMember = "TenPhong";
        }
        void LoadToaIntoTextBox(string maToa)
        {
            Toa toa = ToaDAO.Instance.GetToaByMaToa(maToa);
            if (toa != null)
                txbToa.Text = toa.TenToa.ToString();
            else txbToa.Text = "";
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
                    if (phong != null)
                    {
                        LoadToaIntoTextBox(phong.MaToa);
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
            else if (phong.TinhTrangPhong == "Bảo trì")
            {
                MessageBox.Show("Phòng hiện tại đang bảo trì xin vui lòng chọn phòng khác", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbGioiTinh.Text != phong.LoaiPhong)
            {
                MessageBox.Show("Không được ở phòng khác giới", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(phong.SoLuongSinhVienHienTai >= phong.SoLuongSinhVienToiDa)
            {
                MessageBox.Show("Phòng bạn chọn đã hết chỗ xin vui lòng chọn phòng khác", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SinhVienDAO.Instance.InsertSinhVien(maSV, hoTen, ngaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, ngayLamHopDong, ngayKetThucHopDong, maPhong, khoa))
            {
                PhongDAO.Instance.UpdateSoLuongHienTaiCongMot(maPhong);
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
            Phong phong = PhongDAO.Instance.GetPhongByMaPhong(maPhong);
            SinhVien sinhVien = SinhVienDAO.Instance.GetSinhVienByMaSinhVien(maSV);
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
            else if (phong.TinhTrangPhong == "Bảo trì")
            {
                MessageBox.Show("Phòng hiện tại đang bảo trì xin vui lòng chọn phòng khác", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (cbGioiTinh.Text != phong.LoaiPhong)
            {
                MessageBox.Show("Không được ở phòng khác giới", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (phong.SoLuongSinhVienHienTai >= phong.SoLuongSinhVienToiDa)
            {
                MessageBox.Show("Phòng bạn chọn đã hết chỗ xin vui lòng chọn phòng khác", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (SinhVienDAO.Instance.UpdateSinhVien(maSV, hoTen, ngaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, ngayLamHopDong, ngayKetThucHopDong, maPhong, khoa))
            {
                PhongDAO.Instance.UpdateSoLuongHienTaiTruMot(sinhVien.MaPhong);
                PhongDAO.Instance.UpdateSoLuongHienTaiCongMot(maPhong);
                MessageBox.Show("Thay đổi thông tin sinh viên thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSinhVien();
            }
            else
            {
                MessageBox.Show("thay đổi thông tin sinh viên thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        void DeleteSinhVien(string maSV, string maPhong)
        {
            if (MessageBox.Show("Bạn có chắc là xóa sinh viên này?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                
                if (SinhVienDAO.Instance.DeleteSinhVienByMaSinhVien(maSV))
                {
                    PhongDAO.Instance.UpdateSoLuongHienTaiTruMot(maPhong);
                    MessageBox.Show("Xóa thành công thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSinhVien();

                }
                else
                {
                    MessageBox.Show("Xóa sinh viên thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maSV = txbMaSV.Text;
            Phong phong = cbMaPhong.SelectedItem as Phong;
            DeleteSinhVien(maSV, phong.MaPhong);
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
        void KetThucHopDong(string maSV, string ngayKetThucHopDong, string maPhong)
        {
            if (MessageBox.Show("Bạn có chắc là muốn kết thúc hợp đồng?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {

                if (SinhVienDAO.Instance.UpdateNgayKetThucHopDongToNull(maSV, ngayKetThucHopDong))
                {
                    PhongDAO.Instance.UpdateSoLuongHienTaiTruMot(maPhong);
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
            Phong phong = cbMaPhong.SelectedItem as Phong;
            DateTime ngayKetThucHopDong = DateTime.Now;
            string convertNgayKetThucHopDong = ngayKetThucHopDong.ToString("yyyy-MM-dd");
            KetThucHopDong(maSV, convertNgayKetThucHopDong, phong.MaPhong);
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ExportFile(DataTable dataTable, string sheetName, string title, string filename)
        {
            //Tạo các đối tượng Excel

            Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

            Microsoft.Office.Interop.Excel.Workbooks oBooks;

            Microsoft.Office.Interop.Excel.Sheets oSheets;

            Microsoft.Office.Interop.Excel.Workbook oBook;

            Microsoft.Office.Interop.Excel.Worksheet oSheet;

            //Tạo mới một Excel WorkBook 

            oExcel.Application.SheetsInNewWorkbook = 1;

            oBooks = oExcel.Workbooks;

            oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

            oSheets = oBook.Worksheets;

            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

            oSheet.Name = sheetName;

            // Tạo phần Tiêu đề
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "L1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Sinh Viên";

            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ Và Tên";

            cl2.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày Sinh";
            cl3.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Giới Tính";

            cl4.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Năm Học";

            cl5.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Số Điện Thoại";

            cl6.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Địa Chỉ";

            cl7.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Số CNMD";

            cl8.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Ngày Làm Hợp Đồng";

            cl9.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "Ngày Kết Thúc Hợp Đồng";

            cl10.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

            cl11.Value2 = "Mã Phòng";

            cl11.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

            cl12.Value2 = "Khoa";

            cl12.ColumnWidth = 18;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "L3");

            rowHead.Font.Bold = true;

            // Kẻ viền

            rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Thiết lập màu nền

            rowHead.Interior.ColorIndex = 6;

            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo mảng theo datatable

            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            //Chuyển dữ liệu từ DataTable vào mảng đối tượng

            for (int row = 0; row < dataTable.Rows.Count; row++)
            {
                DataRow dataRow = dataTable.Rows[row];

                for (int col = 0; col < dataTable.Columns.Count; col++)
                {
                    arr[row, col] = dataRow[col];
                }
            }

            //Thiết lập vùng điền dữ liệu

            int rowStart = 4;

            int columnStart = 1;

            int rowEnd = rowStart + dataTable.Rows.Count - 2;

            int columnEnd = dataTable.Columns.Count;

            // Ô bắt đầu điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

            // Ô kết thúc điền dữ liệu

            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

            // Lấy về vùng điền dữ liệu

            Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

            //Điền dữ liệu vào vùng đã thiết lập

            range.Value2 = arr;

            // Kẻ viền

            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

            // Căn giữa cột mã nhân viên

            //Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

            //Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

            //Căn giữa cả bảng 
            //oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            oExcel.ActiveWorkbook.SaveAs(filename);
            oExcel.ActiveWorkbook.Saved = true;
            oExcel.Quit();
            MessageBox.Show("Xuất danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            DataColumn col1 = new DataColumn("MaSinhVien");
            DataColumn col2 = new DataColumn("HoTen");
            DataColumn col3 = new DataColumn("NgaySinh");
            DataColumn col4 = new DataColumn("GioiTinh");
            DataColumn col5 = new DataColumn("NamHoc");
            DataColumn col6 = new DataColumn("SoDienThoai");
            DataColumn col7 = new DataColumn("DiaChi");
            DataColumn col8 = new DataColumn("CMND_CCCD");
            DataColumn col9 = new DataColumn("NgayLamHopDong");
            DataColumn col10 = new DataColumn("NgayKetThucHopDong");
            DataColumn col11 = new DataColumn("MaPhong");
            DataColumn col12 = new DataColumn("Khoa");

            dataTable.Columns.Add(col1);
            dataTable.Columns.Add(col2);
            dataTable.Columns.Add(col3);
            dataTable.Columns.Add(col4);
            dataTable.Columns.Add(col5);
            dataTable.Columns.Add(col6);
            dataTable.Columns.Add(col7);
            dataTable.Columns.Add(col8);
            dataTable.Columns.Add(col9);
            dataTable.Columns.Add(col10);
            dataTable.Columns.Add(col11);
            dataTable.Columns.Add(col12);

            foreach (DataGridViewRow dtgvRow in dtgvSinhVien.Rows)
            {
                DataRow dtRow = dataTable.NewRow();

                dtRow[0] = dtgvRow.Cells[0].Value;
                dtRow[1] = dtgvRow.Cells[1].Value;
                dtRow[2] = dtgvRow.Cells[2].Value;
                dtRow[3] = dtgvRow.Cells[3].Value;
                dtRow[4] = dtgvRow.Cells[4].Value;
                dtRow[5] = dtgvRow.Cells[5].Value;
                dtRow[6] = dtgvRow.Cells[6].Value;
                dtRow[7] = dtgvRow.Cells[7].Value;
                dtRow[8] = dtgvRow.Cells[8].Value;
                dtRow[9] = dtgvRow.Cells[9].Value;
                dtRow[10] = dtgvRow.Cells[10].Value;
                dtRow[11] = dtgvRow.Cells[11].Value;

                dataTable.Rows.Add(dtRow);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportFile(dataTable, "danh sach", "Quản lý Sinh viên", saveFileDialog.FileName);
            }
        }
    } 
}
