using System;

namespace customtype
{
    public class xulysonguyen
    {
        public static int NhapSoNguyen(string ghichu)
        {
            Console.WriteLine(ghichu);
            int so = int.Parse(Console.ReadLine()!);
            return so;
        }
    }
}