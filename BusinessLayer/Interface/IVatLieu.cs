using System;
using System.Collections;
using System.Text;

namespace QuanLyBanVatLieuXayDung.BusinessLayer.Interface
{
    interface IVatLieu
    {
        void Them(ArrayList arrayList);
        void Hien(ArrayList arrayList);
        void Sua(ArrayList arrayList);
        void Xoa(ArrayList arrayList);
        void Timkiem(ArrayList arrayList);
    }
}
