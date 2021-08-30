using System;

namespace projectonclass
{
    public class tinh_array
    {
        public static int[] Nhapmang(string ghichu)
        {
            int[] a;
            Console.WriteLine(ghichu);
            Console.Write("nhap so luong phan tu mang A: ");
            int n = int.Parse(Console.ReadLine()!);
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Random rd = new Random();
                int ranNum = rd.Next(0, 100);
                a[i] = ranNum;
            }
            return a;
        }

        public static int max_value(int[] a)
        {
            int maxNum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > maxNum)
                {
                    maxNum = a[i];
                }
            }

            return maxNum;
        }
    }
}
