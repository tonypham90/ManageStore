using System;

namespace Baitap09
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 9: Tính T(n) = 1 x 2 x 3…x N");
            double s = 0, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                // ReSharper disable once PossibleLossOfFraction
                s *= i;
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}