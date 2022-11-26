using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLSVKTX.DTO
{
    public class Phong
    {
        private string maPhong;
        private string maToa;
        private string tenPhong;
        private string loaiPhong;
        private int soLuongSinhVienHienTai;
        private int soLuongSinhVienToiDa;
        private string tinhTrangPhong;

        public Phong(string maPhong, string maToa, string tenPhong, string loaiPhong, int soLuongSinhVienHienTai, int soLuongSinhVienToiDa, string tinhTrangPhong)
        {
            this.MaPhong = maPhong;
            this.MaToa = maToa;
            this.TenPhong = tenPhong;
            this.LoaiPhong = loaiPhong;
            this.SoLuongSinhVienHienTai = soLuongSinhVienHienTai;
            this.SoLuongSinhVienToiDa = soLuongSinhVienToiDa;
            this.TinhTrangPhong = tinhTrangPhong;

        }
        public Phong(DataRow row)
        {
            this.MaPhong = row["MaPhong"].ToString();
            this.MaToa = row["MaToa"].ToString();
            this.TenPhong = row["TenPhong"].ToString();
            this.LoaiPhong = row["LoaiPhong"].ToString();
            this.SoLuongSinhVienHienTai = (int)row["SoLuongSinhVienHienTai"];
            this.SoLuongSinhVienToiDa = (int)row["SoLuongSinhVienToiDa"];
            this.TinhTrangPhong = row["TinhTrangPhong"].ToString();
        }

        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string MaToa { get => maToa; set => maToa = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        public int SoLuongSinhVienHienTai { get => soLuongSinhVienHienTai; set => soLuongSinhVienHienTai = value; }
        public int SoLuongSinhVienToiDa { get => soLuongSinhVienToiDa; set => soLuongSinhVienToiDa = value; }
        public string TinhTrangPhong { get => tinhTrangPhong; set => tinhTrangPhong = value; }
    }
}
