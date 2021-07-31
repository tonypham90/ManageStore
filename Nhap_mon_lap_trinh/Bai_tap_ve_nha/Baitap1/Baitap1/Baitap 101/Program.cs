using System;

namespace Baitap_101
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int thang, nam, ngay;
            Console.WriteLine("xac dinh so ngay trong thang");
            Console.WriteLine("Nhap THANG");
            thang = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Nhap nam");
            nam = int.Parse(Console.ReadLine() ?? string.Empty);
            //thang 31 ngay: 1,3,5,7,8,10,12
            //thang 30 ngay: 4,6,9,11
            //thang 28 or 29: 2

            if (thang == 2)
                if ((nam % 4 == 0 && nam % 100 != 0) || (nam % 100 == 0 && nam % 400 == 0))
                {
                    ngay = 29;
                }
                else
                {
                    ngay = 28;
                }
            else if ((thang == 1 )|| thang == 3 || thang == 5|| thang == 7 || thang ==8 || thang == 10||thang == 12)
            {
                ngay = 31;
            }
            else
            {
                ngay = 30;
            }
            Console.WriteLine($"Ngay cua thang {thang} nam {nam} la: {ngay} ngay");
        }
    }
}