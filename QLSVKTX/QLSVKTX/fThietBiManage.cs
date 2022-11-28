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
    public partial class fThietBiManage : Form
    {
        BindingSource thietBiList = new BindingSource();
        public fThietBiManage()
        {
            InitializeComponent();
            LoadInfo();
            LoadPhongIntoCombobox(cbMaPhong);
            dtgvThietBi.Columns[0].HeaderText = "Mã thiết bị";
            dtgvThietBi.Columns[1].HeaderText = "Mã phòng";
            dtgvThietBi.Columns[2].HeaderText = "Tên thiết bị";
            dtgvThietBi.Columns[3].HeaderText = "Số lượng thiết bị";
            dtgvThietBi.Columns[4].HeaderText = "Số lượng thiết bị hỏng";
            dtgvThietBi.Columns[5].HeaderText = "Số lượng thiết bị tối đa";
        }
        void LoadThietBi()
        {
            thietBiList.DataSource = ThietBiDAO.Instance.GetListThietBi();
        }
        void LoadInfo()
        {
            dtgvThietBi.DataSource = thietBiList;
            LoadThietBi();
            AddThietBiBinding();
        }
        void AddThietBiBinding()
        {
            txbMaThietBi.DataBindings.Add(new Binding("Text", dtgvThietBi.DataSource, "MaThietBi", true, DataSourceUpdateMode.Never));
            cbMaPhong.DataBindings.Add(new Binding("Text", dtgvThietBi.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txbTenThietBi.DataBindings.Add(new Binding("Text", dtgvThietBi.DataSource, "TenThietBi", true, DataSourceUpdateMode.Never));
            nupHienTai.DataBindings.Add(new Binding("Text", dtgvThietBi.DataSource, "SoLuongThietBi", true, DataSourceUpdateMode.Never));
            nupHong.DataBindings.Add(new Binding("Text", dtgvThietBi.DataSource, "SoLuongThietBiHong", true, DataSourceUpdateMode.Never));
            nupToiDa.DataBindings.Add(new Binding("Text", dtgvThietBi.DataSource, "SoLuongThietBiToiDa", true, DataSourceUpdateMode.Never));

        }
        void LoadPhongIntoCombobox(ComboBox cb)
        {
            cb.DataSource = PhongDAO.Instance.GetListPhong();
            cb.DisplayMember = "TenPhong";
        }

        private void txbMaThietBi_TextChanged(object sender, EventArgs e)
        {
            if (dtgvThietBi.SelectedCells.Count > 0)
            {
                if (dtgvThietBi.SelectedCells[0].OwningRow.Cells["MaPhong"].Value != null)
                {
                    string maPhong = dtgvThietBi.SelectedCells[0].OwningRow.Cells["MaPhong"].Value.ToString();
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
        void AddThietBi(string maPhong, string tenThietBi, int soLuongThietBi, int soLuongThietBiHong, int soLuongThietBiToiDa)
        {
            if (txbTenThietBi.Text == null || txbTenThietBi.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên thiết bị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHong.Text == null || nupHong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hỏng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value > nupToiDa.Value || nupHong.Value > nupToiDa.Value || nupHienTai.Value + nupHong.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập số lượng lớn hơn số lượng thiết bị tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ThietBiDAO.Instance.InsertThietBi(maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa))
            {
                MessageBox.Show("Thêm thiết bị thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thiết bị thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadThietBi();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenThietBi = txbTenThietBi.Text;
            int soLuongThietBi = Convert.ToInt32(nupHienTai.Value);
            int soLuongThietBiHong = Convert.ToInt32(nupHong.Value);
            int soLuongThietBiToiDa = Convert.ToInt32(nupToiDa.Value);
            if (cbMaPhong.SelectedItem as Phong == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                AddThietBi(maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa);
            }
        }
        void EditThietBi(int maThietBi, string maPhong, string tenThietBi, int soLuongThietBi, int soLuongThietBiHong, int soLuongThietBiToiDa)
        {
            if (txbMaThietBi.Text == null || txbMaThietBi.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã thiết bị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txbTenThietBi.Text == null || txbTenThietBi.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên thiết bị", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hiện tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHong.Text == null || nupHong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hỏng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value > nupToiDa.Value || nupHong.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập số lượng lớn hơn số lượng thiết bị tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value + nupHong.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập tổng số lượng thiết bị và số lượng thiết bị hỏng lớn hơn thiết bị tối đa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ThietBiDAO.Instance.UpdateThietBi(maThietBi, maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa))
            {
                MessageBox.Show("Thay đổi thông tin thiết bị thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin bị thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadThietBi();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int maThietBi = Convert.ToInt32(txbMaThietBi.Text);
            string tenThietBi = txbTenThietBi.Text;
            int soLuongThietBi = Convert.ToInt32(nupHienTai.Value);
            int soLuongThietBiHong = Convert.ToInt32(nupHong.Value);
            int soLuongThietBiToiDa = Convert.ToInt32(nupToiDa.Value);
            if (cbMaPhong.SelectedItem as Phong == null)
            {
                MessageBox.Show("Lỗi !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                EditThietBi(maThietBi, maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa);
            }
        }

        void DeleteThietBi(int maThietBi)
        {
            if (MessageBox.Show("Bạn có chắc là xóa thiết bị này?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if (txbMaThietBi.Text == null || txbMaThietBi.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống Mã hóa đơn", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ThietBiDAO.Instance.DeleteThietBi(maThietBi))
                {
                    MessageBox.Show("Xóa thiết bị thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thiết bị thất bại !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadThietBi();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int maThietBi = Convert.ToInt32(txbMaThietBi.Text);
            DeleteThietBi(maThietBi);
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            LoadThietBi();
        }
        List<ThietBi> SearchThietBiByMaPhong(string maPhong)
        {
            List<ThietBi> listThietBi = ThietBiDAO.Instance.SearchThietBiByMaPhong(maPhong);
            return listThietBi;
        }

        private void btnSearchMaPhong_Click(object sender, EventArgs e)
        {
            string maPhong = txbSearchMaPhong.Text;
            thietBiList.DataSource = SearchThietBiByMaPhong(maPhong);
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
            Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

            head.MergeCells = true;

            head.Value2 = title;

            head.Font.Bold = true;

            head.Font.Name = "Times New Roman";

            head.Font.Size = "20";

            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            // Tạo tiêu đề cột 

            Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

            cl1.Value2 = "Mã Thiết Bị";

            cl1.ColumnWidth = 12;

            Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

            cl2.Value2 = "Mã Phòng";

            cl2.ColumnWidth = 12.0;

            Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

            cl3.Value2 = "Tên thiết bị";
            cl3.ColumnWidth = 20.0;

            Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

            cl4.Value2 = "Số lượng thiết bị";

            cl4.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

            cl5.Value2 = "Số lượng thiết bị hỏng";

            cl5.ColumnWidth = 25;
            Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

            cl6.Value2 = "Số lượng thiết bị tối đa";

            cl6.ColumnWidth = 25;

            Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

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

                DataColumn col1 = new DataColumn("MaThietBi");
                DataColumn col2 = new DataColumn("MaPhong");
                DataColumn col3 = new DataColumn("TenThietBi");
                DataColumn col4 = new DataColumn("SoLuongThietBi");
                DataColumn col5 = new DataColumn("SoLuongThietBiHong");
                DataColumn col6 = new DataColumn("SoLuongThietBiToiDa");

                dataTable.Columns.Add(col1);
                dataTable.Columns.Add(col2);
                dataTable.Columns.Add(col3);
                dataTable.Columns.Add(col4);
                dataTable.Columns.Add(col5);
                dataTable.Columns.Add(col6);

                foreach (DataGridViewRow dtgvRow in dtgvThietBi.Rows)
                {
                    DataRow dtRow = dataTable.NewRow();

                    dtRow[0] = dtgvRow.Cells[0].Value;
                    dtRow[1] = dtgvRow.Cells[1].Value;
                    dtRow[2] = dtgvRow.Cells[2].Value;
                    dtRow[3] = dtgvRow.Cells[3].Value;
                    dtRow[4] = dtgvRow.Cells[4].Value;
                    dtRow[5] = dtgvRow.Cells[5].Value;


                    dataTable.Rows.Add(dtRow);
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx;*.xls;*.xlsm";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ExportFile(dataTable, "Danh sách thiết bị", "Quản lý thiết bị", saveFileDialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Xin hãy vui lòng tắt file excel đang sử dụng để save đè lên !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
