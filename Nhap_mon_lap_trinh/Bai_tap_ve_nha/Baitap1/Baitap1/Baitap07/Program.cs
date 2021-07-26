using System;

namespace Baitap07
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 7: Tính S(n) = ½ + 2/3 + ¾ + …. + n / n + 1");
            double s = 0, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                // ReSharper disable once PossibleLossOfFraction
                s += i/(i+1);
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}