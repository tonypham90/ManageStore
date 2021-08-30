using System;

namespace thuchanh
{
    public class Xulysonguyen
    {
        public int Kiemtrauoc(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (n%i == 0 && i!=1)
                {
                    Console.WriteLine($"{i}");
                }
            }

            return 0;
        }

        public static int Tinhgiaithua(int n)
        {
            var a = 1;
            for (int i = 1; i < n; i++)
            {
                a *= i;
            }
            return a;
        }

        public bool Songuyento(int n)
        {
            bool check = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }

        public static int Hoanvi (ref int a,ref int b)
        {
            var t = b;
            b = a;
            a = t;
            return 0;
        }
    }
}