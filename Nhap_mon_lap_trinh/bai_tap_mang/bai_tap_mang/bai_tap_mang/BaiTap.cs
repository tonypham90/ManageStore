using System;

namespace bai_tap_mang
{
    public class BaiTap
    {
        // ReSharper disable once UnusedMember.Global
        public static int bai122(int[] array)
        {
            int max = number_analysis.MaxValue(array);
            return max;
        }

        public static int bai123(int[] array)
        {
            int minNumber = number_analysis.MinValue(array);
            int index = Array.IndexOf(array, minNumber);
            Console.WriteLine($"vi tri cua gia tri nho nhat cua chuoi la {index}");
            return minNumber;
        }

        public static int[] bai124(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = 0;
                        t = array[i];
                        array[j] = array[i];
                        array[i] = t;
                    }
                }
            }
            return array;
        }

        // ReSharper disable once InconsistentNaming
        public static void bai140(int[] array)
        {
            Console.WriteLine("\nTim gia tri duong nho nhat cua mang 1 chieu neu mang khong co gia tri dung se tra ve -1");
            int min = -1 ;
            int countCase = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2 ==0)
                {
                    countCase += 1;
                }
                if (array[i] > 0)
                {
                    if (countCase == 1 || array[i]<min)
                    {
                        min = array[i];
                    }
                }
            }
            Console.WriteLine($"Gia tri nho nhat la {min}");
        }

        public static void bai157(int[] array)
        {
            Console.WriteLine("Tim khoan gai tri chua tat ca gia tri cua mang");
            int minvalue = number_analysis.MinValue(array);
            int maxvalue = number_analysis.MaxValue(array);
            Console.WriteLine($"Khoan gia tri [{minvalue},{maxvalue}]");
        }

        public static void bai173(int[] array)
        {
            Console.WriteLine("tim chu so it xuat hien nhat");
            int number=0, countnumber=0,MinCount = 0,TargetNumber =0,element;
            for (int i = 1; i < 10; i++)
            {
                number = i;
                countnumber = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    element = array[j];
                    while (element>0)
                    {
                        if (number == element%10)
                        {
                            countnumber += 1;
                        }
                        element = element / 10;
                    }
                }
                if ((MinCount ==0 && countnumber>0) || (countnumber < MinCount) &&(countnumber>0))
                {
                    TargetNumber = i;
                    MinCount = countnumber;
                }
            }
            Console.WriteLine($"Chu so it suat hien nhat ngoai tru so 0 la {TargetNumber} voi so lan suat hien {MinCount}");
        }
        public static void baitap230(int[] array)
        {
            Console.WriteLine("tim so lan xuat hien cac phan tu");
            int number = 0, countnumber = 0;
            for (int i = 1; i < array.Length; i++)
            {
                number = array[i];

            }
        }
    }
}