using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLSVKTX.DTO;
namespace QLSVKTX
{
    public partial class fDashboard : Form
    {
        private NhanVien loginNhanVien;

        public fDashboard(NhanVien nhanVien)
        {
            InitializeComponent();
            this.LoginNhanVien = nhanVien;
        }

        public NhanVien LoginNhanVien
        {
            get { return loginNhanVien; }
            set { loginNhanVien = value; ChangeAccount(loginNhanVien.TrangThai); }
        }

        void ChangeAccount(string trangThai)
        {
            if(trangThai == "Quản trị viên" || trangThai == "admin")
                btnNhanVien.Enabled = true;
            else 
                btnNhanVien.Enabled = false;
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            fNhanVienManage f = new fNhanVienManage(LoginNhanVien);
            f.ShowDialog();
        }

        private void btnNhanVienProfile_Click(object sender, EventArgs e)
        {
            fNhanVienProfile f = new fNhanVienProfile(LoginNhanVien);
            f.ShowDialog();
        }

        private void btnToa_Click(object sender, EventArgs e)
        {
            fToaManage f = new fToaManage();
            f.ShowDialog();
        }
    }
}
