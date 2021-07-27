using System;

namespace Baitap12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 12: Tính S(n,x) = x + x^2 + x^3 + … + x^n");
            int n, i=0;
            double s = 0, r, x,a;
            Console.WriteLine("Nhap gia tri n");
            n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap gia tri x");
            x = double.Parse(Console.ReadLine()!);
            while (i<n)
            {
                i++;
                //Console.WriteLine($"gia tri i: {i}");
                r = 0;
                a = 1;
                while (r<i)
                {
                    r++;
                    //Console.WriteLine($"gia tri a: {a}");
                    //Console.WriteLine($"gia tri r: {r}");
                    a *= x;
                }
                s += a;
                //Console.WriteLine($"Gia tri term S: {s}");
            }
            Console.WriteLine($"Ket qua ham so la {s}");
        }
    }
}