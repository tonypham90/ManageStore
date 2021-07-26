using System;

namespace Baitap04
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 4: Tính S(n) = ½ + ¼ + … + 1/2n");
            double s = 0, n;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                // ReSharper disable once PossibleLossOfFraction
                s += 1/(2*i);
            }
            Console.WriteLine($"Ket qua bai toan la: {s:F}");
        }
    }
}