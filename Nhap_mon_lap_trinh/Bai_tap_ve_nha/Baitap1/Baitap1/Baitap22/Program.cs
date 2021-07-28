using System;

namespace Baitap22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 22:Tính tích tất cả các “ước số” của số nguyên dương n");
            Console.WriteLine("Nhap gia tri n");
            int n = int.Parse(Console.ReadLine()!);
            int i = 0,r=1;
            while (i < n)
            {
                i++;
                
                if (n % i == 0)
                {
                    Console.WriteLine($"{i} la uoc so cua {n}");
                    r *= i;
                }
            }
            Console.WriteLine($"Tích cac gia tri uoc so {n} la {r}");
        }
    }
}