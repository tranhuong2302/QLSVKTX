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
    public partial class fPhongManage : Form
    {
        BindingSource phongList = new BindingSource();
        public fPhongManage()
        {
            InitializeComponent();
            LoadInfo();
            LoadToaIntoCombobox(cbMaToa);
            dtgvPhong.Columns[0].HeaderText = "Mã phòng";
            dtgvPhong.Columns[1].HeaderText = "Mã tòa";
            dtgvPhong.Columns[2].HeaderText = "Tên phòng";
            dtgvPhong.Columns[3].HeaderText = "Loại phòng";
            dtgvPhong.Columns[4].HeaderText = "Số lượng sinh viên hiện tại";
            dtgvPhong.Columns[5].HeaderText = "Số lượng sinh viên tối đa";
            dtgvPhong.Columns[6].HeaderText = "Tình trạng phòng";
        }
        void LoadPhong()
        {
            phongList.DataSource = PhongDAO.Instance.GetListPhong();
        }
        void LoadInfo()
        {
            dtgvPhong.DataSource = phongList;
            LoadPhong();
            AddPhongBinding();
        }
        void AddPhongBinding()
        {
            txbMaPhong.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txbTenPhong.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "TenPhong", true, DataSourceUpdateMode.Never));
            cbLoaiPhong.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "LoaiPhong", true, DataSourceUpdateMode.Never));
            nupHienTai.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "SoLuongSinhVienHienTai", true, DataSourceUpdateMode.Never));
            nupToiDa.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource, "SoLuongSinhVienToiDa", true, DataSourceUpdateMode.Never));
            cbTinhTrangPhong.DataBindings.Add(new Binding("Text", dtgvPhong.DataSource,"TinhTrangPhong", true, DataSourceUpdateMode.Never));

        }
        void LoadToaIntoCombobox(ComboBox cb)
        {
            cb.DataSource = ToaDAO.Instance.GetListToa();
            cb.DisplayMember = "TenToa";
        }

        private void txbMaPhong_TextChanged(object sender, EventArgs e)
        {
            if (dtgvPhong.SelectedCells.Count > 0)
            {
                if (dtgvPhong.SelectedCells[0].OwningRow.Cells["MaToa"].Value != null)
                {
                    string maToa = dtgvPhong.SelectedCells[0].OwningRow.Cells["MaToa"].Value.ToString();
                    Toa toa = ToaDAO.Instance.GetToaByMaToa(maToa);
                    cbMaToa.SelectedItem = toa;

                    int index = -1;
                    int i = 0;
                    foreach (Toa item in cbMaToa.Items)
                    {
                        if (toa != null)
                        {
                            if (item.MaToa == toa.MaToa)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }

                    }

                    cbMaToa.SelectedIndex = index;
                }
            }
        }
        void addPhong(string maPhong, string maToa, string tenPhong, string loaiPhong, int hienTai, int toiDa, string tinhTrangPhong)
        {
            if (txbMaPhong.Text == null || txbMaPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenPhong.Text == null || txbTenPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập số lượng hiện tại lớn hơn số lượng tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PhongDAO.Instance.InsertPhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong))
            {
                ToaDAO.Instance.UpdateSoPhongHienTaiToaCongMot(maToa);
                MessageBox.Show("Thêm phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadPhong();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string maPhong = txbMaPhong.Text;
            string tenPhong = txbTenPhong.Text;
            string loaiPhong = cbLoaiPhong.Text;
            int hienTai = (int)nupHienTai.Value;
            int toiDa = (int)nupToiDa.Value;
            string tinhTrangPhong = cbTinhTrangPhong.Text;
            if (cbMaToa.SelectedItem as Toa == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maToa = (cbMaToa.SelectedItem as Toa).MaToa.ToString();
                addPhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong);
            }
        }
        void updatePhong(string maPhong, string maToa, string tenPhong, string loaiPhong, int hienTai, int toiDa, string tinhTrangPhong)
        {
            Phong phong = PhongDAO.Instance.GetPhongByMaPhong(maPhong);
            if (txbMaPhong.Text == null || txbMaPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenPhong.Text == null || txbTenPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập số lượng hiện tại lớn hơn số lượng tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PhongDAO.Instance.UpdatePhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong))
            {
                ToaDAO.Instance.UpdateSoPhongHienTaiToaTruMot(phong.MaToa);
                ToaDAO.Instance.UpdateSoPhongHienTaiToaCongMot(maToa);
                MessageBox.Show("Thay đổi thông tin phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin phòng thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadPhong();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string maPhong = txbMaPhong.Text;
            string tenPhong = txbTenPhong.Text;
            string loaiPhong = cbLoaiPhong.Text;
            int hienTai = (int)nupHienTai.Value;
            int toiDa = (int)nupToiDa.Value;
            string tinhTrangPhong = cbTinhTrangPhong.Text;
            if (cbMaToa.SelectedItem as Toa == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maToa = (cbMaToa.SelectedItem as Toa).MaToa.ToString();
                updatePhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong);
            }
        }
        void deletePhong(string maPhong, string maToa)
        {
            if (MessageBox.Show("Bạn có chắc là xóa phòng này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if (txbMaPhong.Text == null || txbMaPhong.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống Mã Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (PhongDAO.Instance.DeletePhongByMaPhong(maPhong))
                {
                    ToaDAO.Instance.UpdateSoPhongHienTaiToaTruMot(maToa);
                    MessageBox.Show("Xóa phòng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadPhong();
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maPhong = txbMaPhong.Text;
            Toa toa = cbMaToa.SelectedItem as Toa;
            deletePhong(maPhong, toa.MaToa);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadPhong();
        }
        List<Phong> SearchPhongByMaPhong(string maPhong)
        {
            List<Phong> listPhong = PhongDAO.Instance.SearchPhongByMaPhong(maPhong);
            return listPhong;
        }

        private void btnSearchTen_Click(object sender, EventArgs e)
        {
            string maPhong = txbSearchMaPhong.Text;
            phongList.DataSource = SearchPhongByMaPhong(maPhong);
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

            cl1.Value2 = "Mã Phòng";

            cl1.ColumnWidth = 10;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã Tòa";

            cl2.ColumnWidth = 10.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Tên Phòng";
            cl3.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Loại Phòng";

            cl4.ColumnWidth = 16;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Số Lượng Sinh viên Hiện Tại";

            cl5.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Số Lượng Sinh Viên Tối Đa";

            cl6.ColumnWidth = 20;
            Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

            cl7.Value2 = "Tình Trạng Phòng";

            cl7.ColumnWidth = 18;
            

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

                DataColumn col1 = new DataColumn("MaPhong");
                DataColumn col2 = new DataColumn("MaToa");
                DataColumn col3 = new DataColumn("TenPhong");
                DataColumn col4 = new DataColumn("loaiPhong");
                DataColumn col5 = new DataColumn("SoLuongSinhVienHienTai");
                DataColumn col6 = new DataColumn("SoLuongSinhVienToiDa");
                DataColumn col7 = new DataColumn("TinhTrangPhong");


                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);
                dataTable.Columns.Add(col4);
                dataTable.Columns.Add(col5);
                dataTable.Columns.Add(col6);
                dataTable.Columns.Add(col7);

                foreach (DataGridViewRow dtgvRow in dtgvPhong.Rows)
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
                    ExportFile(dataTable, "Danh sách phòng", "Quản lý Phòng", saveFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy vui lòng tắt file excel đang sử dụng để save đè lên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
