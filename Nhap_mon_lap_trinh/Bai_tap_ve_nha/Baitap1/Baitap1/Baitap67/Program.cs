using System;



namespace Baitap67
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 67: Tính S(x, n) = x – x^2 + x^3 + … + (-1)^n+1 * x^n");
            double s = 0, n,x;
            double i = 0;
            Console.WriteLine("Nhap so lan tinh n");
            n = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Nhap so lan tinh n");
            x = double.Parse(Console.ReadLine()!);
            while (i < n)
            {
                
                
                i++;
                // ReSharper disable once PossibleLossOfFraction
                s += (Math.Pow(-1,i+1) * Math.Pow(x,i));
            }
            Console.WriteLine($"Kết quả bài toán là: {s:F}");
        }
    }
}