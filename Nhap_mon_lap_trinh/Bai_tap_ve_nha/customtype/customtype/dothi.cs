using System;

namespace customtype
{
    public struct TOADO
    {
        public float x;
        public float y;
    }
    public class dothi
    {
        public static TOADO nhapToaDo(string ghichu)
        {
            Console.WriteLine(ghichu);
            TOADO a;
            Console.WriteLine("Toa do x: ");
            a.x = float.Parse(Console.ReadLine()!);
            Console.WriteLine("Toa do y: ");
            a.y = float.Parse(Console.ReadLine()!);
            return a;
        }

        public static float SPACING(TOADO a, TOADO b)
        {
            float kq,x,y;
            x = a.x - b.x;
            y = a.y - b.y;
            kq = (float)Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            /*Console.WriteLine($"Khoan cach la: {kq:F} ");*/
            return kq;
        }
    }
}