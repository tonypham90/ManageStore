using System;

namespace Baitap59
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 59: Hãy kiểm tra số nguyên dương n có phải là số đối xứng hay không");
            var songuoc = "";
            string so = Console.ReadLine()!;
            int i=0;
            while (so != null && i < so.Length)
            {
                songuoc = so[i] + songuoc;
                i++;
            }

            if (songuoc == so)
            {
                Console.WriteLine($"So {so} la So doi xung");
            }
            else
            {
                Console.WriteLine($"So {so} khong phai la so dou su");
            }
            
        }
    }
}