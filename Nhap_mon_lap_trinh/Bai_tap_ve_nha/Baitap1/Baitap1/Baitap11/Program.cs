using System;

namespace Baitap11
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 11: Tính S(n) = 1 + 1.2 + 1.2.3 + … + 1.2.3….N");
            int s=0, n, i=0;
            Console.WriteLine("Nhap gia tri n");
            n = int.Parse(Console.ReadLine()!);
            while (i<n)
            {
                i++;
                int a = 1;
                var r = 0;
                while (r<i)
                {
                    r++;
                    a = a*r;
                }
                s += a;
            }
            Console.WriteLine($"Ket qua ham so la {s}");
        }
    }
}