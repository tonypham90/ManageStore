using System;

namespace thuchanh
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh giai thua n!");
            Console.Write("nhap gia tri n= ");
            var n =int.Parse(Console.ReadLine()!);
            n = Math.Abs(n);
            Baitapvenha.KiemTraThanhPhanLe(n);
            // Console.WriteLine($"Ket qua tinh la {n}");
            // Console.Write("tong cac so nguyen to cua n = ");
            // int x = int.Parse(Console.ReadLine()!);
            // int y = int.Parse(Console.ReadLine()!);
            // var total = 0;
            // // for (int i = 1; i < n; i++)
            // // {
            // //     bool a = Songuyento(i);
            // //     if (a)
            // //     { 
            // //         Console.WriteLine($"là số {i} nguyên tố");
            // //         total += i;
            // //     }
            //
            // // }
            // Console.WriteLine($"Tong so nguyen to la {x} {y}");
            // xulysonguyen.Hoanvi(ref x, ref y);
            // Console.WriteLine($"Tong so nguyen to la {x} {y}");
        }
    }
}