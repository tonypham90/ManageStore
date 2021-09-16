using System;

namespace bai_tap_mang
{
    public class number_analysis
    {
        public static int MaxValue(int [] array)
        {
            int soLonNhat = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>soLonNhat)
                {
                    soLonNhat = array[i];
                }
            }
            Console.WriteLine($"gia tri lon nhat cua chuoi la {soLonNhat}");
            return soLonNhat;
        }

        public static int MinValue(int[] array)
        {
            int soNhoNhat = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < soNhoNhat)
                {
                    soNhoNhat = array[i];
                }
            }

            Console.WriteLine($"gia tri nho nhat cua chuoi la {soNhoNhat}");
            return soNhoNhat;
        }

        public static void print_array(int[] array)
        {
            for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
        }

        public static bool OddCheck (int number)
        {
            bool check = true;
            for (int i = 0; i < number; i++)
            {
                if (number % i ==0 && i >= 2)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
    }
}