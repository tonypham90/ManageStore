using System;

namespace ManageStore
{
    public class Function
    {
        //tao data dau vao
        public static void CreateFirstData(ref Store data)
        {
            Print.EndSeparate();
            bool auto = stringmodifine.ChooseYesNo("Bạn có muốn tạo dữ liệu mẫu?");
            //setup bắt đầu
            switch (auto)
            {
                case true:
                    data.Label = Sample.Type;
                    Console.Write("Số lô hàng mẫu: ");
                    int noPackaged = int.Parse(Console.ReadLine()!);
                    data.ItemsList = new Item[noPackaged];
                    for (int i = 0; i < noPackaged; i++)
                    {
                        Print.ShortSeparate();
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
                        bool check = Check.DuplicateCheckLabel(output, data);
                        while (check)
                        {
                            Console.Write("Giá trị đã tồn tại, vui lòng nhập lại: ");
                            output = Console.ReadLine()!.ToUpper();
                            check = Check.DuplicateCheckLabel(output, data);
                        }

                        data.Label[i] = output;
                    }

                    //2nd tao hang hoa nhap kho
                    int noPackagedmanual = stringmodifine.Inputnumber("Số lô hàng bạn muốn nhập kho", 1, 100);
                    data.ItemsList = new Item[noPackagedmanual];
                    for (int j = 0; j < noPackagedmanual; j++)
                    {
                        string text = $"Lô hàng thứ {j + 1}";
                        data.ItemsList[j] = ArrayManipulate.InputItem(text, data, false);
                    }

                    break;
            }
        }


        //Chuc nang tim kiem du lieu
        public static void FindItems(Store data)
        {
            Print.EndSeparate();
            Console.WriteLine("Tìm lô hàng".ToUpper());
            Store result;
            result.Label = data.Label;
            bool show = true;
            while (show)
            {
                Print.MidSeparate();
                Console.WriteLine("Các chức năng tìm kiếm:\n1. Mã sản phầm\n2. Tên sản phẩm\n3. Loại hàng hóa\n4. Công ty sản xuất\n5. Thoát");
                Print.MidSeparate();
                int userchoise = stringmodifine.Inputnumber("chức năng", 1, 5);
                string inputvalue;
                bool fistletter;
                string input;
                result.ItemsList = new Item[0];
                switch (userchoise)
                {
                    case 1: // tim kiem theo mã hàng
                        Print.MidSeparate();
                        Console.WriteLine("Chức năng: Tìm kiếm theo mã lô hàng");
                        inputvalue = stringmodifine.Inputlimittext("Nhập giá trị tìm kiếm", 4).ToUpper();
                        foreach (Item eachItem in data.ItemsList)
                        {
                            if (Check.FindValue(inputvalue, eachItem.Id, false))
                            {
                                ArrayManipulate.AddItemtoData(ref result, eachItem);
                            }
                        }
                        if (result.ItemsList.Length < 1)
                        {
                            Console.WriteLine("Kết quả tìm kiếm: không có giá trị nào được tìm thấy");
                        }
                        else
                        {
                            Print.PrintTable("Kết quả tìm kiếm",result);
                        }

                        // result.ItemsList = new Item[0];
                        break;
                    case 2: //Tim kiem theo ten san pham
                        Print.MidSeparate();
                        Console.WriteLine("Chức năng: Tìm kiếm theo tên sản phẩm");
                        Console.WriteLine(
                            "Chọn phương pháp tìm kiếm:\n1. Tìm theo ký tự\n2. Tìm theo viết tắt ký tự đầu mỗi từ");
                        int method = stringmodifine.Inputnumber("Phương pháp tìm kiếm", 1, 2);
                        switch (method)
                        {
                            case 2:
                                Print.MidSeparate();
                                Console.WriteLine("Chức năng: Tìm theo ký tự viết tắt đầu mỗi từ");
                                fistletter = true;
                                Console.Write("Giá trị cần tìm kiếm: ");
                                break;
                            default:
                                Print.MidSeparate();
                                Console.WriteLine("Chức năng: Tìm theo ký tự");
                                fistletter = false;
                                Console.Write("Giá trị cần tìm kiếm: ");
                                break;
                        }
                        input = Console.ReadLine()!.ToUpper();
                        foreach (Item eachItem in data.ItemsList)
                        {
                            if (Check.FindValue(input, eachItem.Name, fistletter))
                            {
                                ArrayManipulate.AddItemtoData(ref result, eachItem);
                            }
                        }
                        if (result.ItemsList.Length < 1)
                        {
                            Console.WriteLine("Kết quả tìm kiếm: không có giá trị nào được tìm thấy");
                        }
                        else
                        {
                            Print.PrintTable("Kết quả tìm kiếm",result);
                        }

                        break;
                    case 3: //Tim kiem theo loai hang
                        Print.MidSeparate();
                        Console.WriteLine("Tìm kiếm theo loại hàng");
                        Console.WriteLine("Các loại hàng trong kho:");
                        for (int i = 0; i < data.Label.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {data.Label[i]}");
                        }

                        int choose = stringmodifine.Inputnumber("loại hàng cần tìm", 1,
                            data.Label.Length);
                        string inputlabel = data.Label[choose - 1];
                        foreach (Item eachItem in data.ItemsList)
                        {
                            if (Check.FindValue(inputlabel, eachItem.Type, false))
                            {
                                ArrayManipulate.AddItemtoData(ref result, eachItem);
                            }
                        }
                        if (result.ItemsList.Length < 1)
                        {
                            Console.WriteLine("Kết quả tìm kiếm: không có giá trị nào được tìm thấy");
                        }
                        else
                        {
                            Print.PrintTable("Kết quả tìm kiếm",result);
                        }

                        break;
                    case 4://Tìm theo công ty sản xuất.4
                        Print.MidSeparate();
                        Console.WriteLine("Tìm kiếm theo tên công ty sản xuất");
                        Console.WriteLine(
                            "Chọn phương pháp tìm kiếm:\n1. Tìm theo ký tự\n2. Tìm theo viết tắt ký tự đầu mỗi từ");
                        method = stringmodifine.Inputnumber("Phương pháp tìm kiếm", 1, 2);
                        switch (method)
                        {
                            case 2:
                                fistletter = true;
                                Console.Write("Vui lòng nhập các ký tự đầu của mỗi từ không khoản cách: ");
                                break;
                            default:
                                fistletter = false;
                                Console.Write("Vui lòng nhập giá trị bạn muốn tìm kiếm: ");
                                break;
                        }
                        input = Console.ReadLine()!.ToUpper();
                        foreach (Item eachItem in data.ItemsList)
                        {
                            if (Check.FindValue(input, eachItem.Com, fistletter))
                            {
                                ArrayManipulate.AddItemtoData(ref result, eachItem);
                            }
                        }
                        if (result.ItemsList.Length < 1)
                        {
                            Console.WriteLine("Kết quả tìm kiếm: không có giá trị nào được tìm thấy");
                        }
                        else
                        {
                            Print.PrintTable("Kết quả tìm kiếm",result);
                        }

                        break;
                    case 5:
                        Console.WriteLine("Thoát trình tìm kiếm");
                        Print.EndSeparate();
                        show = false;
                        break;
                }
            }

        }
        

        // Sua thong tin
        //Thay đổi loại sản phẩm
        public static void EditLabel(ref Store data)
        {
            Print.EndSeparate();
            //khi xóa sẽ xóa hết dữ liệu cùng label và khi đổi thì toàn bộ cùng đổi
            Console.WriteLine("Thao tác sửa đổi loại hàng");
            bool show = true;
            while (show)
            {
                Print.MidSeparate();
                Console.WriteLine("Các lệnh sửa đổi loại hàng:\n1. Thêm\n2. Sửa\n3. Xóa\n4. Thoát");
                int userchoise = stringmodifine.Inputnumber("chức năng", 1, 4);
                Print.ShortSeparate();
                switch (userchoise)
                {
                    case 1: //Them gia tri cho label
                        Print.PrintElementArray("Các loại hàng hiện có: ",data.Label);
                        Console.Write("Tên loại hàng mới: ");
                        string input = Console.ReadLine()!.ToUpper();
                        bool check = Check.DuplicateCheckLabel(input, data);
                        while (check)
                        {
                            Console.Write("Loại hàng này đã tồn tại,Vui lòng nhập giá trị khác: ");
                            input = Console.ReadLine()!.ToUpper();
                            check = Check.DuplicateCheckLabel(input, data);
                        }

                        string[] newlabel = new string[data.Label.Length + 1];
                        for (int j = 0; j < data.Label.Length; j++)
                        {
                            newlabel[j] = data.Label[j];
                        }
                        newlabel[^1] = input;
                        data.Label = newlabel;
                        break;
                    case 2: // Sua doi ten label va kiem tra items tu do
                        Console.WriteLine("Việc sửa đổi tên loại hàng sẽ thay đổi tên loại hàng các lô hàng có tên loại hàng tương ứng");
                        bool changeShow = stringmodifine.ChooseYesNo("Bạn có muốn tiếp tục thực hiện thay đổi?");
                        while (changeShow)
                        {
                            string labelchoise = ArrayManipulate.SelectLabel("Lựa chọn loại hàng hóa muốn thay đổi", data);
                            // Kiem tra list hàng có cùng mã loại hàng đã chọn
                            string[] itemsIdListNeedChange = Array.Empty<string>();
                            foreach (Item item in data.ItemsList)
                            {
                                if (item.Type == labelchoise)
                                {
                                    ArrayManipulate.AddNewString(ref itemsIdListNeedChange,item.Id);
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
                                    ArrayManipulate.ChangeLabelInEditLabel(ref data.ItemsList,itemsIdListNeedChange,newLabelvalue);
                                    ArrayManipulate.ChangeUniqueValue(labelchoise,newLabelvalue,ref data);
                                    break;
                            }
                            changeShow = stringmodifine.ChooseYesNo("Bạn có muốn tiếp tục thay đổi loại hàng khác?");

                        }

                        break;
                    case 3: //xoa ten va kiem tra neu co cac mat hang trung ten se canh bao va xoa toan bo
                        Console.WriteLine("Việc xoá loại hàng sẽ khiến cho các lô hàng có tên loại hàng tương ứng bị xóa");
                        bool changeShowRemove = stringmodifine.ChooseYesNo("Bạn có muốn tiếp tục thực hiện thay đổi?");
                        while (changeShowRemove)
                        {
                            string labelchoise = ArrayManipulate.SelectLabel("Lựa chọn loại hàng hóa muốn thay đổi: ", data);
                            // Kiem tra list hàng có cùng mã loại hàng đã chọn
                            string[] itemsIdListNeedRemove = Array.Empty<string>();
                            foreach (Item item in data.ItemsList)
                            {
                                if (item.Type == labelchoise)
                                {
                                    ArrayManipulate.AddNewString(ref itemsIdListNeedRemove,item.Id);
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
                            changeShowRemove = stringmodifine.ChooseYesNo("Bạn có muốn tiếp tục thay đổi loại hàng khác?");

                        }
                        break;
                    case 4:
                        show = false;
                        break;
                   
                }

            }
            Print.EndSeparate();
        }
        
        // Thao tác Lô Hàng
        public static void EditPackaged(ref Store data)
        {
            Print.EndSeparate();
            Console.WriteLine("Thay đổi thông tin lô hàng".ToUpper());
            Print.MidSeparate();
            bool show = true;
            while (show)
            {
                Console.WriteLine("Chọn chức năng:\n1. Sửa đổi thông tin theo mã lô hàng\n2. Thoát");
                int userChoose = stringmodifine.Inputnumber("chức năng", 1, 2);
                switch (userChoose)
                {
                    case 2:
                        show = false;
                        Print.EndSeparate();
                        break;
                    case 1:
                        string idOfItem = stringmodifine.Inputlimittext("Mã lô hàng bạn muốn thay đổi",4);
                        bool checkId = Check.Duplicatecheckid(idOfItem, data.ItemsList);
                        while (checkId==false) //kiểm tra nhập Mã lô hàng
                        {
                            Console.WriteLine("Mã lô hàng không tồn tại, vui lòng kiểm tra lại");
                            Print.PrintTable("Danh sách lô hàng trong kho",data);
                            idOfItem = stringmodifine.Inputlimittext("Mã lô hàng bạn muốn thay đổi (4 ký tự)",4);
                            checkId = Check.Duplicatecheckid(idOfItem, data.ItemsList);
                        }

                        int idPackaged = 0;
                        for (int i = 0; i < data.ItemsList.Length; i++)
                        {
                            Item currentItem = data.ItemsList[i];
                            if (Check.FindValue(idOfItem, currentItem.Id, false))
                            {
                                idPackaged = i;
                                break;
                            }
                        }
                        Console.WriteLine("Thông tin bạn muốn thay đổi:\n1. Tên sản phẩm\n2. Công Ty" +
                                          "\n3. Số lượng\n4. Ngày sản xuất và Hạn dùng\n5. Loại Hàng\n6. Thoát");
                        int editChoose = stringmodifine.Inputnumber("chức năng (1~7)", 1, 6);
                        switch (editChoose)
                        {
                            case 1:
                                Console.WriteLine($"Tên sản phẩm hiện tại: {data.ItemsList[idPackaged].Name}");
                                Console.Write("Tên mới của sản phẩm: ");
                                data.ItemsList[idPackaged].Name = Console.ReadLine()!.ToUpper();
                                break;
                            case 2:
                                Console.WriteLine($"Tên công ty sản xuất hiện tại: {data.ItemsList[idPackaged].Com}");
                                Console.Write("Tên công ty sản xuất mới: ");
                                data.ItemsList[idPackaged].Com = Console.ReadLine()!.ToUpper();
                                break;
                            case 3:
                                Console.WriteLine($"Số lượng sản phẩm hiện tại của lô hàng: {data.ItemsList[idPackaged].Qty}");
                                // Console.Write("Tên công ty sản xuất mới: ");
                                data.ItemsList[idPackaged].Qty = stringmodifine.Inputnumber("Số lượng sản phẩm: ",0,10000);
                                break;
                            case 4:
                                Console.WriteLine($"Ngày sản xuất: {Print.DateString(data.ItemsList[idPackaged].Mfg)}-Hạn Dùng:{Print.DateString(data.ItemsList[idPackaged].Exp)} ");
                                Console.Write("Ngày sản xuất mới của lô hàng: ");
                                data.ItemsList[idPackaged].Mfg = stringmodifine.InputDate();
                                data.ItemsList[idPackaged].Exp = stringmodifine.Inputexp("Hạn dùng(số tháng)",
                                    data.ItemsList[idPackaged].Mfg);
                                break;
                            case 5:
                                Console.WriteLine($"Tên Loại sản phẩm của lô hàng hiện tại: {data.ItemsList[idPackaged].Type}");
                                // Console.Write("Tên công ty sản xuất mới: ");
                                data.ItemsList[idPackaged].Type = ArrayManipulate.SelectLabel("Loại hàng hóa mới: ",data);
                                break;
                            case 6:
                                show = false;
                                break;
                        }
                        Print.MidSeparate();
                        Console.WriteLine("Thông tin lô hàng sau khi thay đổi");
                        Print.PrintInfItem(data.ItemsList[idPackaged]);

                        break;
                        
                }
            }
            Print.EndSeparate();
        }
        
        public static void AddNewPackaged(ref Store data)
        {
            Print.EndSeparate();
            Console.WriteLine("Nhập lô hàng mới vào kho".ToUpper());
            Print.MidSeparate();
            bool show = true;
            while (show)
            {
                Console.WriteLine("Chức năng:\n1. Nhập lô hàng mới\n2. Thoát");
                int userchoose = stringmodifine.Inputnumber("chức năng", 1, 2);
                switch (userchoose)
                {
                    case 1:
                        int noNewPackaged = stringmodifine.Inputnumber("Số lô hàng mới cần nhập kho", 1, 10);
                        ArrayManipulate.InsertMultiItem(ref data,noNewPackaged);
                        break;
                    case 2:
                        Print.EndSeparate();
                        show = false;
                        break;
                }
            }
            Print.EndSeparate();
        }

        public static void ChangeInf(ref Store data)
        {
            Print.EndSeparate();
            Console.WriteLine("Thay đổi thông tin".ToUpper());
            Print.MidSeparate();
            bool show = true;
            while (show)
            {
                Console.WriteLine("Các thông tin có thể thay đổi:\n1. Lô hàng\n2. Loại sản phẩm\n3. Thoát");
                int userchoose = stringmodifine.Inputnumber("thông tin cần thay đổi", 1, 3);
                switch (userchoose)
                {
                    case 1:
                        EditPackaged(ref data);
                        break;
                    case 2:
                        EditLabel(ref data);
                        break;
                    case 3:
                        show = false;
                        Print.EndSeparate();
                        break;
                }
            }
        }

        public static void RemoveItem(ref Store data)
        {
            Print.EndSeparate();
            Console.WriteLine("Xóa dữ liệu".ToUpper());
            Print.MidSeparate();
            bool show = true;
            while (show)
            {
                Console.WriteLine("Chức Năng xóa:\n1. Mã lô \n2. Theo nhóm loại hàng\n3. Thoát");
                int userchoose = stringmodifine.Inputnumber("chức năng", 1, 3);
                switch (userchoose)
                {
                    case 1://xóa theo nhóm mã lô hàng
                        Print.MidSeparate();
                        string text = $"số lô hàng cần xóa";
                        int noRemove= stringmodifine.Inputnumber(text, 1, data.ItemsList.Length);
                        bool doubleAsk = stringmodifine.ChooseYesNo($"Bạn có chắc mình muốn xóa {noRemove} số lô hàng?");

                        if (doubleAsk)
                        {
                            string[] listIdRemove = new string[noRemove];
                            for (int i = 0; i < listIdRemove.Length; i++)
                            {
                                bool check = false;
                                while (check == false)
                                {
                                    bool duplicate = true;
                                    string inputvalue;
                                    inputvalue = stringmodifine.Inputlimittext($"Mã lô hàng thứ {i+1} cần xóa: ", 4);
                                    duplicate = Check.DuplicatecheckString(inputvalue,listIdRemove);
                                    while (duplicate)
                                    {
                                        inputvalue = stringmodifine.Inputlimittext($"Mã lô hàng bạn nhập đã tồn tại\n Vui lòng nhập giá trị khác: ", 4);
                                        duplicate = Check.DuplicatecheckString(inputvalue,listIdRemove);
                                    }
                                    listIdRemove[i] = stringmodifine.Inputlimittext($"Mã lô hàng thứ {i+1} cần xóa: ", 4);
                                    check = Check.Duplicatecheckid(listIdRemove[i], data.ItemsList);
                                
                                    if (check == false)
                                    {
                                        Console.WriteLine("Giá trị bạn nhập không có trong danh sách lô sản phẩm, vui lòng kiểm tra lại trong bảng sau:");
                                        Print.PrintTable("Các sản phẩm hiện có".ToUpper(),data);
                                    }
                                }
                            }
                            ArrayManipulate.RemoveItem(ref data.ItemsList,listIdRemove);
                        }
                        
                        
                        break;
                    case 2: //xóa theo loại sản phẩm
                        bool changeShowRemove = true;
                        Print.MidSeparate();
                        while (changeShowRemove)
                        {
                            string chooseLabel = ArrayManipulate.SelectLabel("Lựa chọn loại hàng hóa muốn xóa: ", data);
                            // Kiem tra list hàng có cùng mã loại hàng đã chọn
                            string[] itemsIdListNeedRemove = Array.Empty<string>();
                            foreach (Item item in data.ItemsList)
                            {
                                if (item.Type == chooseLabel)
                                {
                                    ArrayManipulate.AddNewString(ref itemsIdListNeedRemove,item.Id);
                                }
                            }

                            switch (itemsIdListNeedRemove.Length)
                            {
                                case 0:
                                    Console.WriteLine("Không có lô hàng nào trong kho có loại hàng cùng mã đã chọn");
                                    ArrayManipulate.RemoveString(ref data.Label,chooseLabel);
                                    break;
                                default:
                                    Console.WriteLine($"Bạn chọn xóa bỏ Loại hàng {chooseLabel}");
                                    Console.WriteLine("Các lô hàng sẽ bị xóa do loại hàng đã bị xóa");
                                    ArrayManipulate.RemoveItem(ref data.ItemsList,itemsIdListNeedRemove);
                                    ArrayManipulate.RemoveString(ref data.Label,chooseLabel);
                                    break;
                            }
                            changeShowRemove = stringmodifine.ChooseYesNo("Bạn có muốn tiếp tục xóa loại hàng khác?");

                        }
                        break;
                    case 3: //thoát
                        show = false;
                        Print.EndSeparate();
                        break;

                }
            }

        }
    }
}
