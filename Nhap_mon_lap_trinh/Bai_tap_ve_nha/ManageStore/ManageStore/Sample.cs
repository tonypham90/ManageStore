using System;
using System.Linq;

namespace ManageStore
{
    public class Sample
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static readonly Random ran = new();


        private protected static string[] Food = { "Chuối".ToUpper(), "Sữa", "Trứng", "Cà phê", "Mì gói" };

        private protected static string[] Electric =
            { "Điện Thoại Di Động", "Labtop", "Tủ lạnh", "Tivi", "Điều hòa nhiệt độ" };

        private protected static string[] Equitment = { "Chổi", "chén", "máy hút bụi", "cây lau nhà", "bùi nhùi" };

        private protected static string[] Brand = { "Daklak", "Intel", "Sony", "X-Space", "Takana", "Viet-Gab" };

        public static string[] Type = { "THUCPHAM", "DIENTU", "GIADUNG" };


        public static string RanId(Item[] items)
        {
            string newid = null;
            bool duplicateCheck = true;
            while (duplicateCheck)
            {
                newid = new string(Enumerable.Repeat(Chars, 4).Select(s => s[ran.Next(s.Length)]).ToArray());
                duplicateCheck = Function.Duplicatecheckid(newid, items);
            }

            return newid;
        }

        public static string RandItemDetail(string[] detail)
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
            value.Year = ran.Next(min.Year, min.Year + 6);
            if (value.Year > min.Year)
                value.Month = ran.Next(1, 13);
            else
                value.Month = ran.Next(min.Month, 13);
            return value;
        }

        public static Item RandItem(string note, Store warehouse)
        {
            var id = new string[warehouse.ItemsList.Length];
            Item packaged;
            var indexofelement = 0;
            foreach (var item in warehouse.ItemsList)
            {
                id[indexofelement] = item.Id;
                indexofelement += 1;
            }
            
            Console.WriteLine(note);
            packaged.Id = RanId(warehouse.ItemsList);
            packaged.Type = RandItemDetail(Type);
            packaged.Name = RandName(packaged.Type);
            packaged.Qty = ran.Next(1, 100);
            packaged.Mfg.Month = ran.Next(1,13);
            packaged.Mfg.Year = ran.Next(19, 21);
            packaged.Exp = RandDate(packaged.Mfg);
            packaged.Com = RandItemDetail(Brand);

            return packaged;
        }
    }
}