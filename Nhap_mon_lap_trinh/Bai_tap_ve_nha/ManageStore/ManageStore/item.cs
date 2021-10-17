using System;

namespace ManageStore
{
    public struct Item
    {
        public string Id;/*Mã sản phẩm*/
        public string Name;/*Tên sản phẩm*/
        public Date Exp;/*Hạn sử dụng*/
        public Date Mfg;/*Năm sản xuất*/
        public string Com; /*Cty San xuat*/
        public string Type;/*Loai Hang*/

    }
    public class Itemmodifine
    {
        public static Item InputiItemtem(string Ghichu)
        {
            Console.WriteLine(Ghichu);
            Item item = new Item();
            Console.WriteLine("Mã Sản Phẩm: ");
            item.Id = Console.ReadLine()!;
            Console.WriteLine("Tên sản phẩm: ");
            item.Name = Console.ReadLine()!;
            Console.WriteLine("Hạn Dùng (mm/yy): ");
            item.Exp =Stringmodifine.Inputdate();
            item.Mfg = Stringmodifine.Inputdate();
            item.Type = Console.ReadLine()!;
            
            return item;
        }
    }
}