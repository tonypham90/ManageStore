using System;

namespace Baitap34
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 34: Tính S(n) = CanBac2(n+CanBac2(n – 1 + CanBac2( n – 2 + … + CanBac2(2 + CanBac2(1)  có n dấu căn");
            Console.WriteLine("Nhap gia tri n");
            double r = 0;
            int n = int.Parse(Console.ReadLine()!);
            int i = 0;
            while (i<n)
            {
                i++;
                r = Math.Sqrt(i+r);
            }
            Console.WriteLine($"Gia tri cua ham so {r}");
        }
    }
}