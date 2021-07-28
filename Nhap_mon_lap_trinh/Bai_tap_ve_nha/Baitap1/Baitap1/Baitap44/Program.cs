using System;

namespace Baitap44
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 44: Hãy tính tổng các chữ số của số nguyên dương n");
            Console.WriteLine("Nhap so duong n");
            string n = Console.ReadLine();
            if (n != null)
            {
                int len = n.Length;
                int i = 0,result=0;
                while (i< len)
                {
                    string letter = Convert.ToString(n[i]);
                    Console.WriteLine(letter);
                    result += Convert.ToInt32(letter);
                    Console.WriteLine(result);
                    i++;
                
                }
                Console.WriteLine($"Tong chuoi so la {result}");
            }
            else
            {
                Console.WriteLine("Value can not null");
            }
        }
    }
}