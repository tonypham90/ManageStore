using System;
using System.Diagnostics;

namespace ManageStore
{
    public class Function
    {
        public static void PrintTable(Store data,bool clearconsole)
        {
            switch (clearconsole)
            {
                case true:
                    Console.Clear();
                    break;
            }
            Stringmodifine.HeaderTable();
            int noitems = data.ItemsList.Length;
            switch (noitems)
            {
                case 0:
                    break;
                default:
                    foreach (var item in data.ItemsList) Stringmodifine.PrintItem(item);
                    break;
            }
            Stringmodifine.EndSeparate();
        }
        //kiem tra gia tri trung lap
        public static bool Duplicatecheckid(string value, Item[] items)
        {
            int count = 0;
            bool check = false;
            if (items != null)
                foreach (var element in items)
                    if (element.Id == value)
                        count += 1;

            if (count > 0) check = true;

            return check;
        }
        //kiem tra gia tri loai hang trung lap
        public static bool DuplicatecheckLable(string value, Store data)
        {
            int count = 0;
            bool check = false;
            if (data.Label != null)
                foreach (var element in data.Label)
                    if (element == value)
                        count += 1;

            if (count > 0) check = true;

            return check;
        }

        // Nhap gia tri vao
        public static Item InputItem(string ghichu, Store warehouse, bool auto)
        {
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
                item.Exp = Stringmodifine.inputexp("Số tháng sử dụng",item.Mfg);
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

       //tao data dau vao
        public static void CreateFirstData(ref Store data)
        {
            bool auto = Stringmodifine.Inputyn("Bạn muốn tạo dữ liệu mẫu:(y/n): ");
            //setup bắt đầu

            switch (auto)
           {
                case true:
                    data.Label = Sample.Type;
                    Console.Write("Số lô hàng mẫu muốn thêm vào");
                    int noPackaged = int.Parse(Console.ReadLine()!);
                    data.ItemsList = new Item[noPackaged];
                    for (int i = 0; i < noPackaged; i++)
                    {
                        string text = $"Lô hàng thứ {i + 1}";
                        data.ItemsList[i] = InputItem(text,data,true);
                    }
                    break;
                default:
                    //1st tao list label
                    Console.Write("Số loại hàng bạn muốn tạo (số lượng): ");
                    int noLable = int.Parse(Console.ReadLine()!);
                    data.Label = new string[noLable];
                    // Nhap loai hang
                    for (int i = 0; i < noLable; i++)
                    {
                        string text = $"Loại hàng thứ {i+1}: ";
                        Console.Write(text);
                        string output = Console.ReadLine()!.ToUpper();
                        bool check = DuplicatecheckLable(output, data);
                        while (check)
                        {
                            Console.Write("Giá trị đã tồn tại, vui lòng nhập lại: ");
                            output = Console.ReadLine()!.ToUpper();
                            check = DuplicatecheckLable(output, data);
                        }

                        data.Label[i] = output;
                    }
                    //2nd tao hang hoa nhap kho
                    int noPackagedmanual = Stringmodifine.Inputnumber("Số lô hàng bạn muốn nhập kho: ",1,100);
                    data.ItemsList = new Item[noPackagedmanual];
                    for (int j = 0; j < noPackagedmanual; j++)
                    {
                        string text = $"Lô hàng thứ {j + 1}";
                        data.ItemsList[j] = InputItem(text,data,false);
                    }
                    break;
            }
        }
        
        //Them data
        public static void adddata(ref Store data,int noRow)
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
                data.ItemsList[^1] = InputItem($"Nhập lô hàng thứ {i+1}", data, auto);

            }


        }

        // public static Item[] FindItems(Store data)
        // {
        //     
        // }
        // dang doi ham replace, remove va find.
        // public static void updateLabel(ref Store data)
        // {
        //     Console.WriteLine("Các mã hàng hiện tại:");
        //     for (int i = 0; i < data.Label.Length; i++)
        //     {
        //         string text = $"{i+1}. {data.Label[i]}";
        //     }
        //     
        // }
    }
}