using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSVKTX.DTO
{
    public class ThietBi
    {
        private int maThietBi;
        private string maPhong;
        private string tenThietBi;
        private int soLuongThietBi;
        private int soLuongThietBiHong;
        private int soLuongThietBiToiDa;

        public ThietBi(int maThietBi, string maPhong, string tenThietBi, int soLuongThietBi, int soLuongThietBiHong, int soLuongThietBiToiDa)
        {
            this.MaThietBi = maThietBi;
            this.MaPhong = maPhong;
            this.TenThietBi = tenThietBi;
            this.SoLuongThietBi = soLuongThietBi;
            this.SoLuongThietBiHong = soLuongThietBiHong;
            this.SoLuongThietBiToiDa = soLuongThietBiToiDa;
        }
        public ThietBi(DataRow row)
        {
            this.MaThietBi = (int)row["MaThietBi"];
            this.MaPhong = row["MaPhong"].ToString();
            this.TenThietBi = row["TenThietBi"].ToString();
            this.SoLuongThietBi = (int)row["SoLuongThietBi"];
            this.SoLuongThietBiHong = (int)row["SoLuongThietBiHong"];
            this.SoLuongThietBiToiDa = (int)row["SoLuongThietBiToiDa"];
        }

        public int MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenThietBi { get => tenThietBi; set => tenThietBi = value; }
        public int SoLuongThietBi { get => soLuongThietBi; set => soLuongThietBi = value; }
        public int SoLuongThietBiHong { get => soLuongThietBiHong; set => soLuongThietBiHong = value; }
        public int SoLuongThietBiToiDa { get => soLuongThietBiToiDa; set => soLuongThietBiToiDa = value; }
    }
}
