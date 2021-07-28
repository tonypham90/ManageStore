using System;

namespace Baitap45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 45: Hãy tính tích các chữ số của số nguyên dương n");
            Console.WriteLine("Nhap so duong n");
            string n = Console.ReadLine();
            if (n != null)
            {
                int len = n.Length;
                int i = 0,result=1;
                while (i< len)
                {
                    string letter = Convert.ToString(n[i]);
                    // Console.WriteLine(letter);
                    result *= Convert.ToInt32(letter);
                    //Console.WriteLine(result);
                    i++;
                
                }
                Console.WriteLine($"Tích chuỗi số là {result}");
            }
            else
            {
                Console.WriteLine("Value can not null");
            }
        }
    }
}