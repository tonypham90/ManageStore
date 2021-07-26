using System;

namespace Baitap08
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 8: Tính S(n) = ½ + ¾ + 5/6 + … + 2n + 1/ 2n + 2");
            double s = 0, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                // ReSharper disable once PossibleLossOfFraction
                s += (2*i+1)/(2*i+2);
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}