using System;

namespace Baitap43
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 43: Hãy đếm số lượng chữ số của số nguyên dương n");
            Console.WriteLine("Nhap so duong n");
            var n = Console.ReadLine();
            Console.WriteLine(n[0]);
            Console.WriteLine($"So chu so cua so duong n la {n.Length}");
            
        }
    }
}