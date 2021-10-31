using System;

namespace ManageStore
{
    public class Function
    {
        //tao data dau vao
        public static void CreateFirstData(ref Store data)
        {
            Stringmodifine.EndSeparate();
            bool auto = Stringmodifine.Inputyn("Bạn có muốn tạo dữ liệu mẫu:(y/n): ");
            //setup bắt đầu
            switch (auto)
           {
                case true:
                    data.Label = Sample.Type;
                    Console.Write("Số lô hàng mẫu vào: ");
                    int noPackaged = int.Parse(Console.ReadLine()!);
                    data.ItemsList = new Item[noPackaged];
                    for (int i = 0; i < noPackaged; i++)
                    {
                        string text = $"Lô hàng thứ {i + 1}";
                        data.ItemsList[i] = ArrayManipulate.InputItem(text,data,true);
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
                        bool check = Check.DuplicatecheckLable(output, data);
                        while (check)
                        {
                            Console.Write("Giá trị đã tồn tại, vui lòng nhập lại: ");
                            output = Console.ReadLine()!.ToUpper();
                            check = Check.DuplicatecheckLable(output, data);
                        }

                        data.Label[i] = output;
                    }
                    //2nd tao hang hoa nhap kho
                    int noPackagedmanual = Stringmodifine.Inputnumber("Số lô hàng bạn muốn nhập kho: ",1,100);
                    data.ItemsList = new Item[noPackagedmanual];
                    for (int j = 0; j < noPackagedmanual; j++)
                    {
                        string text = $"Lô hàng thứ {j + 1}";
                        data.ItemsList[j] = ArrayManipulate.InputItem(text,data,false);
                    }
                    break;
            }
        }

        //Them du lieu co san vao data dung search item
        public static void AddItemtoData(ref Store data,Item newItems)
        {
            
            Item[] newitItemslist = new Item[data.ItemsList.Length+1];
            for (int j = 0; j < data.ItemsList.Length; j++)
            {
                newitItemslist[j] = data.ItemsList[j];
            }

            data.ItemsList = newitItemslist;
            data.ItemsList[^1] = newItems;
        }

        
        public static void FindItems(Store data)
        {
            Stringmodifine.EndSeparate();
            Store result;
            result.ItemsList = new Item[0];
            result.Label = data.Label;
            Console.WriteLine("Lựa chọn các chức năng tìm kiếm sau:\n1. Mã sản phầm\n2.Tên sản phẩm\n3. Loại hàng hóa");
            int userchoise = Stringmodifine.Inputnumber("Lựa chọn của bạn (1~3)", 1, 3);
            string inputvalue;
            switch (userchoise)
            {
                case 1:// tim kiem theo mã hàng
                    //Console.Write("Nhập giá trị tìm kiếm theo mã hàng hóa (4 ký tự)");
                    inputvalue = Stringmodifine.Inputlimittext("Tìm kiếm theo mã hàng hoán\nNhập giá trị tìm kiếm",4);
                    foreach (Item eachItem in data.ItemsList)
                    {
                        if (Check.Findvalue(inputvalue,eachItem.Id,false))
                        {
                            AddItemtoData(ref result,eachItem);
                        }
                    }
                    break;
                case 2://Tim kiem theo ten san pham
                    Console.WriteLine("Tìm kiếm theo tên sản phẩm");
                    Console.WriteLine("Chọn phương pháp tìm kiếm:\n1. Tìm theo ký tự\n2. Tìm theo viết tắt ký tự đầu mỗi từ");
                    int method = Stringmodifine.Inputnumber("Phương pháp (1~2): ", 1, 2);
                    bool fistletter;
                    switch (method)
                    {
                        case 2:
                            fistletter = true;
                            Console.WriteLine("Vui lòng nhập các ký tự đầu của mỗi từ không khoản cách");
                            break;
                        default:
                            fistletter = false;
                            Console.WriteLine("Vui lòng nhập từ bạn muốn tìm kiếm");
                            break;
                    }
                    Console.Write("Giá trị tìm kiếm: ");
                    string input = Console.ReadLine()!.ToUpper();
                    foreach (Item eachItem in data.ItemsList)
                    {
                        if (Check.Findvalue(input,eachItem.Name,fistletter))
                        {
                            AddItemtoData(ref result,eachItem);
                        }
                    }
                    break;
                case 3://Tim kiem theo loai hang
                    Console.WriteLine("Tìm kiếm theo loại hàng");
                    Console.WriteLine("Các loại hàng trong kho:");
                    for (int i = 0; i < data.Label.Length; i++)
                    {
                        Console.WriteLine($"{i+1}. {data.Label[i]}");
                    }

                    int choise = Stringmodifine.Inputnumber($"Giá trị lựa chọn (1~{data.Label.Length})", 1,
                        data.Label.Length);
                    string inputlabel = data.Label[choise - 1];
                    foreach (Item eachItem in data.ItemsList)
                    {
                        if (Check.Findvalue(inputlabel,eachItem.Type,false))
                        {
                            AddItemtoData(ref result,eachItem);
                        }
                    }
                    break;
            }

            if (result.ItemsList.Length<1)
            {
                Console.WriteLine("Kết quả tìm kiếm: không có giá trị nào được tìm thấy");
            }
            else
            {
                Print.PrintTable(result,true);
            }
            

        }
        //Them 1 element vao array
        public static void Addstring(ref string[] array, string element)
        {
            string[] newarray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i];
            }

            newarray[^1] = element;
            array = newarray;
        }
        //xoa 1 string trong array
        public static void Removestring(ref string[] array, string target)
        {
            //tim do dai array sau khi da xoa du lieu
            int[] rListIndexremove;
            int count = 0,newindex=0;
            foreach (string element in array)
            {
                if (element == target)
                {
                    count += 1;
                }
            }
//danh sach id cac element trung trong list
            rListIndexremove = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==target)
                {
                    rListIndexremove[newindex] = i;
                    newindex += 1;
                }
            }

            string[] newarray = new string[array.Length - rListIndexremove.Length];
            int indexnewarray = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int countindexremove = 0;
                for (int j = 0; j < rListIndexremove.Length; j++)
                {
                    if (i==rListIndexremove[j])
                    {
                        countindexremove += 1;
                    }
                }

                switch (countindexremove)
                {
                    case 0:
                        newarray[indexnewarray] = array[i];
                        indexnewarray += 1;
                        break;
                }
            }

            array = newarray;
        }
//xoa 1 item trong array items
        public static void RemoveItem(ref Item[] listItems, string[] listIdStrings)
        {
            //tim do dai array sau khi xoa item
            int countRemove = 0;
            foreach (Item item in listItems)
            {
                foreach (string idString in listIdStrings)
                {
                    if (idString == item.Id)
                    {
                        countRemove += 1;
                    }
                }
            }
            Item[] newItemsList = new Item[listItems.Length - countRemove];
            int newindex = 0;
            for (int i = 0; i < listItems.Length; i++)
            {
                int countid = 0;
                for (int j = 0; j < listIdStrings.Length; j++)
                {
                    if (listItems[i].Id == listIdStrings[j])
                    {
                        countid += 1;
                    }
                }

                switch (countid)
                {
                    case 0:
                        newItemsList[newindex] = listItems[i];
                        newindex += 1;
                        break;
                }
            }

            listItems = newItemsList;

        }
        //Sua thong tin
        // public static void editLable(ref Store data)
        // {
        //     Stringmodifine.EndSeparate();
        //     Console.WriteLine("Danh mục các loại hàng:");
        //     for (int i = 0; i < data.Label.Length; i++)
        //     {
        //         Console.WriteLine($"{i+1}. {data.Label[i]}");
        //     }
        //     //khi xóa sẽ xóa hết dữ liệu cùng label và khi đổi thì toàn bộ cùng đổi
        //     Console.WriteLine("Các lệnh sửa đổi loại hàng:");
        //     int userchoise=Stringmodifine.Inputnumber("1. Thêm\n2. Sửa thông tin\n3. Xóa", 1, 3);
        //     switch (userchoise)
        //     {
        //         case 1://Them gia tri cho label
        //             string input = Console.ReadLine()!.ToUpper();
        //             bool check = DuplicatecheckLable(input, data);
        //             while (check==false)
        //             {
        //                 Console.Write("Thông số nhập vào đã tồn tại,Vui lòng nhập lại giá trị: ");
        //                 input = Console.ReadLine()!.ToUpper();
        //                 check = DuplicatecheckLable(input, data);
        //             }
        //
        //             string[] newlabel = new string[data.Label.Length + 1];
        //             for (int j = 0; j < data.Label.Length; j++)
        //             {
        //                 newlabel[j] = data.Label[j];
        //             }
        //
        //             newlabel[^1] = input;
        //             break;
        //         case 2:
        //             
        //     }

        }
        
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
