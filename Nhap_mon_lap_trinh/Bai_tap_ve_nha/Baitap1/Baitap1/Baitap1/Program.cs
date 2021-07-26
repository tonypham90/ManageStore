using System;

namespace Baitap1
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            Console.WriteLine("Bai tap 1:\nBài 1: Tính S(n) = 1 + 2 + 3 + … + n");
            int s = 0, i=0;
            Console.WriteLine("nhap so vong lap:");
            var n= int.Parse(Console.ReadLine()!);
            while (i < n)
            {
                i++;
                s += i;
            }
            Console.WriteLine($"ket qua cua bai toan la: {s}");
            
        }
    }
}