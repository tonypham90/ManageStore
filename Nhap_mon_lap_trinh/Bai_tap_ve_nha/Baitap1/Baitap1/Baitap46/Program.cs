using System;

namespace Baitap46
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 46: Hãy đếm số lượng chữ số lẻ của số nguyên dương n");
            Console.WriteLine("Nhap so duong n");
            string n = Console.ReadLine()!;
            if (n != null)
            {
                int len = n.Length;
                int i = 0;
                int count=0;
                while (i< len)
                {
                    string letter = Convert.ToString(n[i]);
                    // Console.WriteLine(letter);
                    var result=Convert.ToInt32(letter);
                    if (result % 2 != 0)
                    {
                        count++;
                    }
                    //Console.WriteLine(result);
                    i++;
                
                }
                Console.WriteLine($"số lượng số lẽ trong chuỗi số là {count}");
            }
            else
                Console.WriteLine("Value can not null");
        }
    }
}