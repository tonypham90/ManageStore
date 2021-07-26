using System;

namespace Baitap03
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 3: Tính S(n) = 1 + ½ + 1/3 + … + 1/n");
            double s = 0, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                // ReSharper disable once PossibleLossOfFraction
                s += 1/i;
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}