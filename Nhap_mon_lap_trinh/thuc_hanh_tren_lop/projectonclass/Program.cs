using System;

namespace projectonclass
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            // Console.Write("nhap so luong phan tu: ");
            // int n = int.Parse(Console.ReadLine()!);
            // int[] b; /*tao bien array*/
            // b = new int[n]; /*xac dinh n so luong phan tu cua array */
            // for (int i = 0; i < n; i++)
            // {
            //     Console.Write($"nhap gia tri A[{i}]= ");
            //     b[i] = int.Parse(Console.ReadLine()!);
            // }
            // for (int i = 0; i < b.Length; i++)
            // {
            //     Console.Write($"{b[i]}");
            // }
            // Console.WriteLine($"{b} ");
            // int t = 0;
            // for (int i = 0; i < b.Length; i++)
            // {
            //     t += b[i];
            // }
            // Console.WriteLine($"tong gia tri la: {t}");
            int[] a = tinh_array.Nhapmang("nhap mang");
            int maxvalue = tinh_array.max_value(a);
            Console.WriteLine($"gia tri lon nhat cua mang A la: {maxvalue}");
        }
    }
}