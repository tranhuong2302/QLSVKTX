using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLSVKTX.DTO;

namespace QLSVKTX.DAO
{
    public class ThietBiDAO
    {
        private static ThietBiDAO instance;

        internal static ThietBiDAO Instance
        {
            get { if (instance == null) instance = new ThietBiDAO(); return instance; }
            private set { instance = value; }
        }
        private ThietBiDAO() { }
        //Lấy danh sách từ database
        public List<ThietBi> GetListThietBi()
        {
            List<ThietBi> list = new List<ThietBi>();

            string query = "SELECT * FROM dbo.ThietBi";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThietBi thietBi = new ThietBi(item);
                list.Add(thietBi);
            }

            return list;
        }
        //check Trùng
        public int Check(string maPhong, string tenThietBi)
        {
            string check = string.Format("SELECT * FROM dbo.ThietBi WHERE dbo.fuConvertToUnsign1(MaPhong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND dbo.fuConvertToUnsign1(TenThietBi) LIKE N'%' + dbo.fuConvertToUnsign1(N'{1}') + '%' ", maPhong, tenThietBi);
            var test = DataProvider.Instance.ExecuteScalar(check);
            if (test == null)
                return 1;
            else
                return 0;
        }
        // thêm
        public bool InsertThietBi(string maPhong, string tenThietBi, int soLuongThietBi, int soLuongThietBiHong, int soLuongThietBiToiDa)
        {
            if(Check(maPhong, tenThietBi) == 1)
            {
                string query = string.Format("INSERT dbo.ThietBi (MaPhong, TenThietBi, SoLuongThietBi, SoLuongThietBiHong, SoLuongThietBiToiDa )VALUES  ( N'{0}', N'{1}', N'{2}', {3}, {4} )", maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            else
            {
                string query = string.Format("UPDATE dbo.ThietBi SET SoLuongThietBi = SoLuongThietBi +1, SoLuongThietBiToiDa = SoLuongThietBiToiDa +1  WHERE dbo.fuConvertToUnsign1(MaPhong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND dbo.fuConvertToUnsign1(TenThietBi) LIKE N'%' + dbo.fuConvertToUnsign1(N'{1}') + '%' ", maPhong, tenThietBi);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
        }
        //sửa 
        public bool UpdateThietBi(int maThietBi, string maPhong, string tenThietBi, int soLuongThietBi, int soLuongThietBiHong, int soLuongThietBiToiDa)
        {
            if(Check(maPhong, tenThietBi) == 1)
            {
                string query = string.Format("UPDATE dbo.ThietBi SET MaPhong = N'{1}', TenThietBi = N'{2}', SoLuongThietBi = {3}, SoLuongThietBiHong = {4}, SoLuongThietBiToiDa = {5} WHERE MaThietBi = {0} ", maThietBi, maPhong, tenThietBi, soLuongThietBi, soLuongThietBiHong, soLuongThietBiToiDa);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            else
            {
                DeleteThietBi(maThietBi);
                string query = string.Format("UPDATE dbo.ThietBi SET SoLuongThietBi = SoLuongThietBi + {2}, SoLuongThietBiToiDa = SoLuongThietBiToiDa + {3}  WHERE dbo.fuConvertToUnsign1(MaPhong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND dbo.fuConvertToUnsign1(TenThietBi) LIKE N'%' + dbo.fuConvertToUnsign1(N'{1}') + '%' ", maPhong, tenThietBi, soLuongThietBi, soLuongThietBiToiDa);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
           
        }
        public bool UpdateMaPhongThietBiToNull(string maPhong)
        {
            string query = string.Format("UPDATE dbo.ThietBi SET MaPhong = null WHERE MaPhong = N'{0}'", maPhong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //xóa
        public bool DeleteThietBi(int maThietBi)
        {
            string query = string.Format("Delete dbo.ThietBi where MaThietBi = {0}", maThietBi);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //tìm kiếm theo mã phòng
        public List<ThietBi> SearchThietBiByMaPhong(string maPhong)
        {
            List<ThietBi> thietBiList = new List<ThietBi>();

            string query = string.Format("SELECT * FROM dbo.ThietBi WHERE dbo.fuConvertToUnsign1(MaPhong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", maPhong);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                ThietBi thietBi = new ThietBi(item);
                thietBiList.Add(thietBi);
            }

            return thietBiList;
        }
    }
}
