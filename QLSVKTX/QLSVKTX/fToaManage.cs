using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QLSVKTX.DAO;
using QLSVKTX.DTO;
namespace QLSVKTX
{
    public partial class fToaManage : Form
    {
        BindingSource toaList = new BindingSource();
        public fToaManage()
        {
            InitializeComponent();
            LoadInfo();
            LoadNhanVienIntoCombobox(cbMaNguoiQuanLy);
            dtgvToa.Columns[0].HeaderText = "Mã Tòa nhà";
            dtgvToa.Columns[1].HeaderText = "Tên Tòa nhà";
            dtgvToa.Columns[2].HeaderText = "số lượng phòng";   
            dtgvToa.Columns[3].HeaderText = "Mã Người quản lý";
        }
        void LoadToa()
        {
            toaList.DataSource = ToaDAO.Instance.GetListToa();
        }
        void LoadInfo()
        {
            dtgvToa.DataSource = toaList;
            LoadToa();
            AddToaBinding();
        }
        void AddToaBinding()
        {
            txbMaToa.DataBindings.Add(new Binding("Text", dtgvToa.DataSource, "MaToa", true, DataSourceUpdateMode.Never));
            txbTenToa.DataBindings.Add(new Binding("Text", dtgvToa.DataSource, "TenToa", true, DataSourceUpdateMode.Never));
            nupSoPhong.DataBindings.Add(new Binding("Text", dtgvToa.DataSource, "SoPhong", true, DataSourceUpdateMode.Never));
            
        }
        void LoadNhanVienIntoCombobox(ComboBox cb)
        {
            cb.DataSource = NhanVienDAO.Instance.GetListNhanVien();
            cb.DisplayMember = "HoTen";
        }
        private void txbMaToa_TextChanged(object sender, EventArgs e)
        {
            if (dtgvToa.SelectedCells.Count > 0)
            {
                if (dtgvToa.SelectedCells[0].OwningRow.Cells["MaNguoiQuanLy"].Value != null)
                {
                    string maNV = dtgvToa.SelectedCells[0].OwningRow.Cells["MaNguoiQuanLy"].Value.ToString();
                    NhanVien nhanVien = NhanVienDAO.Instance.GetNhanVienByMaNhanVien(maNV);
                    cbMaNguoiQuanLy.SelectedItem = nhanVien;

                    int index = -1;
                    int i = 0;
                    foreach (NhanVien item in cbMaNguoiQuanLy.Items)
                    {
                        if (nhanVien != null)
                        {
                            if (item.MaNV == nhanVien.MaNV)
                            {
                                index = i;
                                break;
                            }
                            i++;
                        }
                            
                    }

                    cbMaNguoiQuanLy.SelectedIndex = index;
                }
            }
        }
        void AddToa(string maToa, string tenToa, int soPhong, string maNguoiQuanLy)
        {
            if (txbMaToa.Text == null || txbMaToa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã Tòa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenToa.Text == null || txbTenToa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên Tòa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupSoPhong.Text == null || nupSoPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(ToaDAO.Instance.InsertToa(maToa, tenToa, soPhong, maNguoiQuanLy))
            {
                MessageBox.Show("Thêm Tòa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Tòa thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadToa();
        }

        private void btnAddToa_Click(object sender, EventArgs e)
        {
            string maToa = txbMaToa.Text;
            string tenToa = txbTenToa.Text;
            int soPhong = (int)nupSoPhong.Value;
            if (cbMaNguoiQuanLy.SelectedItem as NhanVien == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maNV = (cbMaNguoiQuanLy.SelectedItem as NhanVien).MaNV.ToString();
                AddToa(maToa, tenToa, soPhong, maNV);
            }
        }
        void EditToa(string maToa, string tenToa, int soPhong, string maNguoiQuanLy)
        {
            if (txbMaToa.Text == null || txbMaToa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã Tòa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenToa.Text == null || txbTenToa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên Tòa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupSoPhong.Text == null || nupSoPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số Phòng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupSoPhong.Value <= 0)
            {
                MessageBox.Show("Số phòng không thể bé hơn 0", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ToaDAO.Instance.UpdateToa(maToa, tenToa, soPhong, maNguoiQuanLy))
            {
                MessageBox.Show("Thay đổi thông tin tòa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin tòa thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadToa();
        }

        private void btnEditToa_Click(object sender, EventArgs e)
        {
            string maToa = txbMaToa.Text;
            string tenToa = txbTenToa.Text;
            int soPhong = (int)nupSoPhong.Value;
            if (cbMaNguoiQuanLy.SelectedItem as NhanVien == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maNV = (cbMaNguoiQuanLy.SelectedItem as NhanVien).MaNV.ToString();
                EditToa(maToa, tenToa, soPhong, maNV);
            }
        }
        void DeleteToa(string maToa)
        {
            if (MessageBox.Show("Bạn có chắc là xóa tòa này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if (txbMaToa.Text == null || txbMaToa.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống Mã Tòa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ToaDAO.Instance.DeleteToaByMaToa(maToa))
                {
                    MessageBox.Show("Xóa Tòa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa Tòa thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadToa();
            }
            
        }

        private void btnDeleteToa_Click(object sender, EventArgs e)
        {
            string maToa = txbMaToa.Text;
            DeleteToa(maToa);
        }

        private void btnListToa_Click(object sender, EventArgs e)
        {
            LoadToa();
        }
        List<Toa> SearchToaByTenToa(string tenToa)
        {
            List<Toa> listToa = ToaDAO.Instance.SearchToaByTenToa(tenToa);
            return listToa;
        }

        private void btnSearchTenToa_Click(object sender, EventArgs e)
        {
            string tenToa = txbSearchTenToa.Text;
            toaList.DataSource = SearchToaByTenToa(tenToa);
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "D1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Tòa";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Tên Tòa";

            cl2.ColumnWidth = 25.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Số Phòng";
            cl3.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Mã Người Quản Lý";

            cl4.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "D3");

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

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dataTable = new DataTable();

                DataColumn col1 = new DataColumn("MaToa");
                DataColumn col2 = new DataColumn("TenToa");
                DataColumn col3 = new DataColumn("SoPhong");
                DataColumn col4 = new DataColumn("MaNguoiQuanLy");

                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);
                dataTable.Columns.Add(col4);

                foreach (DataGridViewRow dtgvRow in dtgvToa.Rows)
                {
                    DataRow dtRow = dataTable.NewRow();

                    dtRow[0] = dtgvRow.Cells[0].Value;
                    dtRow[1] = dtgvRow.Cells[1].Value;
                    dtRow[2] = dtgvRow.Cells[2].Value;
                    dtRow[3] = dtgvRow.Cells[3].Value;

                    dataTable.Rows.Add(dtRow);
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportFile(dataTable, "Danh sách tòa", "Quản lý tòa", saveFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy vui lòng tắt file excel đang sử dụng để save đè lên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }
    }
}
