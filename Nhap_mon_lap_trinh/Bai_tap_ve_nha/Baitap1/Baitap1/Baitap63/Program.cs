using System;

namespace Baitap63
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 63: Cho 2 số nguyên dương a và b. Hãy tìm bội chung nhỏ nhất của 2 số này");
            Console.WriteLine("Nhap so a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            int b = int.Parse(Console.ReadLine());
            int i = Math.Max(a,b);
            int minboiso = 0;
            while (minboiso==0)
            {
                i++;
                // Console.WriteLine(i);
                if (i % a == 0 && i %b == 0)
                {
                    minboiso = i;
                    break;
                }
                
            }
            Console.WriteLine($"uoc so lon nhat cua {a} va {b} la {minboiso}");

        }
    }
}