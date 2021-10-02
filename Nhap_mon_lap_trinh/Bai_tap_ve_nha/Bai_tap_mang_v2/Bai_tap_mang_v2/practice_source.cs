using System;
using System.Threading;

namespace Bai_tap_mang_v2
{
    public class practice_source
    {
        public static void bai122()
        {
            Console.WriteLine("Tim gia tri so thuc lon nhat cua mang");
            var array = array_basic.double_array(true);
            manipulate.print_DbArray(array); /*in chuoi*/
            manipulate.double_max(array);
        }

        public static void bai123()
        {
            Console.WriteLine("Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên");/*De bai*/
            array_basic.int_array(true);
        }

        public static void bai311()
        {
            Console.WriteLine("Matran so nguyen");
            array_basic.IntMatrix(true);
        }

        public static void bai312()
        {
            Console.WriteLine("Ma tran so thuc");
            array_basic.double_array(true);
        }

        public static void bai315()
        {
            Console.WriteLine("Gia tri lon nhat cua ma tran so thuc");
            bool rand = manipulate.checkRand();
            double[,] matrix = array_basic.doubleMatrix(rand);
            double maxValue = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == 0 && j ==0 )
                    {
                        maxValue = matrix[i, j];
                    }
                    else if (maxValue<matrix[i,j])
                    {
                        maxValue = matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri lon nhat cua mang {maxValue:F}");
        }

        public static void bai364()
        {
            Console.WriteLine(" Kiem tra ma tran A co la con Ma Tran B");
            bool rand = manipulate.checkRand();
            int[,] matrixA = array_basic.IntMatrix(rand);
            int[,] matrixB = array_basic.IntMatrix(rand);
            /*Kiem tra kich thuoc ma tran  */
            bool Checksub = false;
            int[,] subMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            /*location value*/
            /*The value check at 1st value*/
            int value = matrixA[0, 0];
            
            int[,] subcheck = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            for (int i = 0; i < matrixB.GetLength(0); i++)
            {
                for (int j = 0; j < matrixB.GetLength(1); j++)
                {
                    if (value == matrixB[i,j])
                    {
                        int lamdarow = matrixB.GetLength(0)-1-i;
                        int lamdacolumn = matrixA.GetLength(1)-1-j;
                        if (lamdarow)
                        {
                            
                        }
                    }
                }
            }
            {
                
            }

        }

    }
}