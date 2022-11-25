using System.Collections.Generic;
using System.Data;
using QLSVKTX.DTO;
namespace QLSVKTX.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        internal static NhanVienDAO Instance { 
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }

        private NhanVienDAO() { }
        //Lấy danh sách nhanvien từ database
        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "select * from nhanvien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }

            return list;
        }
        //check Trùng mã nv
        public int Check(string maNV)
        {
            string check = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNhanVien = N'{0}'", maNV);
            var test = DataProvider.Instance.ExecuteScalar(check);
            if (test == null)
                return 1;
            else
                return 0;
        }
        //thêm tk
        public bool InsertNhanVien(string maNV, string hoTen, string ngaySinh, string sdt, string diaChi, string gioiTinh, string cccd, string chucVu, string matKhau, string trangThai)
        {
            if (Check(maNV) == 1)
            {
                string query = string.Format("INSERT dbo.NhanVien (MaNhanVien, HoTen, NgaySinh, SoDienThoai, DiaChi, GioiTinh, CMND_CCCD, ChucVu, MatKhau, TrangThai )VALUES  ( N'{0}', N'{1}', N'{2}' ,N'{3}' ,N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}' )", maNV, hoTen, ngaySinh, sdt, diaChi, gioiTinh, cccd, chucVu, matKhau, trangThai);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
                
            }
            else return false;
        }
        //sửa tk
        public bool UpdateNhanVien(string maNV, string hoTen, string ngaySinh, string sdt, string diaChi, string gioiTinh, string cccd, string chucVu, string trangThai)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET HoTen = N'{1}', NgaySinh = N'{2}', SoDienThoai = N'{3}', DiaChi = N'{4}', GioiTinh = N'{5}', CMND_CCCD = N'{6}', ChucVu = N'{7}', TrangThai = N'{8}' WHERE MaNhanVien = N'{0}'", maNV, hoTen, ngaySinh, sdt, diaChi, gioiTinh, cccd, chucVu, trangThai);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //xóa
        public bool DeleteNhanVien(string maNV)
        {
            ToaDAO.Instance.UpdateToaToNull(maNV);
            string query = string.Format("Delete dbo.NhanVien where MaNhanVien = N'{0}'", maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //đặt lại mk
        public bool ResetPassword(string maNV)
        {
            string query = string.Format("Update dbo.NhanVien Set MatKhau = N'1' where MaNhanVien = N'{0}'", maNV);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //tìm kiếm theo tên nhân viên
        public List<NhanVien> SearchNhanVienByHoTen(string hoTen)
        {
            List<NhanVien> nhanVienList = new List<NhanVien>();

            string query = string.Format("SELECT * FROM dbo.NhanVien WHERE dbo.fuConvertToUnsign1(HoTen) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", hoTen);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                nhanVienList.Add(nhanVien);
            }

            return nhanVienList;
        }
        //truy vấn đăng nhập từ database
        public bool Login(string maNV, string matKhau)
        {
            string query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNhanVien = N'{0}' AND MatKhau = N'{1}' ", maNV, matKhau) ;

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV, matKhau });

            return result.Rows.Count > 0;
        }
        public NhanVien GetNhanVienByMaNhanVien(string maNV)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From dbo.NhanVien Where MaNhanVien = '" + maNV + "'");

            foreach (DataRow item in data.Rows)
            {
                return new NhanVien(item);
            }

            return null;
        }
        public NhanVien GetNhanVienByMaNhanVien2(string maNV)
        {
            NhanVien nhanVien = null;
            string query = string.Format("SELECT * FROM dbo.NhanVien WHERE MaNhanVien = N'{0}' ", maNV);
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
           

            foreach (DataRow item in data.Rows)
            {
                nhanVien =  new NhanVien(item);
                return nhanVien;
            }

            return nhanVien;
        }
        //đặt lại mk
        public bool ChangePassword(string maNV, string matKhau)
        {
            string query = string.Format("Update dbo.NhanVien Set MatKhau = N'{1}' where MaNhanVien = N'{0}'", maNV, matKhau);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool ChangeProfileNhanVien(string maNV, string matKhau, string hoTen, string ngaySinh, string sdt, string diaChi, string gioiTinh, string cccd, string chucVu)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET HoTen = N'{2}', NgaySinh = N'{3}', SoDienThoai = N'{4}', DiaChi = N'{5}', GioiTinh = N'{6}', CMND_CCCD = N'{7}', ChucVu = N'{8}' WHERE MaNhanVien = N'{0}' AND MatKhau = N'{1}'", maNV, matKhau, hoTen, ngaySinh, sdt, diaChi, gioiTinh, cccd, chucVu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
