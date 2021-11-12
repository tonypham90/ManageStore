using System;

namespace ManageStore
{
    public class stringmodifine
    {
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
            int month = Inputnumber("Tháng", 1, 12);

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

//cố định giá trị string được nhập vào
        public static string Inputlimittext(string ghichu, int limit)
        {
            Print.MidSeparate();
            Console.Write($"{ghichu} ({limit} ký tự): ");
            string input = Console.ReadLine()!.ToUpper();
            while (input.Length != limit)
            {
                Console.WriteLine($"Giá trị nhiều hơn hoặc ít hơn {limit} ký tự");
                Console.WriteLine($"Vui lòng nhập {limit} ký tự");
                Console.Write("Giá trị: ");
                input = Console.ReadLine()!.ToUpper();
            }

            return input;
        }


        //in dinh dang ngay thang


        public static int Inputnumber(string functionName, int min, int max)
        {
            Console.Write($"{functionName} ({min}~{max}): ");
            string input;
            input = Console.ReadLine();
            bool check = int.TryParse(input, out int value);
            while (check == false || min > value || value > max)
            {
                Console.Write($"Vui lòng nhập đúng giá trị trong khoản {min}~{max}: ");
                input = Console.ReadLine();
                check = int.TryParse(input, out value);
            }

            return value;
        } //Gioi han nhap gia tri

        public static bool ChooseYesNo(string note)
        {
            Console.Write($"{note} (y/n): ");
            string input = Console.ReadLine()!.ToLower();
            bool check, choise;
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
                Console.Write("Vui lòng nhập đúng giá trị y: Đồng ý, n: Từ chối: ");
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
        public static Date Inputexp(Date mfg)
        {
            Date exp;
            int expmonth = Inputnumber("Số tháng sử dụng", 1, 100);
            int totalmonth = expmonth + mfg.Month;
            exp.Month = totalmonth % 12;
            exp.Year = totalmonth / 12 + mfg.Year;
            if (exp.Month == 0) exp.Month = 1;
            return exp;
        }

        public static void PrintStringArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++) Console.WriteLine($"{i + 1}. {array[i]}");
        }
    }
}