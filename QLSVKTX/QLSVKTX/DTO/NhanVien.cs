using System;
using System.Data;

namespace QLSVKTX.DTO
{
    public class NhanVien
    {
        private string maNV;

        private string hoTen;

        private DateTime ngaySinh;

        private string sdt;

        private string diaChi;

        private string gioiTinh;

        private string cccd;

        private string chucVu;

        private string matKhau;

        private string trangThai;

        public NhanVien(string maNV, string hoTen, DateTime ngaySinh, string sdt, string diaChi, string gioiTinh, string cccd, string chucVu, string matKhau, string trangThai)
        {
            this.MaNV = maNV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.Cccd = cccd;
            this.ChucVu = chucVu;
            this.MatKhau = matKhau;
            this.TrangThai = trangThai;

        }
        public NhanVien(DataRow row)
        {
            this.MaNV = row["MaNhanVien"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.Sdt = row["SoDienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.GioiTinh = row["GioiTinh"].ToString();
            this.Cccd = row["CMND_CCCD"].ToString();
            this.ChucVu = row["ChucVu"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.TrangThai = row["TrangThai"].ToString();

        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

    }
}
