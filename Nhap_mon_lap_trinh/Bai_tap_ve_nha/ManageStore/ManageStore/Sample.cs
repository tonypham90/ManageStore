using System;

namespace ManageStore
{
    public class Sample
    {
        private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private static readonly Random Ran = new();


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
                for (int i = 0; i < 4; i++)
                {
                    int index = Ran.Next(0, Chars.Length);
                    newid += Chars[index];
                }
                duplicateCheck = Check.Duplicatecheckid(newid, items);
            }

            return newid;
        }

        public static string RandItemDetail(string[] detail)
        {
            int id = Ran.Next(0, detail.Length);
            string detailValue = detail[id].ToUpper();
            // Console.WriteLine(detailValue);
            return detailValue;
        }

        public static string RandName(string lable)
        {
            string itemName;
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

            itemName = item[Ran.Next(0, item.Length)].ToUpper();
            return itemName;
        }

        public static Date RandDate(Date min)
        {
            Date value;
            value.Year = Ran.Next(min.Year, min.Year + 6);
            if (value.Year > min.Year)
                value.Month = Ran.Next(1, 13);
            else
                value.Month = Ran.Next(min.Month, 13);
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
            
            // Console.WriteLine(note);
            packaged.Id = RanId(warehouse.ItemsList);
            // Console.WriteLine($"Mã hàng: {packaged.Id}");
            packaged.Type = RandItemDetail(Type);
            // Console.WriteLine($"Loại Hàng:  {packaged.Type}");
            packaged.Name = RandName(packaged.Type);
            packaged.Qty = Ran.Next(1, 100);
            packaged.Mfg.Month = Ran.Next(1,13);
            packaged.Mfg.Year = Ran.Next(19, 21);
            packaged.Exp = RandDate(packaged.Mfg);
            packaged.Com = RandItemDetail(Brand);
            Console.WriteLine($"{note}\nMã Hàng: {packaged.Id}, Tên Hàng: {packaged.Name}, Số lượng: {packaged.Qty}, Ngày sản xuất:{Print.DateString(packaged.Mfg)}, Hạn Dùng:{Print.DateString(packaged.Exp)} , Công ty: {packaged.Com}, Loại Hàng {packaged.Type}");

            return packaged;
        }
    }
}