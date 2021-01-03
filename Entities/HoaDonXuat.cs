using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanVatLieuXayDung.Entities
{
    class HoaDonXuat
    {
        private string mahoadonxuat, tenVatlieu, loaiVatlieu;
        private int soluong;
        private double giaban, tongtien;
        public HoaDonXuat(string mahoadonxuat,string tenVatlieu,string loaiVatlieu,int soluong,double giaban,double tongtien)
        {
            this.mahoadonxuat = mahoadonxuat;
            this.tenVatlieu = tenVatlieu;
            this.loaiVatlieu = loaiVatlieu;
            this.soluong = soluong;
            this.giaban = giaban;
            this.tongtien = tongtien;
        }
        override
            public string ToString()
        {
            return mahoadonxuat + "#" + tenVatlieu + "#" + loaiVatlieu + "#" + soluong + "#" + giaban + "#" + tongtien;
        }
        public string Mahoadonxuat { get => mahoadonxuat; set => mahoadonxuat = value; }
        public string TenVatlieu { get => tenVatlieu; set => tenVatlieu = value; }
        public string LoaiVatlieu { get => loaiVatlieu; set => loaiVatlieu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
        public double Tongtien { get => tongtien; set => tongtien = value; }
    }
}
