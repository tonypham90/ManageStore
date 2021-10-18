using System;

namespace ManageStore
{
    public struct Date
    {
        public string Month;
        public string Year;
    }
    public class Stringmodifine
    {
        public static Date Inputdate()
        {
            int month = 0, year = 0;
            Date date;
            bool checkmonth = false, checkyear = false;
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (checkmonth == false)
            { 
                Console.WriteLine("Month(1~12): ");
                month = int.Parse(Console.ReadLine()!);
                /*Check value input*/
                if (month < 13 && month>0)
                {
                    checkmonth = true;
                }
                else
                {
                    Console.WriteLine("Your input may be higher 12 or lower 0, please input againt");
                }
            }
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (checkyear == false)
            { 
                Console.WriteLine("Year (yyyy or yy): ");
                year = int.Parse(Console.ReadLine()!);
                if (year>0 && (year<100 || year > 1900))
                {
                    if (year>1000)
                    {
                        year = year % 100;
                    }
                    checkyear = true;
                }
                else
                {
                    Console.WriteLine("Your input may be higher 12 or lower 0, please input againt");
                }
            }
            date.Month = $"{month}";
            date.Year = String.Format("{0}",year);
            return date;
        }
        public static string FixText(string field,int limitchar)
        {
            // Gioi han so luong ky tu in;
            string texta = null;
            int limit = Math.Min(field.Length, limitchar);
            if (limit < limitchar)
            {
                for (int i = 0; i < field.Length; i++)
                {
                    texta += field[i].ToString();
                }

                while (texta.Length<limitchar)
                {
                    texta += " ";
                } 
            }
            else
            {
                for (int i = 0; i < limitchar; i++)
                {
                    texta += field[i].ToString();
                }
            }

            return texta;
        }/*Chuan hoa string*/

        public static void HeaderTable()
        {
            string msp,tenhang,hd,nsx,ctxs,loaihang,sl;
            msp = FixText("Ma SP",10);
            tenhang = FixText("Ten Hang",30);
            sl = FixText("Số lượng", 10);
            hd = FixText("Han SD",10);
            nsx = FixText("Nam SX",10);
            ctxs = FixText("cty SX",20);
            loaihang = FixText("Loai Hang",10);
            Console.WriteLine($"|{msp}|{tenhang}|{hd}|{nsx}|{ctxs}|{loaihang}|");
        }

        public static string PrintDate(Date a)/*in dinh dang ngay thang cho du lieu struct Date*/
        {
            string textdate = String.Concat(String.Format(a.Month),"/",a.Year);
            return textdate;
        }
    }
}