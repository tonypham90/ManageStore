using System;
namespace Baitap72
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Tính S(x, n) = – x + x^2/2! – x^3/3! + … + (-1)^n * x^n/n!");
            double s = 0, n, x, giaithua = 1;
            double i = 0, a;
            Console.WriteLine("Nhap so lan tinh n");
            n = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap so lan tinh x");
            x = double.Parse(Console.ReadLine()!);
            while (i < n)
            {
                //tính n!
                a = 0;
                while (a < i)
                {
                    a++;
                    giaithua *= a;
                }

                i++;
                // ReSharper disable once PossibleLossOfFraction
                s += (Math.Pow(-1, i) * Math.Pow(x, i)) / (giaithua);
            }

            Console.WriteLine($"Kết quả bài toán là: {s:F}");
        }
    }
}