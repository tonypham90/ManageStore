using System;

namespace Baitap14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 14: Tính S(n) = x + x^3 + x^5 + … + x^(2n + 1)");
            int n, i=0;
            double s = 0, r, x,a;
            Console.WriteLine("Nhap gia tri n");
            n = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap gia tri x");
            x = double.Parse(Console.ReadLine()!);
            while (i<n)
            {
                //Console.WriteLine($"gia tri i: {i}");
                r = 0;
                a = 1;
                while (r<(2*i+1))
                {
                    r++;
                    //Console.WriteLine($"gia tri a: {a}");
                    //Console.WriteLine($"gia tri r: {r}");
                    a *= x;
                }
                s += a;
                //Console.WriteLine($"Gia tri term S: {s}");
                i++;
            }
            Console.WriteLine($"Ket qua ham so la {s}");
        }
    }
}