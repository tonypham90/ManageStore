using System;

namespace Baitap25
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 25: Tính tổng tất cả các “ước số chẵn” của số nguyên dương n");
            Console.WriteLine("Nhap gia tri n");
            int n = int.Parse(Console.ReadLine()!);
            int i = 0,r=0;
            while (i < n)
            {
                i++;
                
                if ((n % i == 0) && i % 2 == 0)
                {
                    Console.WriteLine($"{i} la uoc so chan cua {n}");
                    r += i;
                }
            }
            Console.WriteLine($"Tổng các giá trị ước số {n} la {r}");
        }
    }
}