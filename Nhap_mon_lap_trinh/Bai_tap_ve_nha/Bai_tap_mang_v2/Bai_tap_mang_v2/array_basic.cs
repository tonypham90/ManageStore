using System;

namespace Bai_tap_mang_v2
{
    public class array_basic
    {
        public static void create_array()
        {
            Console.Write($"Nhap so phan tu trong array: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write($"Nhap gia tri nho nhat: ");
            int min = int.Parse(Console.ReadLine()!);
            Console.Write($"Nhap gia tri lon nhat:  ");
            int max = int.Parse(Console.ReadLine()!);
            double[] newarray = new double[n];
            for (int i = 0; i < newarray.Length; i++)
            {
                Random rd = new Random();
                double randnum = rd.Next(min,max);
                double point = rd.NextDouble();
                if (randnum + point > max)
                {
                    randnum = max;
                }
                else
                {
                    randnum += point;
                }
            }
            // return newarray;
        }
    }
}