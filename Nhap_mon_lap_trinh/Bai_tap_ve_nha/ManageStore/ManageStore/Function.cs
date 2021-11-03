using System;

namespace ManageStore
{
    public class Function
    {
        //tao data dau vao
        public static void CreateFirstData(ref Store data)
        {
            Print.EndSeparate();
            bool auto = stringmodifine.Inputyn("Bạn có muốn tạo dữ liệu mẫu:(y/n): ");
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
                        data.ItemsList[i] = ArrayManipulate.InputItem(text, data, true);
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
                        string text = $"Loại hàng thứ {i + 1}: ";
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
                    int noPackagedmanual = stringmodifine.Inputnumber("Số lô hàng bạn muốn nhập kho: ", 1, 100);
                    data.ItemsList = new Item[noPackagedmanual];
                    for (int j = 0; j < noPackagedmanual; j++)
                    {
                        string text = $"Lô hàng thứ {j + 1}";
                        data.ItemsList[j] = ArrayManipulate.InputItem(text, data, false);
                    }

                    break;
            }
        }

        //Them du lieu co san vao data dung search item
        public static void AddItemtoData(ref Store data, Item newItems)
        {

            Item[] newitItemslist = new Item[data.ItemsList.Length + 1];
            for (int j = 0; j < data.ItemsList.Length; j++)
            {
                newitItemslist[j] = data.ItemsList[j];
            }

            data.ItemsList = newitItemslist;
            data.ItemsList[^1] = newItems;
        }


        public static void EditItems(ref Item[] listitem)
        {
            string IdofItem = stringmodifine.Inputlimittext("Nhập mã hàng (4 ký tự): ", 4);
            bool checkinput = false;
            // while (expression)
            // {
            //     
            // }
            // Console.WriteLine("");
            // switch (@enum)
            // {
            //     
            // }
        }


        //Chuc nang tim kiem du lieu
        public static void FindItems(Store data)
        {
            Print.EndSeparate();
            Store result;
            result.ItemsList = new Item[0];
            result.Label = data.Label;
            Console.WriteLine("Lựa chọn các chức năng tìm kiếm sau:\n1. Mã sản phầm\n2.Tên sản phẩm\n3. Loại hàng hóa");
            int userchoise = stringmodifine.Inputnumber("Lựa chọn của bạn (1~3)", 1, 3);
            string inputvalue;
            switch (userchoise)
            {
                case 1: // tim kiem theo mã hàng
                    //Console.Write("Nhập giá trị tìm kiếm theo mã hàng hóa (4 ký tự)");
                    inputvalue = stringmodifine.Inputlimittext("Tìm kiếm theo mã hàng hoán\nNhập giá trị tìm kiếm", 4);
                    foreach (Item eachItem in data.ItemsList)
                    {
                        if (Check.Findvalue(inputvalue, eachItem.Id, false))
                        {
                            AddItemtoData(ref result, eachItem);
                        }
                    }

                    break;
                case 2: //Tim kiem theo ten san pham
                    Console.WriteLine("Tìm kiếm theo tên sản phẩm");
                    Console.WriteLine(
                        "Chọn phương pháp tìm kiếm:\n1. Tìm theo ký tự\n2. Tìm theo viết tắt ký tự đầu mỗi từ");
                    int method = stringmodifine.Inputnumber("Phương pháp (1~2): ", 1, 2);
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
                        if (Check.Findvalue(input, eachItem.Name, fistletter))
                        {
                            AddItemtoData(ref result, eachItem);
                        }
                    }

                    break;
                case 3: //Tim kiem theo loai hang
                    Console.WriteLine("Tìm kiếm theo loại hàng");
                    Console.WriteLine("Các loại hàng trong kho:");
                    for (int i = 0; i < data.Label.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {data.Label[i]}");
                    }

                    int choise = stringmodifine.Inputnumber($"Giá trị lựa chọn (1~{data.Label.Length})", 1,
                        data.Label.Length);
                    string inputlabel = data.Label[choise - 1];
                    foreach (Item eachItem in data.ItemsList)
                    {
                        if (Check.Findvalue(inputlabel, eachItem.Type, false))
                        {
                            AddItemtoData(ref result, eachItem);
                        }
                    }

                    break;
            }

            if (result.ItemsList.Length < 1)
            {
                Console.WriteLine("Kết quả tìm kiếm: không có giá trị nào được tìm thấy");
            }
            else
            {
                Print.PrintTable(result, true);
            }


        }
        

        // Sua thong tin
        public static void EditLable(ref Store data)
        {
            Print.EndSeparate();
            Console.WriteLine("Danh mục các loại hàng:");
            for (int i = 0; i < data.Label.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {data.Label[i]}");
            }

            //khi xóa sẽ xóa hết dữ liệu cùng label và khi đổi thì toàn bộ cùng đổi
            Console.WriteLine("Các lệnh sửa đổi loại hàng:");
            int userchoise = stringmodifine.Inputnumber("1. Thêm\n2. Sửa\n3. Xóa", 1, 3);
            switch (userchoise)
            {
                case 1: //Them gia tri cho label
                    string input = Console.ReadLine()!.ToUpper();
                    bool check = Check.DuplicatecheckLable(input, data);
                    while (check == false)
                    {
                        Console.Write("Thông số nhập vào đã tồn tại,Vui lòng nhập lại giá trị: ");
                        input = Console.ReadLine()!.ToUpper();
                        check = Check.DuplicatecheckLable(input, data);
                    }

                    string[] newlabel = new string[data.Label.Length + 1];
                    for (int j = 0; j < data.Label.Length; j++)
                    {
                        newlabel[j] = data.Label[j];
                    }

                    newlabel[^1] = input;
                    break;
                case 2: // Sua doi ten label va kiem tra items tu do
                    Console.WriteLine("Việc sửa đổi tên loại hàng sẽ thay đổi tên loại hàng các lô hàng có tên loại hàng tương ứng");
                    bool changeShow = stringmodifine.Inputyn("Bạn có muốn tiếp tục thực hiện thay đổi?");
                    while (changeShow)
                    {
                        string labelchoise = ArrayManipulate.SelectLabel("Lựa chọn loại hàng hóa muốn thay đổi", data);
                        // Kiem tra list hàng có cùng mã loại hàng đã chọn
                        string[] itemsIdListNeedChange = Array.Empty<string>();
                        foreach (Item item in data.ItemsList)
                        {
                            if (item.Type == labelchoise)
                            {
                                ArrayManipulate.Addstring(ref itemsIdListNeedChange,item.Id);
                            }
                        }

                        switch (itemsIdListNeedChange.Length)
                        {
                            case 0:
                                Console.WriteLine("Không có lô hàng nào trong kho có loại hàng cùng mã đã chọn");
                                Console.Write($"Bạn muốn đổi Loại {labelchoise} thành: ");
                                string newLabelValue = Console.ReadLine()!.ToUpper();
                                ArrayManipulate.ChangeUniqueValue(labelchoise,newLabelValue,ref data);
                                break;
                            default:
                                Console.Write($"Bạn muốn đổi Loại {labelchoise} thành: ");
                                string newLabelvalue = Console.ReadLine()!.ToUpper();
                                Console.WriteLine("Bảng các lô hàng sẽ thay đổi loại hàng");
                                ArrayManipulate.ChangeLabelinEditLabel(ref data.ItemsList,itemsIdListNeedChange,newLabelvalue);
                                ArrayManipulate.ChangeUniqueValue(labelchoise,newLabelvalue,ref data);
                                break;
                        }
                        Console.WriteLine("Bạn có muốn tiếp tục thay đổi loại hàng khác?");
                        changeShow = stringmodifine.Inputyn("Bạn có muốn tiếp tục thay đổi loại hàng khác?");

                    }

                    break;
                case 3: //xoa ten va kiem tra neu co cac mat hang trung ten se canh bao va xoa toan bo
                    Console.WriteLine("Việc xoá loại hàng sẽ khiến cho các lô hàng có tên loại hàng tương ứng bị xóa");
                    bool changeShowremove = stringmodifine.Inputyn("Bạn có muốn tiếp tục thực hiện thay đổi?");
                    while (changeShowremove)
                    {
                        string labelchoise = ArrayManipulate.SelectLabel("Lựa chọn loại hàng hóa muốn thay đổi", data);
                        // Kiem tra list hàng có cùng mã loại hàng đã chọn
                        string[] itemsIdListNeedRemove = Array.Empty<string>();
                        foreach (Item item in data.ItemsList)
                        {
                            if (item.Type == labelchoise)
                            {
                                ArrayManipulate.Addstring(ref itemsIdListNeedRemove,item.Id);
                            }
                        }

                        switch (itemsIdListNeedRemove.Length)
                        {
                            case 0:
                                Console.WriteLine("Không có lô hàng nào trong kho có loại hàng cùng mã đã chọn");
                                ArrayManipulate.RemoveString(ref data.Label,labelchoise);
                                break;
                            default:
                                Console.Write($"Bạn chọn xóa bỏ Loại hàng {labelchoise}");
                                Console.WriteLine("Bảng các lô hàng sẽ bị xóa do loại hàng đã bị xóa");
                                ArrayManipulate.RemoveItem(ref data.ItemsList,itemsIdListNeedRemove);
                                ArrayManipulate.RemoveString(ref data.Label,labelchoise);
                                break;
                        }
                        changeShowremove = stringmodifine.Inputyn("Bạn có muốn tiếp tục thay đổi loại hàng khác?");

                    }
                    break;

            }

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
}
