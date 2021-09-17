using System;
using Microsoft.VisualBasic;

namespace Bai_tap_mang_v2
{
    public class manipulate
    {
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
                    string strElement = array[i].ToString("F");
                    Console.Write($"{strElement} ");
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

        public static void index_minvalue(int[] array,out int index,out int minValue)
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
    }
}