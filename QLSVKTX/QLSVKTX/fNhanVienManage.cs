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
            dtgvNhanVien.Columns["MatKhau"].Visible = false;
            dtgvNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dtgvNhanVien.Columns[1].HeaderText = "Họ và Tên";
            dtgvNhanVien.Columns[2].HeaderText = "Ngày sinh";
            dtgvNhanVien.Columns[3].HeaderText = "Số ĐT";
            dtgvNhanVien.Columns[4].HeaderText = "Địa chỉ";
            dtgvNhanVien.Columns[5].HeaderText = "Giới tính";
            dtgvNhanVien.Columns[6].HeaderText = "Số CCCD";
            dtgvNhanVien.Columns[7].HeaderText = "Chức vụ";
            dtgvNhanVien.Columns[8].HeaderText = "Vai trò";
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Nhân Viên";

            cl1.ColumnWidth = 14;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Họ Và Tên";

            cl2.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Ngày Sinh";
            cl3.ColumnWidth = 18.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Số Điện Thoại";

            cl4.ColumnWidth = 12;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Địa Chỉ";

            cl5.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Giới Tính";

            cl6.ColumnWidth = 16;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Số CMND";

            cl7.ColumnWidth = 15;
            Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

            cl8.Value2 = "Chức Vụ";

            cl8.ColumnWidth = 30;
            Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

            cl9.Value2 = "Vai Trò";

            cl9.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

            cl10.Value2 = "Trạng Thái";

            cl10.ColumnWidth = 20;


            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");

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

            DataColumn col1 = new DataColumn("MaNhanVien");
            DataColumn col2 = new DataColumn("HoTen");
            DataColumn col3 = new DataColumn("NgaySinh");
            DataColumn col4 = new DataColumn("SoDienThoai");
            DataColumn col5 = new DataColumn("DiaChi");
            DataColumn col6 = new DataColumn("GioiTinh");
            DataColumn col7 = new DataColumn("CMND_CCCD");
            DataColumn col8 = new DataColumn("ChucVu");
            DataColumn col9 = new DataColumn("VaiTro");
            DataColumn col10 = new DataColumn("TrangThai");

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

            foreach (DataGridViewRow dtgvRow in dtgvNhanVien.Rows)
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


                dataTable.Rows.Add(dtRow);
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportFile(dataTable, "danh sach", "Quản lý Nhân viên", saveFileDialog.FileName);
            }
        }
    }
}
