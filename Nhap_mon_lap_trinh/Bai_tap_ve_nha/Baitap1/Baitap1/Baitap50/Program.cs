using System;

namespace Baitap50
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 50: Hãy tìm số đảo ngược của số nguyên dương n");
            var songuoc = "";
            string so = Console.ReadLine()!;
            int i=0;
            while (so != null && i < so.Length)
            {
                songuoc = so[i] + songuoc;
                i++;
            }
            Console.WriteLine($"Ket qua dao nguoc so tu nhien {so} la {songuoc}");
        }
    }
}