using System;

namespace Baitap33
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 33: Tính S(n) = CanBac2(2+CanBac2(2+….+CanBac2(2 + CanBac2(2)))) có n dấu căn!");
            Console.WriteLine("Nhap gia tri n");
            double r = 0;
            int n = int.Parse(Console.ReadLine()!);
            int i = 0;
            while (i<n)
            {
                i++;
                r = Math.Sqrt(r) + 2;
                
            }
            Console.WriteLine($"Gia tri cua ham so {r}");
        }
    }
}