using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSVKTX.DTO;

namespace QLSVKTX.DAO
{
    public class HoaDonDienNuocDAO
    {
        private static HoaDonDienNuocDAO instance;

        internal static HoaDonDienNuocDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDienNuocDAO(); return instance; }
            private set { instance = value; }
        }
        private HoaDonDienNuocDAO() { }
        //Lấy danh sách từ database
        public List<HoaDonDienNuoc> GetListHoaDon()
        {
            List<HoaDonDienNuoc> list = new List<HoaDonDienNuoc>();

            string query = "SELECT * FROM dbo.HoaDonDienNuoc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonDienNuoc hoaDon = new HoaDonDienNuoc(item);
                list.Add(hoaDon);
            }

            return list;
        }
        // thêm
        public bool InsertHoaDon(string maPhong, string tenHoaDon, string trangThai, float tienDien, float tienNuoc, string ngayTao)
        {
            string query = string.Format("INSERT dbo.HoaDonDienNuoc (MaPhong, TenHoaDon, TrangThai, TienDien, TienNuoc, NgayTao )VALUES  ( N'{0}', N'{1}', N'{2}', {3}, {4}, N'{5}' )", maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, ngayTao);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //sửa 
        public bool UpdateHoaDon(int maHoaDon, string maPhong, string tenHoaDon, string trangThai, float tienDien, float tienNuoc, string ngayTao)
        {
            string query = string.Format("UPDATE dbo.HoaDonDienNuoc SET MaPhong = N'{1}', TenHoaDon = N'{2}', TrangThai = N'{3}', TienDien = {4}, TienNuoc = {5}, NgayTao = N'{6}' WHERE MaHoaDon = {0} ", maHoaDon, maPhong, tenHoaDon, trangThai, tienDien, tienNuoc, ngayTao);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateMaPhongHoaDonToNull(string maPhong)
        {
            string query = string.Format("UPDATE dbo.HoaDonDienNuoc SET MaPhong = null WHERE MaPhong = N'{0}'", maPhong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //xóa
        public bool DeleteHoaDon(int maHoaDon)
        {
            string query = string.Format("Delete dbo.HoaDonDienNuoc where MaHoaDon = {0}", maHoaDon);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //tìm kiếm theo mã phòng
        public List<HoaDonDienNuoc> SearchHoaDonByMaPhong(string maPhong)
        {
            List<HoaDonDienNuoc> hoaDonList = new List<HoaDonDienNuoc>();

            string query = string.Format("SELECT * FROM dbo.HoaDonDienNuoc WHERE dbo.fuConvertToUnsign1(MaPhong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", maPhong);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonDienNuoc hoaDon = new HoaDonDienNuoc(item);
                hoaDonList.Add(hoaDon);
            }

            return hoaDonList;
        }
    }
}
