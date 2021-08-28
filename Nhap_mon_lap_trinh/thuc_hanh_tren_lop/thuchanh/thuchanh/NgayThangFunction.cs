using System;
using System.Globalization;

namespace thuchanh
{
    public class NgayThangFunction
    {
        public static void Tomorrowdate(int day,int month,int year,out int newday,out int newmonth, out int newyear)
        {
            newday = 0;
            newmonth = 0;
            newyear = 0;
            if (year%4==0)
            {
                if (month==2)
                {
                    if (day==28)
                    {
                        newday = 1;
                        newmonth = 3;
                        newyear = year;
                    }
                    else if (day>28)
                    {
                        Console.WriteLine($"So ngay nhap vuotqua ngay cua 1 thang, thang 2 cua nam {year} chi co 28 ngay");
                    }
                    else
                    {
                        newday = day + 1;
                        newmonth = month;
                        newyear = year;
                    }
                }
            }

            else if (month == 12 && day == 31)
            {
                newday = 1;
                newmonth = 1;
                newyear = year + 1;
            }
            else
            {
                if (month == 4||month == 6 || month ==9 ||month ==11)
                {
                    if (day ==30)
                    {
                        newday = 1;
                        newmonth = month + 1;
                        newyear = year;
                    }

                    if (day >30)
                    {
                        Console.WriteLine("So ngay vuot qua so ngay cua thang vui long kiem tra lai");
                    }
                    else
                    {
                        newday = day + 1;
                        newmonth = month;
                        newyear = year;
                    }
                }
                else if (day>31)
                {
                    Console.WriteLine("so ngay nhap vuot qua ngay cua thang");
                }
                else if (day == 31)
                {
                    newday = 1;
                    newmonth = month + 1;
                    newyear = year;
                }
                else
                {
                    newday = day + 1;
                    newmonth = month;
                    newyear = year;
                }
            }
        }
    }
}