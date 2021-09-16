using System;
using System.ComponentModel.Design;

namespace Bai_tap_mang_v2
{
    public class array_basic
    { 
        // nhom class tao mang 1 chieu
        public static double[] double_array( bool random )
        {
            Console.Write($"Nhap so phan tu trong array: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write($"Nhap gia tri nho nhat: ");
            int min = int.Parse(Console.ReadLine()!);
            Console.Write($"Nhap gia tri lon nhat:  ");
            int max = int.Parse(Console.ReadLine()!);
            double[] newarray = new double[n];
            double element;
            for (int i = 0; i < n; i++)
            {
                
                Random rd = new Random();
                element = rd.Next(min, max);
                double point = rd.NextDouble();
                if (element + point > max)
                    {
                        element = max;
                    }
                    else
                    {
                        element += point;
                    }
                
                newarray[i] = element;
            } 
            return newarray;
        }
        public static int[] int_array(bool rand)
        {
            Console.Write($"Nhap so phan tu trong array: ");
            int n = int.Parse(Console.ReadLine()!);
            Console.Write($"Nhap gia tri nho nhat: ");
            int min = int.Parse(Console.ReadLine()!);
            Console.Write($"Nhap gia tri lon nhat:  ");
            int max = int.Parse(Console.ReadLine()!);
            int[] newarray = new int[n];
            Random rd = new Random();
            int element;
            for (int i = 0; i < n; i++)
            {
                if (rand)
                {
                    element = rd.Next(min, max);
                }
                else
                {
                    Console.WriteLine($"Nhap gia tri thu {i}: ");
                    element = int.Parse(Console.ReadLine()!);
                }
                
                newarray[i] = element;
            }
            return newarray;
        }
    }
}