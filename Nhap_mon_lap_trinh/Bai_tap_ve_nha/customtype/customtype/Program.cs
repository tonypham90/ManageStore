using System;

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

            TOADO a, b, c;
            a = dothi.nhapToaDo("Nhap Toa do diem A: ");
            b = dothi.nhapToaDo("Nhap Toa do diem B: ");
            c = dothi.nhapToaDo("Nhap Toa do diem C: ");
            float chuvi;
            chuvi = dothi.ChuVi(a,b,c);
            Console.WriteLine($"chuvi tam giac A B C la: {chuvi:F}");

        }
    }
}