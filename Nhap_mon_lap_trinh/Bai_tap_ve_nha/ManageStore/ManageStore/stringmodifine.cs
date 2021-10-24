using System;

namespace ManageStore
{
    public class Stringmodifine
    {
        /*Width of column*/
        private const int Limitmsp = 11,
            Limitth = 30,
            Limitsl = 8,
            Limithd = 10,
            Limitsx = 11,
            Limitlh = 11,
            Limitcty = 20;

        public static Date InputDate()
        {
            int month = 0, year = 0;
            Date date;
            bool checkMonth = false, checkYear = false;
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (checkMonth == false)
            {
                Console.WriteLine("Month(1~12): ");
                month = int.Parse(Console.ReadLine()!);
                /*Check value input*/
                if (month is < 13 and > 0)
                    checkMonth = true;
                else
                    Console.WriteLine("Your input may be higher 12 or lower 0, please input againt");
            }

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (checkYear == false)
            {
                Console.WriteLine("Year (yyyy or yy): ");
                year = int.Parse(Console.ReadLine()!);
                if (year > 0 && (year < 100 || year > 1900))
                {
                    if (year > 1000) year = year % 100;
                    checkYear = true;
                }
                else
                {
                    Console.WriteLine("Your input may be higher 12 or lower 0, please input againt");
                }
            }

            date.Month = month;
            date.Year = year;
            return date;
        }

        public static string FixText(string field, int limitChar)
        {
            // Gioi han so luong ky tu in;
            string texta = null;
            var limit = Math.Min(field.Length, limitChar);
            if (limit < limitChar)
            {
                for (var i = 0; i < field.Length; i++) texta += field[i].ToString();

                // ReSharper disable once PossibleNullReferenceException
                while (texta.Length < limitChar) texta += " ";
            }
            else
            {
                for (var i = 0; i < limitChar; i++) texta += field[i].ToString();
            }

            return texta;
        }

        //Printout format table
        // Header Table format
        public static void EndSeparate()
        {
            string dast = null;
            var countdast = Limitcty + Limithd + Limitlh + Limitmsp + Limitsl + Limitsx + Limitth + 3 * 8;
            for (var i = 0; i < countdast; i++) dast += "-";
            Console.WriteLine(dast);
        }

        public static void HeaderTable()
        {
            EndSeparate();
            string id, name, exp, mfg, com, type, qty;
            id = FixText("Mã Sản Phẩm", Limitmsp);
            name = FixText("Tên Hàng", Limitth);
            qty = FixText("Số lượng", Limitsl);
            exp = FixText("HSD (mm/yy)", Limithd);
            mfg = FixText("NSX (mm/yy)", Limitsx);
            com = FixText("Cty sản xuất", Limitcty);
            type = FixText("Loại hàng", Limitlh);
            var text = $"| {id} | {name} | {qty} | {exp} | {mfg} | {com} | {type} |";

            Console.WriteLine(text);
            EndSeparate();
        }

        //in gia tri cua lo hang
        public static void PrintItem(Item a)
        {
            string id, name, exp, mfg, com, type, qty;
            id = FixText(a.Id, Limitmsp);
            name = FixText(a.Name, Limitth);
            qty = FixText(a.Qty.ToString(), Limitsl);
            exp = FixText(DateString(a.Exp), Limithd);
            mfg = FixText(DateString(a.Mfg), Limitsx);
            com = FixText(a.Com, Limitcty);
            type = FixText(a.Type, Limitlh);
            Console.WriteLine($"| {id} | {name} | {qty} | {exp} | {mfg} | {com} | {type} |");
        }

        //in dinh dang ngay thang
        public static string DateString(Date a) /*in dinh dang ngay thang cho du lieu struct Date*/
        {
            var textdate = $"{a.Month:00}/{a.Year:00}";
            return textdate;
        }
    }
}