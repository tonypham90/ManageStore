using System;

namespace thuchanh
{
    public class Baitapvenha
    {
        public static void KiemTraThanhPhanLe(int n)
        {
            int a;
            a = n;
            bool sole = true;
            while (a>0)
            {
                int b = a % 10;
                a = (a - b) / 10;
                if (b%2 ==0)
                {
                    sole = false;
                    break;
                }
            }

            if (sole)
            {
                Console.WriteLine($"So {n} toan bo la so le");
            }
            else
            {
                Console.WriteLine($"So {n} co chua so chan");
            }
            
        }
    }
}