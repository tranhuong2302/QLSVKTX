using System;
using System.Data;

namespace QLSVKTX.DTO
{
    public class NhanVien
    {
        private string hoTen;
        private DateTime? ngaySinh;
        private string diaChi;
        private string chucVu;
        private string sdt;
        public NhanVien(string hoTen, DateTime? ngaySinh, string diaChi, string chucVu, string sdt)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.ChucVu = chucVu;
            this.Sdt = sdt;
        }
        public NhanVien(DataRow row)
        {
            this.HoTen = row["hoten"].ToString();
            this.NgaySinh = (DateTime?)row["ngaysinh"];
            this.DiaChi = row["diachi"].ToString();
            this.ChucVu = row["chucvu"].ToString();
            this.Sdt = row["sdt"].ToString();
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string Sdt { get => sdt; set => sdt = value; }
    }
}
