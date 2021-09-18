using System;

namespace Bai_tap_mang_v2
{
    public class manipulate
    {
        public static int rand_IntValue(int min, int max) /*tao gia tri so nguyen tu dong*/
        {
            var rd = new Random();
            int value = rd.Next(min, max);
            return value;
        }

        public static double rand_doubleValue(int min, int max) /*tao gia tri so thuc tu dong*/
        {
            var rd = new Random();
            double value = rd.Next(min, max);
            double point = rd.NextDouble();
            if (value + point > max)
            {
                value = max;
            }
            else
            {
                value += point;
            }

            return value;
        }

        public static double double_max(double[] array) /*tim gia tri lon nhat cua array*/
        {
            double max = 0;
            foreach (var element in array)
                /*max = double_max(array); */
                if (max < element)
                    max = element;
            Console.WriteLine($"max value = {max:F}");

            return max;
        }

        public static void print_DbArray(double[] array) /*In array type Double*/
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (i == 0)
                    Console.Write("[ ");
                else
                {
                    Console.Write($"{array[i]:F} ");
                }

                if (i == array.Length - 1) Console.WriteLine(" ]");
            }
        }

        public static void print_intArray(int[] array) /*in array type interger*/
        {
            for (var i = 0; i < array.Length; i++)
            {
                if (i == 0)
                    Console.Write("[ ");
                else
                    Console.Write($"{array[i]}");

                if (i == array.Length - 1) Console.WriteLine(" ]");
            }
        }

        public static void index_minvalue(int[] array, out int index, out int minValue)
        {
            minValue = 0;
            index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
                {
                    minValue = array[i];
                }
                else if (array[i] < minValue)
                {
                    minValue = array[i];
                    index = i;
                }
            }
        }

        public static void print_intMatrix(int[,] matrix) /*in cac gia tri trong matran*/
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j == 0 && i != 0)
                    {
                        Console.WriteLine("");
                    }

                    Console.Write($"{matrix[i, j]} ");
                }
            }
        }
    }
}