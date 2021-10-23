using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using System.Linq;
namespace ManageStore
{
    public class Sample
    {
        private static Random ran = new Random();
        const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        

        private protected static string[] Food = new string[] 
            { "Chuối".ToUpper(), "Sữa", "Trứng", "Cà phê", "Mì gói"};
        private protected static string[] Electric = new string[]
            { "Điện Thoại Di Động", "Labtop", "Tủ lạnh", "Tivi", "Điều hòa nhiệt độ" };
        private protected static string[] Equitment = new string[] 
            { "Chổi", "chén", "máy hút bụi", "cây lau nhà", "bùi nhùi" };
        private protected static string[] Brand = new string[] 
            { "Daklak", "Intel", "Sony", "X-Space", "Takana","Viet-Gab" };
        private protected static string[] Type = new string[] 
            { "THUCPHAM", "DIENTU", "GIADUNG" };
        
        
        
        /*public static string RanId(List<Item> items)
        {
            string newid;
            bool duplicatecheck = true;
            while (true)
            {
                
            }
            return new string(Enumerable.Repeat(Chars, 4).Select(s => s[ran.Next(s.Length)]).ToArray());
        }*/

        public static string RandItemDetail(string[]detail)
        {
            int id = ran.Next(0, detail.Length);
            string detailValue = detail[id].ToUpper();
            Console.WriteLine(detailValue);
            return detailValue;
        }
        
        public static string RandName(string lable)
        {
            string ItemName;
            string[] item;
            switch (lable)
            {
                case "THUCPHAM":
                    item = Food;
                    break;
                case "DIENTU":
                    item = Electric;
                    break;
                default:
                    item = Equitment;
                    break;
            }
            ItemName = item[ran.Next(0, item.Length)].ToUpper();
            Console.WriteLine(ItemName);
            return ItemName;
        }

        public static Date RandDate(Date min)
        {
            Date value;
            value.Year = ran.Next(min.Year, min.Year+6);
            if (value.Year>min.Year)
            {
                value.Month = ran.Next(1, 13);
            }
            else
            { 
                value.Month = ran.Next(min.Month,13);
            }
            return value;
        }

        public static Item RandItem(string note,List<Item> items,List<string>lable)
        {
            Item packaged;
            Console.WriteLine(note);
            packaged.Id = RanId(items);
            packaged.Type = RandItemDetail(Type);
            packaged.Name = RandName(packaged.Type);
            packaged.Qty = ran.Next(1, 100);
            packaged.Mfg.Month = ran.Next(13);
            packaged.Mfg.Year = ran.Next(19,21);
            packaged.Exp = RandDate(packaged.Mfg);
            packaged.Com = RandItemDetail(Brand);

            return packaged;
        }
    }
}