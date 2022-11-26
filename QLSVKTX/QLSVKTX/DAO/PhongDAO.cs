using System.Collections.Generic;
using System.Data;
using QLSVKTX.DTO;

namespace QLSVKTX.DAO
{
    internal class PhongDAO
    {
        private static PhongDAO instance;

        internal static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        }
        private PhongDAO() { }
        //Lấy danh sách từ database
        public List<Phong> GetListPhong()
        {
            List<Phong> list = new List<Phong>();

            string query = "SELECT * FROM dbo.Phong";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                list.Add(phong);
            }

            return list;
        }
        //check Trùng
        public int Check(string maPhong)
        {
            string check = string.Format("SELECT * FROM dbo.Phong WHERE MaPhong = N'{0}'", maPhong);
            var test = DataProvider.Instance.ExecuteScalar(check);
            if (test == null)
                return 1;
            else
                return 0;
        }
        //thêm
        public bool InsertPhong(string maPhong, string maToa, string tenPhong, string loaiPhong, int soLuongSinhVienHienTai, int SoLuongSinhVienToiDa, string tinhTrangPhong)
        {
            if (Check(maPhong) == 1)
            {
                string query = string.Format("INSERT dbo.Phong (MaPhong, MaToa, TenPhong, LoaiPhong, SoLuongSinhVienHienTai, soLuongSinhVienToiDa, TinhTrangPhong) VALUES (N'{0}',N'{1}',N'{2}', N'{3}', '{4}', '{5}', N'{6}')", maPhong, maToa, tenPhong, loaiPhong, soLuongSinhVienHienTai, SoLuongSinhVienToiDa, tinhTrangPhong);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;

            }
            else return false;
        }
        //sửa
        public bool UpdatePhong(string maPhong, string maToa, string tenPhong, string loaiPhong, int soLuongSinhVienHienTai, int SoLuongSinhVienToiDa, string tinhTrangPhong)
        {
            string query = string.Format("UPDATE dbo.Phong SET MaToa = N'{1}', TenPhong = N'{2}', LoaiPhong = N'{3}',  SoLuongSinhVienHienTai = {4},  soLuongSinhVienToiDa = {5}, TinhTrangPhong = N'{6}' WHERE MaPhong = N'{0}'", maPhong, maToa, tenPhong, loaiPhong, soLuongSinhVienHienTai, SoLuongSinhVienToiDa, tinhTrangPhong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdatePhongToNull(string maToa)
        {
            string query = string.Format("UPDATE dbo.Phong SET MaToa = null WHERE MaToa = N'{0}'", maToa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //xóa
        public bool DeletePhongByMaPhong(string maPhong)
        {
            HoaDonDienNuocDAO.Instance.UpdateMaPhongHoaDonToNull(maPhong);
            ThietBiDAO.Instance.UpdateMaPhongThietBiToNull(maPhong);
            SinhVienDAO.Instance.UpdateMaPhongSinhVienToNull(maPhong);
            string query = string.Format("DELETE dbo.Phong Where MaPhong = N'{0}'", maPhong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //tìm kiếm theo tên
        public List<Phong> SearchPhongByMaPhong(string maPhong)
        {
            List<Phong> phongList = new List<Phong>();

            string query = string.Format("SELECT * FROM dbo.Phong WHERE dbo.fuConvertToUnsign1(MaPhong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", maPhong);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Phong phong = new Phong(item);
                phongList.Add(phong);
            }

            return phongList;
        }
        public Phong GetPhongByMaPhong(string maPhong)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From dbo.Phong Where maPhong = '" + maPhong + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Phong(item);
            }

            return null;
        }
    }
}
