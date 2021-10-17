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
                    break;
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
                    break;
                }
                else
                {
                    Console.WriteLine("Your input may be higher 12 or lower 0, please input againt");
                }
            }
            date.Month = String.Format("{0,-2}",month);
            date.Year = String.Format("{0}",year);
            return date;
        }
        public static string FixText(string a)
        {
            // Gioi han so luong ky tu in;
            string texta = null;
            int limit = Math.Min(a.Length, 10);
            if (limit < 10)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    texta += a[i].ToString();
                }

                while (texta.Length<10)
                {
                    texta += " ";
                } 
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    texta += a[i].ToString();
                }
            }

            return texta;
        }/*Chuan hoa string*/

        public static void HeaderTable()
        {
            string msp,tenhang,hd,nsx,ctxs,loaihang;
            msp = FixText("Ma SP");
            tenhang = FixText("Ten Hang");
            hd = FixText("Han SD");
            nsx = FixText("Nam SX");
            ctxs = FixText("cty SX");
            loaihang = FixText("Loai Hang");
            Console.WriteLine($"|{msp}|{tenhang}|{hd}|{nsx}|{ctxs}|{loaihang}|");
        }

        public static string PrintDate(Date a)
        {
            string textdate = String.Concat(String.Format(a.Month,-2),"/",a.Year);
            return textdate;
        }
    }
}