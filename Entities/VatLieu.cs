using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyBanVatLieuXayDung.Entities
{
    class VatLieu
    {
        private string tenvatlieu, loaivatlieu, xuatxu;
        private int soluong;
        private double giaban;
        public VatLieu(string tenvatlieu,string loaivatlieu,string xuatxu,int soluong,double giaban)
        {
            this.tenvatlieu = tenvatlieu;
            this.loaivatlieu = loaivatlieu;
            this.xuatxu = xuatxu;
            this.soluong = soluong;
            this.giaban = giaban;
        }
        override
        public  string ToString()
        {
            return tenvatlieu + "#" + loaivatlieu + "#" + xuatxu + "#" + soluong + "#" + giaban;
        }
        public string Tenvatlieu { get => tenvatlieu; set => tenvatlieu = value; }
        public string Loaivatlieu { get => loaivatlieu; set => loaivatlieu = value; }
        public string Xuatxu { get => xuatxu; set => xuatxu = value; }
        public int Soluong { get => soluong; set => soluong = value; }
        public double Giaban { get => giaban; set => giaban = value; }
    }
}
