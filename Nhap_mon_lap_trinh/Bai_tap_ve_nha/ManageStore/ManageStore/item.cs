using System;

namespace ManageStore
{
    public struct Item
    {
        public string Id;/*Mã sản phẩm*/
        public string Name;/*Tên sản phẩm*/
        public int Qty;/*So luong san pham*/
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
            Console.Write("Mã Sản Phẩm: ");
            item.Id = Console.ReadLine()!;
            Console.Write("Tên sản phẩm: ");
            item.Name = Console.ReadLine()!;
            Console.Write("Tên sản phẩm: ");
            item.Qty = int.Parse(Console.ReadLine()!);
            Console.Write("Hạn Dùng: ");
            item.Exp =Stringmodifine.Inputdate();
            Console.Write("Ngày sản xuất: ");
            item.Mfg = Stringmodifine.Inputdate();
            Console.Write("Tên sản phẩm: ");
            item.Type = Console.ReadLine()!;
            
            return item;
        }
    }
    public struct store
    {
        public Item[] Itemslist;
    }
}