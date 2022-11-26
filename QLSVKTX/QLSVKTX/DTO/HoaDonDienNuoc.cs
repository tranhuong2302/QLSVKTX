using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSVKTX.DTO
{
    public class HoaDonDienNuoc
    {
        private int maHoaDon;
        private string maPhong;
        private string tenHoaDon;
        private string trangThai;
        private float tienDien;
        private float tienNuoc;
        private DateTime ngayTao;

        public HoaDonDienNuoc(int maHoaDon, string maPhong, string tenHoaDon, string trangThai, float tienDien, float tienNuoc, DateTime ngayTao)
        {
            this.MaHoaDon = maHoaDon;
            this.MaPhong = maPhong;
            this.TenHoaDon = tenHoaDon;
            this.TrangThai = trangThai;
            this.TienDien = tienDien;
            this.TienNuoc = tienNuoc;
            this.NgayTao = ngayTao;
        }
        public HoaDonDienNuoc(DataRow row)
        {
            this.MaHoaDon = (int)row["MaHoaDon"];
            this.MaPhong = row["MaPhong"].ToString();
            this.TenHoaDon = row["TenHoaDon"].ToString();
            this.TrangThai = row["TrangThai"].ToString();
            this.TienDien = (float)Convert.ToDouble(row["TienDien"].ToString());
            this.TienNuoc = (float)Convert.ToDouble(row["TienNuoc"].ToString());
            this.NgayTao = (DateTime)row["NgayTao"];
        }

        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenHoaDon { get => tenHoaDon; set => tenHoaDon = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public float TienDien { get => tienDien; set => tienDien = value; }
        public float TienNuoc { get => tienNuoc; set => tienNuoc = value; }
        public DateTime NgayTao { get => ngayTao; set => ngayTao = value; }
    }
}
