using System;

namespace Baitap09
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2");
            double s = 1, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                Console.WriteLine($"gia tri i {i}");
                // ReSharper disable once PossibleLossOfFraction
                s = s * i;
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}