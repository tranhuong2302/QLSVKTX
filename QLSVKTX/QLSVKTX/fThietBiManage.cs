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
            cb.DisplayMember = "MaPhong";
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
                MessageBox.Show("Bạn không được để trống Tên thiết bị", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hiện tại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHong.Text == null || nupHong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hỏng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị tối đa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value > nupToiDa.Value || nupHong.Value > nupToiDa.Value || nupHienTai.Value + nupHong.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập số lượng lớn hơn số lượng thiết bị tối đa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ThietBiDAO.Instance.InsertThietBi(maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa))
            {
                MessageBox.Show("Thêm thiết bị thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thiết bị thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Bạn không được để trống Mã thiết bị", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txbTenThietBi.Text == null || txbTenThietBi.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên thiết bị", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hiện tại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHong.Text == null || nupHong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị hỏng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng thiết bị tối đa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value > nupToiDa.Value || nupHong.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập số lượng lớn hơn số lượng thiết bị tối đa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Value + nupHong.Value > nupToiDa.Value)
            {
                MessageBox.Show("Bạn không được nhập tổng số lượng thiết bị và số lượng thiết bị hỏng lớn hơn thiết bị tối đa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (ThietBiDAO.Instance.UpdateThietBi(maThietBi, maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa))
            {
                MessageBox.Show("Thay đổi thông tin thiết bị thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin bị thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                EditThietBi(maThietBi, maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa);
            }
        }

        void DeleteThietBi(int maThietBi)
        {
            if (MessageBox.Show("Bạn có chắc là xóa thiết bị này?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if (txbMaThietBi.Text == null || txbMaThietBi.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống Mã hóa đơn", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ThietBiDAO.Instance.DeleteThietBi(maThietBi))
                {
                    MessageBox.Show("Xóa thiết bị thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thiết bị thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
