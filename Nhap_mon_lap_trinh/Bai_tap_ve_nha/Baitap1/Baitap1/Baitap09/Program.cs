using System;

namespace Baitap09
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Tính T(n) = 1 x 2 x 3…x N");
            double s = 1, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                //Console.WriteLine($"gia tri i {i}");
                // ReSharper disable once PossibleLossOfFraction
                s = s * i;
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}