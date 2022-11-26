using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QLSVKTX.DTO;

namespace QLSVKTX.DAO
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        internal static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set { instance = value; }
        }
        private SinhVienDAO() { }
        
        // lấy dach sách
        public List<SinhVien> GetListSinhVien()
        {
            List<SinhVien> list = new List<SinhVien>();

            string query = "select * from sinhvien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhVien = new SinhVien(item);
                list.Add(sinhVien);
            }

            return list;
        }
        //check Trùng
        public int Check(string maSV)
        {
            string check = string.Format("SELECT * FROM dbo.SinhVien WHERE MaSinhVien = N'{0}'", maSV);
            var test = DataProvider.Instance.ExecuteScalar(check);
            if (test == null)
                return 1;
            else
                return 0;
        }
        public bool InsertSinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, int namHoc, string sdt, string diaChi, string cccd, string ngayLamHopDong, string ngayKetThucHopDong, string maPhong, string khoa)
        {
            if (Check(maSV) == 1)
            {
                string query = string.Format("INSERT dbo.SinhVien (MaSinhVien, HoTen, NgaySinh, GioiTinh, NamHoc, SoDienThoai, DiaChi, CMND_CCCD, NgayLamHopDong, NgayKetThucHopDong, MaPhong, Khoa )VALUES  ( N'{0}', N'{1}', N'{2}',N'{3}', {4}, N'{5}', N'{6}', N'{7}', N'{8}', N'{9}', N'{10}', N'{11}' )", maSV, hoTen, ngaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, ngayLamHopDong, ngayKetThucHopDong, maPhong, khoa);
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                
                return result > 0;

            }
            else return false;
        }
        //sửa tk
        public bool UpdateSinhVien(string maSV, string hoTen, string ngaySinh, string gioiTinh, int namHoc, string sdt, string diaChi, string cccd, string ngayLamHopDong, string ngayKetThucHopDong, string maPhong, string khoa)
        {
            string query = string.Format("UPDATE dbo.SinhVien SET HoTen = N'{1}', NgaySinh = N'{2}', GioiTinh = N'{3}', NamHoc = {4}, SoDienThoai = N'{5}', DiaChi = N'{6}', CMND_CCCD = N'{7}', NgayLamHopDong = N'{8}', NgayKetThucHopDong = N'{9}', MaPhong = N'{10}', Khoa = N'{11}' WHERE MaSinhVien = N'{0}'", maSV, hoTen, ngaySinh, gioiTinh, namHoc, sdt, diaChi, cccd, ngayLamHopDong, ngayKetThucHopDong, maPhong, khoa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateMaPhongSinhVienToNull(string maPhong)
        {
            string query = string.Format("UPDATE dbo.SinhVien SET MaPhong = null WHERE MaPhong = N'{0}'", maPhong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateNgayKetThucHopDongToNull(string maSV, string ngayKetThucHopDong)
        {
            string query = string.Format("UPDATE dbo.SinhVien SET NgayKetThucHopDong = N'{1}', MaPhong = null WHERE MaSinhVien = N'{0}'", maSV, ngayKetThucHopDong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //xóa
        public bool DeleteSinhVienByMaSinhVien(string maSinhVien)
        {
            string query = string.Format("DELETE dbo.SinhVien Where MaSinhVien = N'{0}'", maSinhVien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //tìm kiếm theo mã sinh viên
        public List<SinhVien> SearchSinhVienByMaSinhVien(string maSV)
        {
            List<SinhVien> sinhVienList = new List<SinhVien>();

            string query = string.Format("SELECT * FROM dbo.SinhVien WHERE dbo.fuConvertToUnsign1(MaSinhVien) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", maSV);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhVien = new SinhVien(item);
                sinhVienList.Add(sinhVien);
            }

            return sinhVienList;
        }
        //tìm kiếm theo mã phòng
        public List<SinhVien> SearchSinhVienByMaPhong(string maPhong)
        {
            List<SinhVien> sinhVienList = new List<SinhVien>();

            string query = string.Format("SELECT * FROM dbo.SinhVien WHERE dbo.fuConvertToUnsign1(MaPhong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", maPhong);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhVien = new SinhVien(item);
                sinhVienList.Add(sinhVien);
            }

            return sinhVienList;
        }
        //tìm kiếm theo tên sinh viên
        public List<SinhVien> SearchSinhVienByHoTen(string hoTen)
        {
            List<SinhVien> sinhVienList = new List<SinhVien>();

            string query = string.Format("SELECT * FROM dbo.SinhVien WHERE dbo.fuConvertToUnsign1(HoTen) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", hoTen);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SinhVien sinhVien = new SinhVien(item);
                sinhVienList.Add(sinhVien);
            }

            return sinhVienList;
        }
        public SinhVien GetSinhVienByMaSinhVien(string maSV)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From dbo.SinhVien Where MaSinhVien = '" + maSV + "'");

            foreach (DataRow item in data.Rows)
            {
                return new SinhVien(item);
            }

            return null;
        }
    }
}
