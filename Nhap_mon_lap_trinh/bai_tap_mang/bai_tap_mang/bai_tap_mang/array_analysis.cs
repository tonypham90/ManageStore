using System;
using System.Reflection.Metadata.Ecma335;

namespace bai_tap_mang
{
    public class array_analysis
    {
        public static int[] tao_array_int (int minVal,int maxVal)
        {
            Console.WriteLine("tao mang int random, nhap so element trong mang: ");
            int n = int.Parse(Console.ReadLine()!);
            int[] a;
            a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Random rd = new Random();
                int rand = rd.Next(minVal, maxVal);
                a[i] = rand;
            }
            number_analysis.print_array(a);
            return a;
        } 
        
    }
}