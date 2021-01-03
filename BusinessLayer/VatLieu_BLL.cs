using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using QuanLyBanVatLieuXayDung.Entities;
using QuanLyBanVatLieuXayDung.BusinessLayer.Interface;

namespace QuanLyBanVatLieuXayDung.DataAccess
{
    class VatLieu_BLL : IVatLieu
    {
        public void Hien(ArrayList arrayList)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|{4,-40}|", "Tên vật liệu","Loại vật liệu","Xuất xứ","Số lượng","Giá bán");
            foreach(VatLieu vatlieu in arrayList)
            {
                display(vatlieu);
            }
        }
        public VatLieu findvatlieu(ArrayList arrayList,string keyword)
        {
            VatLieu kq = null;
            foreach(VatLieu vatlieu in arrayList)
            {
                if (vatlieu.Tenvatlieu.Equals(keyword))
                {
                    kq = vatlieu;
                }
            }
            return kq;
        }
        public void Sua(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên vật liệu cần sửa: ");
            string keyword = Console.ReadLine();
            VatLieu vatlieu = findvatlieu(arrayList, keyword); 
            Console.Write("                                Nhập tên vật liệu : ");
            vatlieu.Tenvatlieu = Console.ReadLine();
            Console.Write("                                Nhập loại vật liệu: ");
            vatlieu.Loaivatlieu = Console.ReadLine();
            Console.WriteLine("                                NHập xuất xứ: ");
            vatlieu.Xuatxu = Console.ReadLine();
            Console.WriteLine("                                Nhập số lượng: ");
            vatlieu.Soluong = int.Parse(Console.ReadLine());
            Console.WriteLine("                                Nhập giá bán: ");
            vatlieu.Giaban = double.Parse(Console.ReadLine());
        }
        public void display(VatLieu vatlieu)
        {
            Console.WriteLine("                                |{0,-20}|{1,-20}|{2,-20}|{3,-30}|{4,-40}|", vatlieu.Tenvatlieu,vatlieu.Loaivatlieu,vatlieu.Xuatxu,vatlieu.Soluong,vatlieu.Giaban);
        }
        public void Them(ArrayList arrayList)
        {
     
            Console.Write("                                Nhập tên vật liệu: ");
            string tenvatlieu = Console.ReadLine();
            Console.Write("                                Nhập loại vật liệu: ");
            string loaivatlieu = Console.ReadLine();
            Console.Write("                                NHập xuất xứ: ");
            string xuatxu = Console.ReadLine();
            Console.Write("                                Nhập số lượng: ");
            int soluong = int.Parse(Console.ReadLine());
            Console.Write("                                Nhập giá bán: ");
            double gia = double.Parse(Console.ReadLine());
            arrayList.Add(new VatLieu(tenvatlieu, loaivatlieu, xuatxu, soluong, gia));
        }

        public void Timkiem(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên vật liệu: ");
            string keyword = Console.ReadLine();
            display(findvatlieu(arrayList, keyword));

        }

        public void Xoa(ArrayList arrayList)
        {
            Console.Write("                                Nhập tên vật liệu: ");
            string keyword = Console.ReadLine();
            arrayList.Remove(findvatlieu(arrayList, keyword));
        }
    }
}
