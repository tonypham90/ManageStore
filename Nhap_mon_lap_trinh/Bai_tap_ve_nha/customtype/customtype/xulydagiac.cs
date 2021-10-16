using System;

namespace customtype
{
    public struct DAGIAC
    {
        public TOADO[] DSDinh;
    }
    public class xulydagiac
    {
        
            public static DAGIAC NhapDaGiac(String ghichu)
            {
                DAGIAC kq;
                Console.WriteLine(ghichu);
                Console.WriteLine("So dinh cua da giac: ");
                int countpoint = int.Parse(Console.ReadLine()!);
                kq.DSDinh = new TOADO[countpoint];
                for (int i = 0; i < kq.DSDinh.Length; i++)
                {
                    kq.DSDinh[i] = dothi.nhapToaDo($"Nhap toa do diem thu {i + 1}");
                }

                return kq;
            }

            public static float TinhChuVi(DAGIAC d)
            {
                float chuVi = 0;
                for (int i = 0; i < d.DSDinh.Length-1; i++)
                {
                    chuVi += dothi.SPACING(d.DSDinh[i], d.DSDinh[i + 1]);
                }

                chuVi += dothi.SPACING(d.DSDinh[0], d.DSDinh[d.DSDinh.Length - 1]);
                return chuVi;
            }
    }
}