using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_tap_mang_v2
{
    public class array_basic
    {
        // nhom class tao mang 1 chieu
        public static double[] double_array(bool random) /*tao chuoi 1 chieu so thuc*/
        {
            Console.Write("Nhap so phan tu trong array: ");
            var n = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap gia tri nho nhat: ");
            var min = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap gia tri lon nhat:  ");
            var max = int.Parse(Console.ReadLine()!);
            var newarray = new double[n];
            double element;
            for (var i = 0; i < n; i++)
            {
                if (random)
                {
                    var rd = new Random();
                    element = rd.Next(min, max);
                    var point = rd.NextDouble();
                    if (element + point > max)
                        element = max;
                    else
                        element += point;
                }
                else
                {
                    Console.Write($"Nhap gia tri so thuc thu {i}: ");
                    element = double.Parse(Console.ReadLine()!);
                }

                newarray[i] = element;
            }

            return newarray;
        }

        public static int[] int_array(bool rand) /*Tao mang 1 chieu*/
        {
            Console.Write("Nhap so phan tu trong array: ");
            var n = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap gia tri nho nhat: ");
            var min = int.Parse(Console.ReadLine()!);
            Console.Write("Nhap gia tri lon nhat:  ");
            var max = int.Parse(Console.ReadLine()!);
            var newarray = new int[n];
            var rd = new Random();
            int element;
            for (var i = 0; i < n; i++)
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

        public static int[,] IntMatrix(bool rand)
        {
            Random rd = new Random();
            int minValue = 0, maxValue=0,value=0;
            Console.Write("Tao ma tran voi so cot: ");
            int column = int.Parse(Console.ReadLine()!);
            Console.Write("Tao ma tran voi so dong: ");
            int row = int.Parse(Console.ReadLine()!);
            int[,] matrixA = new int[row, column];
            if (rand)
            {
                Console.Write("Nhap gia tri nho nhat: ");
                minValue = int.Parse(Console.ReadLine()!);
                Console.Write("Nhap gia tri lon nhat:  ");
                maxValue = int.Parse(Console.ReadLine()!);
            }
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    if (rand)
                    {
                        value = manipulate.rand_IntValue(minValue, maxValue);
                    }
                    else
                    {
                        Console.Write($"Nhap gia tri tai vi tri [{i},{j}]: ");
                        value = int.Parse(Console.ReadLine()!);
                    }
                    matrixA[i,j] = value;
                }
            }
            manipulate.print_intMatrix(matrixA);

            return matrixA;
        }
        public static double[,] doubleMatrix(bool rand)
        {
            Random rd = new Random();
            int minValue = 0, maxValue=0;
            double value;
            Console.Write("Tao ma tran voi so cot: ");
            int column = int.Parse(Console.ReadLine()!);
            Console.Write("Tao ma tran voi so dong: ");
            int row = int.Parse(Console.ReadLine()!);
            double[,] matrixA = new double[row, column];
            if (rand)
            {
                Console.Write("Nhap gia tri nho nhat: ");
                minValue = int.Parse(Console.ReadLine()!);
                Console.Write("Nhap gia tri lon nhat:  ");
                maxValue = int.Parse(Console.ReadLine()!);
            }
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    if (rand)
                    {
                        value = manipulate.rand_doubleValue(minValue, maxValue);
                       
                    }
                    else
                    {
                        Console.Write($"Nhap gia tri tai vi tri [{i},{j}]: ");
                        value = double.Parse(Console.ReadLine()!);
                    }
                    matrixA[i,j] = value;
                }
            }
            manipulate.print_doubleMatrix(matrixA);

            return matrixA;
        }
    }
}
