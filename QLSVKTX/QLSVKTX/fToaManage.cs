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
                MessageBox.Show("Bạn không được để trống Mã Tòa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenToa.Text == null || txbTenToa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên Tòa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupSoPhong.Text == null || nupSoPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số Phòng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(ToaDAO.Instance.InsertToa(maToa, tenToa, soPhong, maNguoiQuanLy))
            {
                MessageBox.Show("Thêm Tòa thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm Tòa thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Bạn không được để trống Mã Tòa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenToa.Text == null || txbTenToa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên Tòa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupSoPhong.Text == null || nupSoPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Số Phòng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupSoPhong.Value <= 0)
            {
                MessageBox.Show("Số phòng không thể bé hơn 0", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ToaDAO.Instance.UpdateToa(maToa, tenToa, soPhong, maNguoiQuanLy))
            {
                MessageBox.Show("Thay đổi thông tin tòa thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin tòa thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maNV = (cbMaNguoiQuanLy.SelectedItem as NhanVien).MaNV.ToString();
                EditToa(maToa, tenToa, soPhong, maNV);
            }
        }
        void DeleteToa(string maToa)
        {
            if (txbMaToa.Text == null || txbMaToa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Mã Tòa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ToaDAO.Instance.DeleteToaByMaToa(maToa))
            {
                MessageBox.Show("Xóa Tòa thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa Tòa thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadToa();
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
    }
}
