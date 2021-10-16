using System;
using System.Net.Sockets;

namespace customtype
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PHANSO a,b;
            a = xulyphanso.inputPhanSo("Nhap Phan so a: ");
            b = xulyphanso.inputPhanSo("Nhap phan so b: ");
            //xulyphanso.xuatPhanSo(a);
            PHANSO kq;
            kq = xulyphanso.Cong2PhanSo(a, b);
            xulyphanso.xuatPhanSo(kq);*/
            
            DAGIAC d;
            float chuvi;
            d = xulydagiac.NhapDaGiac("Nhap Da Giac: ");
            chuvi = xulydagiac.TinhChuVi(d);
            Console.WriteLine($"Chu vi cua da giac la {chuvi}");
        }
    }
}