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
    public partial class fHoaDonManage : Form
    {
        BindingSource hoaDonList = new BindingSource();
        public fHoaDonManage()
        {
            InitializeComponent();
            LoadInfo();
            LoadPhongIntoCombobox(cbMaPhong);
            dtgvHoaDon.Columns[0].HeaderText = "Mã Hóa đơn";
            dtgvHoaDon.Columns[1].HeaderText = "Mã Phòng";
            dtgvHoaDon.Columns[2].HeaderText = "Tên Hóa đơn";
            dtgvHoaDon.Columns[3].HeaderText = "Trạng Thái";
            dtgvHoaDon.Columns[4].HeaderText = "Tiền điện";
            dtgvHoaDon.Columns[5].HeaderText = "Tiền nước";
            dtgvHoaDon.Columns[6].HeaderText = "Ngày Tạo";

        }
        void LoadHoaDon()
        {
            hoaDonList.DataSource = HoaDonDienNuocDAO.Instance.GetListHoaDon();
        }
        void LoadInfo()
        {
            dtgvHoaDon.DataSource = hoaDonList;
            LoadHoaDon();
            AddHoaDonBinding();
        }
        void AddHoaDonBinding()
        {
            txbMaHoaDon.DataBindings.Add(new Binding("Text", dtgvHoaDon.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never));
            cbMaPhong.DataBindings.Add(new Binding("Text", dtgvHoaDon.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txbTenHoaDon.DataBindings.Add(new Binding("Text", dtgvHoaDon.DataSource, "TenHoaDon", true, DataSourceUpdateMode.Never));
            cbTrangThai.DataBindings.Add(new Binding("Text", dtgvHoaDon.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
            nupTienDien.DataBindings.Add(new Binding("Text", dtgvHoaDon.DataSource, "TienDien", true, DataSourceUpdateMode.Never));
            nupTienNuoc.DataBindings.Add(new Binding("Text", dtgvHoaDon.DataSource, "TienNuoc", true, DataSourceUpdateMode.Never));
            dtpNgayTao.DataBindings.Add(new Binding("Text", dtgvHoaDon.DataSource, "ngayTao", true, DataSourceUpdateMode.Never));

        }
        void LoadPhongIntoCombobox(ComboBox cb)
        {
            cb.DataSource = PhongDAO.Instance.GetListPhong();
            cb.DisplayMember = "TenPhong";
        }
        private void txbMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            if (dtgvHoaDon.SelectedCells.Count > 0)
            {
                if (dtgvHoaDon.SelectedCells[0].OwningRow.Cells["MaPhong"].Value != null)
                {
                    string maPhong = dtgvHoaDon.SelectedCells[0].OwningRow.Cells["MaPhong"].Value.ToString();
                    Phong phong = PhongDAO.Instance.GetPhongByMaPhong(maPhong);
                    cbMaPhong.SelectedItem = phong;

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
        void AddHoaDon(string maPhong, string tenHoaDon, string trangThai, float tienDien, float tienNuoc, string ngayTao)
        {
            if (txbTenHoaDon.Text == null || txbTenHoaDon.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienDien.Text == null || nupTienDien.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền điện", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienNuoc.Text == null || nupTienNuoc.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền nước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (HoaDonDienNuocDAO.Instance.InsertHoaDon(maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, ngayTao))
            {
                MessageBox.Show("Thêm hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadHoaDon();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenHoaDon = txbTenHoaDon.Text;
            string trangThai = cbTrangThai.Text;
            float tienDien = (float)Convert.ToDouble(nupTienDien.Value);
            float tienNuoc = (float)Convert.ToDouble(nupTienNuoc.Value);
            DateTime ngayTao = dtpNgayTao.Value;
            string convertNgayTao = ngayTao.ToString("yyyy-MM-dd");
            if (cbMaPhong.SelectedItem as Phong == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                AddHoaDon(maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, convertNgayTao);
            }
        }

        void EditHoaDon(int maHoaDon, string maPhong, string tenHoaDon, string trangThai, float tienDien, float tienNuoc, string ngayTao)
        {
            if (txbMaHoaDon.Text == null || txbMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn không được để trống má hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txbTenHoaDon.Text == null || txbTenHoaDon.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienDien.Text == null || nupTienDien.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền điện", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienNuoc.Text == null || nupTienNuoc.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền nước", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (HoaDonDienNuocDAO.Instance.UpdateHoaDon(maHoaDon, maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, ngayTao))
            {
                MessageBox.Show("Thay đổi thông tin hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadHoaDon();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int maHoaDon = Convert.ToInt32(txbMaHoaDon.Text);
            string tenHoaDon = txbTenHoaDon.Text;
            string trangThai = cbTrangThai.Text;
            float tienDien = (float)Convert.ToDouble(nupTienDien.Value);
            float tienNuoc = (float)Convert.ToDouble(nupTienNuoc.Value);
            DateTime ngayTao = dtpNgayTao.Value;
            string convertNgayTao = ngayTao.ToString("yyyy-MM-dd");
            if (cbMaPhong.SelectedItem as Phong == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                EditHoaDon(maHoaDon, maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, convertNgayTao);
            }
        }
        void DeleteHoaDon(int maHoaDon)
        {
            if (MessageBox.Show("Bạn có chắc là xóa hóa đơn này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if (txbMaHoaDon.Text == null || txbMaHoaDon.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống Mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (HoaDonDienNuocDAO.Instance.DeleteHoaDon(maHoaDon))
                {
                    MessageBox.Show("Xóa hóa đơn thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadHoaDon();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maHoaDon = Convert.ToInt32(txbMaHoaDon.Text);
            DeleteHoaDon(maHoaDon);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadHoaDon();
        }
        List<HoaDonDienNuoc> SearchHoaDonByMaPhong(string maPhong)
        {
            List<HoaDonDienNuoc> listHoaDon = HoaDonDienNuocDAO.Instance.SearchHoaDonByMaPhong(maPhong);
            return listHoaDon;
        }
        private void btnSearchMaPhong_Click(object sender, EventArgs e)
        {
            string maPhong = txbSearchMaPhong.Text;
            hoaDonList.DataSource = SearchHoaDonByMaPhong(maPhong);
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "G1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Hóa Đơn";

            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã Phòng";

            cl2.ColumnWidth = 16.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Tên Hóa Đơn";
            cl3.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Trạng Thái";

            cl4.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Tiền Điện";

            cl5.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Tiền Nước";

            cl6.ColumnWidth = 10;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Ngày Tạo";

            cl7.ColumnWidth = 30;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "G3");

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
            try
            {
                DataTable dataTable = new DataTable();

                DataColumn col1 = new DataColumn("MaHoaDon");
                DataColumn col2 = new DataColumn("MaPhong");
                DataColumn col3 = new DataColumn("TenHoaDon");
                DataColumn col4 = new DataColumn("TrangThai");
                DataColumn col5 = new DataColumn("TienDien");
                DataColumn col6 = new DataColumn("TienNuoc");
                DataColumn col7 = new DataColumn("NgayTao");

                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);
                dataTable.Columns.Add(col4);
                dataTable.Columns.Add(col5);
                dataTable.Columns.Add(col6);
                dataTable.Columns.Add(col7);

                foreach (DataGridViewRow dtgvRow in dtgvHoaDon.Rows)
                {
                    DataRow dtRow = dataTable.NewRow();

                    dtRow[0] = dtgvRow.Cells[0].Value;
                    dtRow[1] = dtgvRow.Cells[1].Value;
                    dtRow[2] = dtgvRow.Cells[2].Value;
                    dtRow[3] = dtgvRow.Cells[3].Value;
                    dtRow[4] = dtgvRow.Cells[4].Value;
                    dtRow[5] = dtgvRow.Cells[5].Value;
                    dtRow[6] = dtgvRow.Cells[6].Value;

                    dataTable.Rows.Add(dtRow);
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportFile(dataTable, "Danh sách hóa đơn", "Quản lý Hóa đơn", saveFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy vui lòng tắt file excel đang sử dụng để save đè lên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
