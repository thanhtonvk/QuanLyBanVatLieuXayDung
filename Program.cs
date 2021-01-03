using System.Text;
using System;
using QuanLyBanVatLieuXayDung.Presenation;
using System.Collections;

namespace QuanLyBanVatLieuXayDung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ArrayList arrayList = new ArrayList();
            DangNhap_GUI.Chon(arrayList);
            
        }
    }
}
