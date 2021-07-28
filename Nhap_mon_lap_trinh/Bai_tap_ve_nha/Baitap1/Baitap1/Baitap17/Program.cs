using System;

namespace Baitap17
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 17: Tính S(n) = x + x^2/2! + x^3/3! + … + x^n/N!");
            int n, i=0;
            double s = 0;
            double a;
            Console.WriteLine("Nhap gia tri n");
            n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap gia tri x");
            double x = double.Parse(Console.ReadLine()!);
            while (i<n)
            {
                //Console.WriteLine($"gia tri i: {i}");
                i++;
                int r = 0;
                a = 1;
                // tinh giai thua
                while (r<(i-1))
                {
                    r++;
                    //Console.WriteLine($"gia tri a: {a}");
                    //Console.WriteLine($"gia tri r: {r}");
                    a *= r;
                }
                s += Math.Sqrt(i/a) * x;
                //Console.WriteLine($"Gia tri term S: {s}");
               
            }
            Console.WriteLine($"Ket qua ham so la {s}");
        }
    }
}