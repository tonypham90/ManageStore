using System;

namespace Baitap13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 13: Tính S(n) = x^2 + x^4 + … + x^2n");
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
                while (r<(i*2))
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