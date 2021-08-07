using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Baitap99
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Sắp xếp 3 số bất kỳ từ nhỏ đến lớn");
            int i = 0;
            int[] list = { };
            string ketqua="";
            while (i<3)
            {
                new number();
                i++;
            }
            var ketqua = from list in list  
            Console.WriteLine(list);
            for (i = 0; i < 3; i++)
            {
                ketqua = ketqua + " " + list[i];
            }
            Console.WriteLine(ketqua);
        }
    }
}