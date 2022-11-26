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
            cb.DisplayMember = "MaPhong";
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
                MessageBox.Show("Bạn không được để trống Tên hóa đơn", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienDien.Text == null || nupTienDien.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền điện", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienNuoc.Text == null || nupTienNuoc.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền nước", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (HoaDonDienNuocDAO.Instance.InsertHoaDon(maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, ngayTao))
            {
                MessageBox.Show("Thêm hóa đơn thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Bạn không được để trống má hóa đơn", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txbTenHoaDon.Text == null || txbTenHoaDon.Text == "")
            {
                MessageBox.Show("Bạn không được để trống Tên hóa đơn", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienDien.Text == null || nupTienDien.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền điện", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupTienNuoc.Text == null || nupTienNuoc.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tiền nước", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (HoaDonDienNuocDAO.Instance.UpdateHoaDon(maHoaDon, maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, ngayTao))
            {
                MessageBox.Show("Thay đổi thông tin hóa đơn thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maPhong = (cbMaPhong.SelectedItem as Phong).MaPhong.ToString();
                EditHoaDon(maHoaDon, maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, convertNgayTao);
            }
        }
        void DeleteHoaDon(int maHoaDon)
        {
            if (MessageBox.Show("Bạn có chắc là xóa hóa đơn này?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if (txbMaHoaDon.Text == null || txbMaHoaDon.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống Mã hóa đơn", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (HoaDonDienNuocDAO.Instance.DeleteHoaDon(maHoaDon))
                {
                    MessageBox.Show("Xóa hóa đơn thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa hóa đơn thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
