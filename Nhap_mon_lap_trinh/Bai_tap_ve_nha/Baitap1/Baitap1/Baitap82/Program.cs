using System;

namespace Baitap82
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 82: Viết chương trình tìm số lớn nhất trong 3 số thực a, b, c");
            double a, b, c,max;
            Console.WriteLine("Nhap gia tri a");
            a=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri b");
            b=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap gia tri c");
            c=double.Parse(Console.ReadLine());
            if (a>=b && a>= c)
            {
                max = a;
            }
            else if (b>= c)
            {
                max = b;
            }
            else
            {
                max = c;
            }
            Console.WriteLine($"Giá trị lớn nhất của chuỗi số là: {max}");
        }
    }
}