using System.Collections.Generic;
using System.Data;
using QLSVKTX.DTO;

namespace QLSVKTX.DAO
{
    public class ToaDAO
    {
        private static ToaDAO instance;

        internal static ToaDAO Instance
        {
            get { if (instance == null) instance = new ToaDAO(); return instance; }
            private set { instance = value; }
        }
        private ToaDAO() { }
        //Lấy danh sách từ database
        public List<Toa> GetListToa()
        {
            List<Toa> list = new List<Toa>();

            string query = "Select * From dbo.Toa";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Toa toa = new Toa(item);
                list.Add(toa);
            }

            return list;
        }
        //check Trùng
        public int Check(string maToa)
        {
            string check = string.Format("SELECT * FROM dbo.Toa WHERE MaToa = N'{0}'", maToa);
            var test = DataProvider.Instance.ExecuteScalar(check);
            if (test == null)
                return 1;
            else
                return 0;
        }
        //thêm
        public bool InsertToa(string maToa, string tenToa, int soPhong, string MaNguoiQuanLy)
        {
            if (Check(maToa) == 1)
            {
                string query = string.Format("INSERT dbo.Toa (MaToa, TenToa, SoPhong, MaNguoiQuanLy) VALUES (N'{0}',N'{1}',N'{2}', N'{3}')", maToa, tenToa, soPhong, MaNguoiQuanLy);
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                return result > 0;
            }
            else return false;
 
               
        }
        //sửa
        public bool UpdateToa(string maToa, string tenToa, int soPhong, string MaNguoiQuanLy)
        {
            string query = string.Format("UPDATE dbo.Toa SET TenToa = N'{1}', SoPhong = {2}, MaNguoiQuanLy = N'{3}' WHERE MaToa = N'{0}'", maToa, tenToa, soPhong, MaNguoiQuanLy);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateToaToNull(string MaNguoiQuanLy)
        {
            string query = string.Format("UPDATE dbo.Toa SET MaNguoiQuanLy = null WHERE MaNguoiQuanLy = N'{0}'", MaNguoiQuanLy);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateSoPhongHienTaiToaCongMot(string maToa)
        {
            string query = string.Format("UPDATE dbo.Toa SET SoPhong = SoPhong + 1  WHERE MaToa = N'{0}'", maToa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateSoPhongHienTaiToaTruMot(string maToa)
        {
            string query = string.Format("UPDATE dbo.Toa SET SoPhong = SoPhong - 1  WHERE MaToa = N'{0}'", maToa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //xóa
        public bool DeleteToaByMaToa(string maToa)
        {
            PhongDAO.Instance.UpdatePhongToNull(maToa);
            string query = string.Format("DELETE dbo.Toa Where MaToa = N'{0}'", maToa);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        //tìm kiếm theo tên
        public List<Toa> SearchToaByTenToa(string TenToa)
        {
            List<Toa> toaList = new List<Toa>();

            string query = string.Format("SELECT * FROM dbo.Toa WHERE dbo.fuConvertToUnsign1(TenToa) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", TenToa);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Toa toa = new Toa(item);
                toaList.Add(toa);
            }

            return toaList;
        }
        public Toa GetToaByMaToa(string maToa)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From dbo.Toa Where MaToa = '" + maToa + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Toa(item);
            }

            return null;
        }
    }
}
