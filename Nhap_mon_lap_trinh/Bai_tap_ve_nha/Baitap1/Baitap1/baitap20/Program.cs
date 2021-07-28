using System;

namespace baitap20
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 20: Liệt kê tất cả các “ước số” của số nguyên dương n");
            Console.WriteLine("Nhap gia tri n");
            int n = int.Parse(Console.ReadLine()!);
            int i = 0;
            while (i < n)
            {
                i++;
                if (n % i == 0)
                {
                    Console.WriteLine($"{i} la uoc so cua {n}");
                }
            }
        }
    }
}