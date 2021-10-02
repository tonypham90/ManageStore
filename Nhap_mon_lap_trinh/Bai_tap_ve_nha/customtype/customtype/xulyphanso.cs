using System;

namespace customtype
{
    public struct PHANSO
    {
        public int tuso;
        public int mauso;
    }
    public class xulyphanso
    {
        public static PHANSO inputPhanSo(string ghichu)
        {
            Console.WriteLine(ghichu);
            PHANSO kq;
            kq.tuso = xulysonguyen.NhapSoNguyen("Nhap tu so: ");
            kq.mauso = xulysonguyen.NhapSoNguyen("Nhap mau so: ");
            return kq;
        }

        public static void xuatPhanSo(PHANSO p)
        {
            Console.WriteLine($"{p.tuso}/{p.mauso}");
        }

        public static PHANSO Cong2PhanSo(PHANSO a, PHANSO b)
        {
            PHANSO kq;
            kq.tuso = a.tuso * b.mauso + a.mauso + b.tuso;
            kq.mauso = a.mauso * b.mauso;
            return kq;
        }
    }
}