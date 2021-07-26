using System;

namespace Baitap2
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 2: Tính S(n) = 1^2 + 2^2 + … + n^2");
            double s = 0, n;
            int i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                s = Math.Pow(n, 2);
            }
            Console.WriteLine($"Ket qua bai toan la: {s}");
        }
    }
}