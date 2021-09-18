using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Net.Http.Headers;

namespace bai_tap_mang
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bai tap mang 1 chieu");
            Console.Write("tao mang tu dong voi gia tri nho nhat= ");
            int minVal = int.Parse(Console.ReadLine()!);
            Console.Write("tao mang tu dong voi gia tri lon nhat= ");
            int maxVal = int.Parse(Console.ReadLine()!);
            int [] man = array_analysis.tao_array_int(minVal,maxVal);
            BaiTap.bai140(man);
            BaiTap.bai173(man);
        }
        
    }
}