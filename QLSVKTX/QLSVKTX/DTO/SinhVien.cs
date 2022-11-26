using System;
using System.Data;

namespace QLSVKTX.DTO
{
    public class SinhVien
    {
        private string maSV;

        private string hoTen;

        private DateTime ngaySinh;

        private string gioiTinh;

        private int namHoc;

        private string sdt;

        private string diaChi;

        private string cccd;

        private DateTime ngayLamHopDong;

        private DateTime ngayKetThucHopDong;

        private string maPhong;

        private string khoa;

        public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, int namHoc, string sdt, string diaChi, string cccd, DateTime ngayLamHopDong, DateTime ngayKetThucHopDong, string maPhong, string khoa)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.NamHoc = namHoc;
            this.Sdt = sdt;
            this.DiaChi = diaChi;
            this.Cccd = cccd;
            this.NgayLamHopDong = ngayLamHopDong;
            this.NgayKetThucHopDong = ngayKetThucHopDong; 
            this.MaPhong = maPhong;
            this.Khoa = khoa;
        }
        public SinhVien(DataRow row)
        {
            this.MaSV = row["MaSinhVien"].ToString();
            this.HoTen = row["HoTen"].ToString();
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.GioiTinh = row["GioiTinh"].ToString();
            this.NamHoc = (int)row["NamHoc"];
            this.Sdt = row["SoDienThoai"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.Cccd = row["CMND_CCCD"].ToString();
            this.NgayLamHopDong = (DateTime)row["NgayLamHopDong"];
            var ngayKetThucHopDong = row["NgayKetThucHopDong"];
            if (ngayKetThucHopDong.ToString() != "")
                this.NgayKetThucHopDong = (DateTime)ngayKetThucHopDong;
            this.MaPhong = row["MaPhong"].ToString();
            this.Khoa = row["Khoa"].ToString();
        }

        public string MaSV { get => maSV; set => maSV = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public int NamHoc { get => namHoc; set => namHoc = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public DateTime NgayLamHopDong { get => ngayLamHopDong; set => ngayLamHopDong = value; }
        public DateTime NgayKetThucHopDong { get => ngayKetThucHopDong; set => ngayKetThucHopDong = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string Khoa { get => khoa; set => khoa = value; }

    }
}
