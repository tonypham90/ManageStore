using System;
using System.Collections.Generic;

namespace ManageStore
{
    public class Function
    {
        public static void PrintTable(Store table)
        {
            Stringmodifine.HeaderTable();
            foreach (Item item in table.ItemsList)
            {
                Stringmodifine.PrintItem(item);
            }
            Stringmodifine.EndSeparate();
        }
        
        // Nhap gia tri vao
        public static Item InputItem(string ghichu,Store warehouse,bool auto)
        {
            Item item = new Item();
            Console.WriteLine(ghichu);
            if (auto)
            {
                item = Sample.RandItem("Tạo hàng tự động",warehouse.Id, warehouse.Label);

            }
            else
            {
                Console.Write("Mã Sản Phẩm: ");
                item.Id = Console.ReadLine()!.ToUpper();
                Console.Write("Tên sản phẩm: ");
                item.Name = Console.ReadLine()!.ToUpper();
                Console.Write("Tên sản phẩm: ");
                item.Qty = int.Parse(Console.ReadLine()!);
                Console.Write("Hạn Dùng: ");
                item.Exp = Stringmodifine.InputDate();
                Console.Write("Ngày sản xuất: ");
                item.Mfg = Stringmodifine.InputDate();
                Console.Write("Công ty sản xuất");
                item.Com = Console.ReadLine()!;
                Console.Write("Tên sản phẩm: ");
                item.Type = Console.ReadLine()!;
            }
            
            return item;
        }
    }
}