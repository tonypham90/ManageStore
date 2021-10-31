using System;

namespace ManageStore
{
    public class Stringmodifine
    {
        /*Width of column gioi han so space in trong bang*/
        private const int Limitmsp = 11,
            Limitth = 30,
            Limitsl = 8,
            Limithd = 10,
            Limitsx = 11,
            Limitlh = 11,
            Limitcty = 20;
        
        public static Date InputDate()
        {
            int year = 0;
            Date date;
            bool checkYear = false;
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            
            // while (checkMonth == false)
            // {
            //     Console.WriteLine("Month(1~12): ");
            //     month = int.Parse(Console.ReadLine()!);
            //     /*Check value input*/
            //     if (month is < 13 and > 0)
            //         checkMonth = true;
            //     else
            //         Console.WriteLine("Your input may be higher 12 or lower 0, please input againt");
            // }
            int month = Inputnumber("Tháng (1~12): ", 1, 12);

            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
            while (checkYear == false)
            {
                Console.Write("năm (yyyy hoặc yy): ");
                year = int.Parse(Console.ReadLine()!);
                if (year > 0 && (year < 100 || year > 1900))
                {
                    if (year > 1000) year = year % 100;
                    checkYear = true;
                }
                else
                {
                    Console.WriteLine("Vui lòng nhập năm theo định dạng yyyy hoặc yy(ví dụn 2021 hoặc 21)");
                }
            }

            date.Month = month;
            date.Year = year;
            return date;
        }
//cố định định dạng bảng khi in kết quả ra trong bảng
        public static string FixFormatTableText(string field, int limitChar)
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
//cố định giá trị string được nhập vào
        public static string Inputlimittext(string ghichu, int limit)
        {
            Console.Write($"{ghichu}({limit} ký tự");
            string input = Console.ReadLine()!.ToUpper();
            while (input.Length != limit)
            {
                Console.WriteLine($"Vui lòng nhập {limit} ký tự");
                Console.Write("Giá trị: ");
                input = Console.ReadLine()!.ToUpper();
            }

            return input;
        }

        //Printout format table
        // Header Table format
        public static void EndSeparate()
        {
            string dast = null;
            var countdast = Limitcty + Limithd + Limitlh + Limitmsp + Limitsl + Limitsx + Limitth + 3 * 8-2;
            for (var i = 0; i < countdast; i++) dast += "~";
            Console.WriteLine(dast);
        }

        public static void HeaderTable()
        {
            EndSeparate();
            string id, name, exp, mfg, com, type, qty;
            id = FixFormatTableText("Mã Sản Phẩm", Limitmsp);
            name = FixFormatTableText("Tên Hàng", Limitth);
            qty = FixFormatTableText("Số lượng", Limitsl);
            exp = FixFormatTableText("HSD (mm/yy)", Limithd);
            mfg = FixFormatTableText("NSX (mm/yy)", Limitsx);
            com = FixFormatTableText("Cty sản xuất", Limitcty);
            type = FixFormatTableText("Loại hàng", Limitlh);
            var text = $"| {id} | {name} | {qty} | {exp} | {mfg} | {com} | {type} |";

            Console.WriteLine(text);
            EndSeparate();
        }

        //in gia tri cua lo hang
        public static void PrintItem(Item a)
        {
            string id, name, exp, mfg, com, type, qty;
            id = FixFormatTableText(a.Id, Limitmsp);
            name = FixFormatTableText(a.Name, Limitth);
            qty = FixFormatTableText(a.Qty.ToString(), Limitsl);
            exp = FixFormatTableText(DateString(a.Exp), Limithd);
            mfg = FixFormatTableText(DateString(a.Mfg), Limitsx);
            com = FixFormatTableText(a.Com, Limitcty);
            type = FixFormatTableText(a.Type, Limitlh);
            Console.WriteLine($"| {id} | {name} | {qty} | {exp} | {mfg} | {com} | {type} |");
        }

        //in dinh dang ngay thang
        public static string DateString(Date a) /*in dinh dang ngay thang cho du lieu struct Date*/
        {
            var textdate = $"{a.Month:00}/{a.Year:00}";
            return textdate;
        }

        public static int Inputnumber(string note,int min,int max)
        {
            Console.Write(note);
            string input;
            input = Console.ReadLine();
            bool check = int.TryParse(input,out var value);
            while (check == false||min>value||value>max)
            {
                Console.Write($"Vui lòng nhập đúng giá trị trong khoản {min}~{max}");
                input = Console.ReadLine();
                check = int.TryParse(input,out value);
            }

            return value;

        } //Gioi han nhap gia tri

        public static bool Inputyn(string note)
        {
            Console.Write(note);
            string input = Console.ReadLine()?.ToLower();
            bool check,choise;
            switch (input)
            {
                case "y":
                    check = true;
                    break;
                case "n":
                    check = true;
                    break;
                default:
                    check = false;
                    break;
            }
            while (check == false)
            {
                Console.Write("Vui lòng nhập đúng giá trị y:Đồng ý, n: từ chối: ");
                input = Console.ReadLine()?.ToLower();
                switch (input)
                {
                    case "y":
                        check = true;
                        break;
                    case "n":
                        check = true;
                        break;
                }
            }

            switch (input)
            {
                case "y":
                    choise = true;
                    break;
                default:
                    choise = false;
                    break;
                    
            }

            return choise;
        }
        //Nhap gia tri han su dung theo so thang
        public static Date Inputexp(string note, Date mfg)
        {
            Console.WriteLine(note);
            Date exp;
            int expmonth = Inputnumber("Giá trị từ 1~100: ", 1, 100);
            int totalmonth = (expmonth + mfg.Month);
            exp.Month = totalmonth % 12;
            exp.Year = totalmonth / 12+mfg.Year;
            return exp;
        }

        public static void PrintStringArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i+1}. {array[i]}");
            }
        }

    }
}