using System;
using System.Threading;
using Microsoft.VisualBasic;

namespace ManageStore
{
    public struct Date
    {
        public string Month;
        public string Year;
    }
    public class Stringmodifine
    {
        /*Width of column*/
        private const int limitmsp = 11,limitth=30,limitsl=10,limithd=11,limitsx=12,limitlh=10,limitcty=20;
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
        }
        
        //Printout format table
        // Header Table format
        
        public static void HeaderTable()
        {
            string msp,th,hd,nsx,ctxs,lh,sl;
            msp = FixText("Mã Sản Phẩm",limitmsp);
            th = FixText("Tên Hàng",limitth);
            sl = FixText("Số lượng", limitsl);
            hd = FixText("HSD (mm/yy)",limithd);
            nsx = FixText("NSX (mm/yy)",limitsx);
            ctxs = FixText("Cty sản xuất",limitcty);
            lh = FixText("Loại hàng",limitlh);
            string text = ($"| {msp} | {th} | {sl} | {hd} | {nsx} | {ctxs} | {lh} |");
            Console.WriteLine(text);
        }

        public static void printItem(Item a)
        {
            string msp,th,hd,nsx,ctxs,lh,sl,text;
            msp = FixText(a.Id,limitmsp);
            th = FixText(a.Name,limitth);
            sl = FixText(a.Qty.ToString(), limitsl);
            hd = FixText(DateString(a.Exp),limithd);
            nsx = FixText(DateString(a.Mfg),limitsx);
            ctxs = FixText(a.Com,limitcty);
            lh = FixText(a.Type,limitlh);
            Console.WriteLine($"| {msp} | {th} | {sl} | {hd} | {nsx} | {ctxs} | {lh} |");
        }

        public static string DateString(Date a)/*in dinh dang ngay thang cho du lieu struct Date*/
        {
            string textdate = String.Concat(String.Format(a.Month),"/",a.Year);
            return textdate;
        }
    }
}