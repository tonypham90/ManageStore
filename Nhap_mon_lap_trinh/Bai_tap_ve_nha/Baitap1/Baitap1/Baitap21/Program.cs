using System;

namespace Baitap21
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 21: Tính tổng tất cả các “ ước số” của số nguyên dương n");
            Console.WriteLine("Nhap gia tri n");
            int n = int.Parse(Console.ReadLine()!);
            int i = 0,r=0;
            while (i < n)
            {
                i++;
                
                if (n % i == 0)
                {
                    Console.WriteLine($"{i} la uoc so cua {n}");
                    r += i;
                }
            }
            Console.WriteLine($"Tong cac gia tri uoc so {n} la {r}");
        }
    }
}