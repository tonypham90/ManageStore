using System;

namespace ManageStore
{
    public class Function
    {
        public static void PrintTable(Store data)
        {
            Stringmodifine.HeaderTable();
            foreach (var item in data.ItemsList) Stringmodifine.PrintItem(item);
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
        public static Item InputItem(string ghichu, ref Store warehouse, bool auto)
        {
            var item = new Item();
            Console.WriteLine(ghichu);
            if (auto)
            {
                item = Sample.RandItem("Tạo hàng tự động", warehouse);
            }
            else
            {
                Console.Write("Mã Sản Phẩm: ");
                item.Id = Sample.RanId(warehouse.ItemsList);
                Console.Write("Loại sản phẩm: ");
                item.Type = SelectLabel("Loại sản phẩm: ",warehouse);
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
            }

            return item;
        }
        //control chon lable
        public static string SelectLabel(string note, Store data)
        {
            Console.WriteLine(note);
            string[] listlabel = data.Label;
            Console.WriteLine("Loại hàng:");
            for (int i = 0; i < listlabel.Length; i++)
            {
                string text = $"{i + 1}. {listlabel[i]}";
                Console.WriteLine(text);
            }
            Console.WriteLine($"lựa chọn lo số (1~{listlabel.Length})");
            int userchoise = int.Parse(Console.ReadLine()!);
            while (userchoise>listlabel.Length)
            {
                Console.WriteLine($"Vui lòng chọn loại hàng số (1~{listlabel.Length})");
                userchoise = int.Parse(Console.ReadLine()!);
            }

            return listlabel[userchoise-1];
        }

        public static void createfistdata(ref Store data)
        {
            bool auto = true;
            Console.WriteLine("Bạn muốn tạo dữ liệu mẫu:(y/n) ");
            // ReSharper disable once PossibleNullReferenceException
            string choise = Console.ReadLine().ToLower();
            
            switch (choise)
            {
                case "y":
                    auto = true;
                    break;
                default:
                    auto = false;
                    break;
            }
            //setup bắt đầu

            switch (auto)
           {
                case true:
                    data.Label = Sample.Type;
                    Console.WriteLine("Số lô hàng mẫu muốn thêm vào");
                    int noPackaged = int.Parse(Console.ReadLine()!);
                    data.ItemsList = new Item[noPackaged];
                    for (int i = 0; i < noPackaged; i++)
                    {
                        string text = $"Lô hàng thứ {i + 1}";
                        data.ItemsList[i] = InputItem(text,ref data,true);
                    }
                    break;
                default:
                    //1st tao list label
                    Console.WriteLine("Số loại hàng bạn muốn tạo (số lượng)");
                    int noLable = int.Parse(Console.ReadLine()!);
                    data.Label = new string[noLable];
                    // Nhap loai hang
                    for (int i = 0; i < noLable; i++)
                    {
                        string text = $"Loại hàng thứ {i+1}";
                        Console.WriteLine(text);
                        string output = Console.ReadLine()!;
                        bool check = DuplicatecheckLable(output, data);
                        while (check)
                        {
                            Console.WriteLine("Giá trị đã tồn tại, vui lòng nhập lại");
                            output = Console.ReadLine()!;
                            check = DuplicatecheckLable(output, data);
                        }

                        data.Label[i] = output;
                    }
                    //2nd tao hang hoa nhap kho
                    Console.WriteLine("Số lô hàng bạn muốn nhập kho");
                    int noPackagedmanual = Console.Read();
                    data.ItemsList = new Item[noPackagedmanual];
                    for (int j = 0; j < noPackagedmanual; j++)
                    {
                        string text = $"Lô hàng thứ {j + 1}";
                        data.ItemsList[j] = InputItem(text,ref data,false);
                    }
                    break;
            }
        }
    }
}