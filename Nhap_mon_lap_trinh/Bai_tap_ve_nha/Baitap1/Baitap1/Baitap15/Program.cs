using System;

namespace Baitap15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 15: Tính S(n) = 1 + 1/(1 + 2) + 1/ (1 + 2 + 3) + ….. + 1/ (1 + 2 + 3 + …. + N)");
            int n, i=0;
            double s = 0, r, x,a;
            Console.WriteLine("Nhap gia tri n");
            n = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("Nhap gia tri x");
            //x = double.Parse(Console.ReadLine()!);
            while (i<n)
            {
                //Console.WriteLine($"gia tri i: {i}");
                i++;
                r = 0;
                a = 0;
                while (r<(i))
                {
                    r++;
                    //Console.WriteLine($"gia tri a: {a}");
                    //Console.WriteLine($"gia tri r: {r}");
                    a += r;
                }
                s += 1/a;
                //Console.WriteLine($"Gia tri term S: {s}");
               
            }
            Console.WriteLine($"Ket qua ham so la {s}");
        }
    }
}