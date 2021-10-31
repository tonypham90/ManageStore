using System;

namespace ManageStore
{
    public class ArrayManipulate
    {
        // Nhap gia tri vao
        public static Item InputItem(string ghichu, Store warehouse, bool auto)
        {
                    Stringmodifine.EndSeparate();
                    var item = new Item();
                    Console.WriteLine(ghichu);
                    if (auto)
                    {
                        item = Sample.RandItem("Tạo hàng tự động", warehouse);
                    }
                    else
                    {
                        Console.Write("1. Mã Sản Phẩm: ");
                        item.Id = Sample.RanId(warehouse.ItemsList);
                        Console.Write(item.Id);
                        item.Type = SelectLabel("\n2. Loại sản phẩm: ",warehouse);
                        Console.Write("3. Tên sản phẩm: ");
                        item.Name = Console.ReadLine()!.ToUpper();
                        Console.Write("4. Số lượng: ");
                        item.Qty = int.Parse(Console.ReadLine()!);
                        Console.WriteLine("5. Ngày sản xuất: ");
                        item.Mfg = Stringmodifine.InputDate();
                        item.Exp = Stringmodifine.Inputexp("Số tháng sử dụng",item.Mfg);
                        Console.Write("Công ty: ");
                        item.Com = Console.ReadLine()!;
                    }
        
                    return item;
                }
        //control chon lable
        public static string SelectLabel(string note, Store data)
        {
            Console.WriteLine(note);
            string[] listlabel = data.Label;
            for (int i = 0; i < listlabel.Length; i++)
            {
                string text = $"{i + 1}. {listlabel[i]}";
                Console.WriteLine(text);
            }
            string inputtext = $"lựa chọn loại hàng (1~{listlabel.Length}): ";
            int userchoise = Stringmodifine.Inputnumber(inputtext, 1, listlabel.Length);
            return listlabel[userchoise-1];
        }
        
        //nhap nhieu gia tri moi vao kho bang tay
        public static void InsertData(ref Store data,int noRow)
        {
            Console.WriteLine($"Nhập thêm {noRow} lô hàng vào kho");
            bool auto = Stringmodifine.Inputyn("Bạn muốn tạo lô hàng tự động?(y/n): ");
            for (int i = 0; i < noRow; i++)
            {
                //tang them 1 element cho array
                Item[] newitItemslist = new Item[data.ItemsList.Length+1];
                for (int j = 0; j < data.ItemsList.Length; j++)
                {
                    newitItemslist[j] = data.ItemsList[j];
                }

                data.ItemsList = newitItemslist;
                data.ItemsList[^1] = ArrayManipulate.InputItem($"Nhập lô hàng thứ {i+1}", data, auto);

            }
        }
    }
    
}