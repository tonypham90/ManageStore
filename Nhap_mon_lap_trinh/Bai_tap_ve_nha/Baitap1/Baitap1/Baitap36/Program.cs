using System;

namespace Baitap36
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Tính S(n) = CanBac2(n! + CanBac2((n-1)! +CanBac2((n – 2)! + … + CanBac2(2!) + CanBac2(1!)))) có n dấu căn");
            Console.WriteLine("Nhap gia tri n");
            double r = 0,g = 1;
            int n = int.Parse(Console.ReadLine()!);
            int i = 0;
            while (i<n)
            {
                i++;
                int c = 0;
                // tinh giai thua cua n
                while (c < i)
                {
                    c++;
                    g *= c;
                }

                r = Math.Sqrt(g+r);
            }
            Console.WriteLine($"Gia tri cua ham so {r}");
        }
    }
}