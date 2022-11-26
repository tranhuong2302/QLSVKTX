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
                MessageBox.Show("Bạn không được để trống mã phòng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenPhong.Text == null || txbTenPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên phòng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên hiện tại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên tối đa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PhongDAO.Instance.InsertPhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong))
            {
                MessageBox.Show("Thêm phòng thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm phòng thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maToa = (cbMaToa.SelectedItem as Toa).MaToa.ToString();
                addPhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong);
            }
        }
        void updatePhong(string maPhong, string maToa, string tenPhong, string loaiPhong, int hienTai, int toiDa, string tinhTrangPhong)
        {
            if (txbMaPhong.Text == null || txbMaPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống mã phòng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbTenPhong.Text == null || txbTenPhong.Text == "")
            {
                MessageBox.Show("Bạn không được để trống tên phòng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupHienTai.Text == null || nupHienTai.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên hiện tại", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nupToiDa.Text == null || nupToiDa.Text == "")
            {
                MessageBox.Show("Bạn không được để trống số lượng sinh viên tối đa", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (PhongDAO.Instance.UpdatePhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong))
            {
                MessageBox.Show("Thay đổi thông tin phòng thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thay đổi thông tin phòng thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Lỗi !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string maToa = (cbMaToa.SelectedItem as Toa).MaToa.ToString();
                updatePhong(maPhong, maToa, tenPhong, loaiPhong, hienTai, toiDa, tinhTrangPhong);
            }
        }
        void deletePhong(string maPhong)
        {
            if (MessageBox.Show("Bạn có chắc là xóa phòng này?", "Announcement", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK) { }
            else
            {
                if (txbMaPhong.Text == null || txbMaPhong.Text == "")
                {
                    MessageBox.Show("Bạn không được để trống Mã Phòng", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (PhongDAO.Instance.DeletePhongByMaPhong(maPhong))
                {
                    MessageBox.Show("Xóa phòng thành công", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa phòng thất bại !", "Announcement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LoadPhong();
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string maPhong = txbMaPhong.Text;
            deletePhong(maPhong);
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
    }
}
