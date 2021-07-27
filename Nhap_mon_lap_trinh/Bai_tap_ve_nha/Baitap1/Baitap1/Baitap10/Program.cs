using System;

namespace Baitap10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tính T(x, n) = x^n");
            double s = 1, n,x;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap so lan tinh x");
            x = double.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                // ReSharper disable once ConvertToCompoundAssignment
                s = s * x;
            }
            Console.WriteLine($"Ket qua phuong trinh la {s:F}");
        }
    }
}