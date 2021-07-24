using System;

namespace baitap2
{
    class Program
    {
        static void Main(string[] args)
        {
            int r,N,i;
            i=0;
            r=0;
            Console.WriteLine("nhap so lan N ");
            N = int.Parse(Console.ReadLine());
            while (i<N)
            {
                r += i*i;
            }
            Console.WriteLine($"Ket qua {r}");

        }
    }
}
