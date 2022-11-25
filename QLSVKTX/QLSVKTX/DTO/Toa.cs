using System;
using System.Data;

namespace QLSVKTX.DTO
{
    public class Toa
    {
        private string maToa;
        private string tenToa;
        private int soPhong;
        private string maNguoiQuanLy;

        public string MaToa { get => maToa; set => maToa = value; }
        public string TenToa { get => tenToa; set => tenToa = value; }
        public int SoPhong { get => soPhong; set => soPhong = value; }
        public string MaNguoiQuanLy { get => maNguoiQuanLy; set => maNguoiQuanLy = value; }
        public Toa(string maToa, string tenToa, int soPhong, string maNguoiQuanLy)
        {
            this.MaToa = maToa;
            this.TenToa = tenToa;
            this.SoPhong = soPhong;
            this.MaNguoiQuanLy = maNguoiQuanLy;
        }
        public Toa(DataRow row)
        {
            this.MaToa = row["MaToa"].ToString();
            this.TenToa = row["TenToa"].ToString();
            this.SoPhong = (int)row["SoPhong"];
            this.MaNguoiQuanLy = row["MaNguoiQuanLy"].ToString();
        }
    }
}
