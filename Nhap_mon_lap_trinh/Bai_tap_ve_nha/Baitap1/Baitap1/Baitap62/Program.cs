using System;

namespace Baitap62
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 62: Cho 2 số nguyên dương a và b. Hãy tìm ước chung lớn nhất của 2 số này.");
            Console.WriteLine("Nhap so a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so b");
            int b = int.Parse(Console.ReadLine());
            int i=0;
            int uocchung = 0;
            while (i < a && i< b)
            {
                i++;
                if (a % i == 0 && b % i == 0)
                {
                    uocchung = Math.Max(i, uocchung);
                }
                
            }
            Console.WriteLine($"uoc so lon nhat cua {a} va {b} la {uocchung}");

        }
    }
}