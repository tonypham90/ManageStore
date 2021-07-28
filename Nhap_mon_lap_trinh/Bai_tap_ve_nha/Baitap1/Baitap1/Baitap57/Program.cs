using System;

namespace Baitap57
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 57: Hãy kiểm tra số nguyên dương n có toàn chữ số chẵn hay không");
            // var songuoc = "";
            string so = Console.ReadLine()!;
            int i=0;
            bool chang = true,ketqua = true;
            while (so != null && i < so.Length)
            {
                int chuso = Convert.ToInt32(so[i]);
                if (chuso%2!=0)
                {
                    chang = false;
                    ketqua = false;
                    break;
                }
                
                i++;
            }
            if (ketqua)
            {
                Console.WriteLine($"Ket qua so tu nhien {so} toan la so chang");
            }
            else
            {
                Console.WriteLine($"Ket qua so tu nhien {so} la so có số lẽ trong chu so");
            }
        }
    }
}