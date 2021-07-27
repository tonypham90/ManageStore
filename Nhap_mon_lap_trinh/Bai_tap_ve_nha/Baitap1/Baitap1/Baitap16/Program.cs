using System;

namespace Baitap16
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 16: Tính S(n) = x + x^2/(1 + 2) + x^3/(1 + 2 + 3) + … + x^n/(1 + 2 + 3 + …. + N)");
            int n, i=0;
            double s = 0;
            double a;
            Console.WriteLine("Nhap gia tri n");
            n = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("Nhap gia tri x");
            //x = double.Parse(Console.ReadLine()!);
            while (i<n)
            {
                //Console.WriteLine($"gia tri i: {i}");
                i++;
                int r = 0;
                a = 0;
                while (r<(i))
                {
                    r++;
                    //Console.WriteLine($"gia tri a: {a}");
                    //Console.WriteLine($"gia tri r: {r}");
                    a += r;
                }
                s += i/a;
                //Console.WriteLine($"Gia tri term S: {s}");
               
            }
            Console.WriteLine($"Ket qua ham so la {s}");
        }
    }
}