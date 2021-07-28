using System;

namespace Baitap18
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 18: Tính S(n) = 1 + x^2/2! + x^4/4! + … + x^2n/(2n)!");
            int n, i=0,t;
            double s = 0,x,b;
            double a;
            Console.WriteLine("Nhap gia tri n");
            n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap gia tri x");
            x = double.Parse(Console.ReadLine()!);
            while (i<n)
            {
                //Console.WriteLine($"gia tri i: {i}");
                i++;
                int r = 0;
                a = 1;
                // tinh 2n!
                while (r<(2*i))
                {
                    r++;
                    //Console.WriteLine($"gia tri a: {a}");
                    //Console.WriteLine($"gia tri r: {r}");
                    a *= r;
                }
                // tinh can
                t = 0;
                b = x;
                while (t<(a/(2*i)))
                {
                    t++;
                    b /= x;
                }
                s += b;
                //Console.WriteLine($"Gia tri term S: {s}");
               
            }
            Console.WriteLine($"Ket qua ham so la {s}");
        }
    }
}