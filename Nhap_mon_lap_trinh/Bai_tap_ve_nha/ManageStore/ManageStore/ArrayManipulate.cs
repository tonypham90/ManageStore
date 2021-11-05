using System;

namespace ManageStore
{
    public class ArrayManipulate
    {
        // Nhap gia tri vao
        public static Item InputItem(string ghichu, Store warehouse, bool auto)
        {
                    Print.MidSeparate();
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
                        item.Mfg = stringmodifine.InputDate();
                        item.Exp = stringmodifine.Inputexp("Số tháng sử dụng",item.Mfg);
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
            int userchoise = stringmodifine.Inputnumber(inputtext, 1, listlabel.Length);
            return listlabel[userchoise-1];
        }
        
        //nhap nhieu gia tri moi vao kho bang tay
        public static void InsertMultiItem(ref Store data,int noRow)
        {
            Console.WriteLine($"Nhập thêm {noRow} lô hàng vào kho");
            bool auto = stringmodifine.Inputyn("Bạn muốn tạo lô hàng tự động?(y/n): ");
            for (int i = 0; i < noRow; i++)
            {
                //tang them 1 element cho array
                Item[] newItemsList = new Item[data.ItemsList.Length+1];
                for (int j = 0; j < data.ItemsList.Length; j++)
                {
                    newItemsList[j] = data.ItemsList[j];
                }

                data.ItemsList = newItemsList;
                data.ItemsList[^1] = InputItem($"Nhập lô hàng thứ {i+1}", data, auto);

            }
        }
        //Them 1 element string vao array co san
        public static void AddNewString(ref string[] array, string element)
        {
            string[] newarray = new string[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newarray[i] = array[i];
            }

            newarray[^1] = element;
            array = newarray;
        }
        
        //Thay đổi giá trị unique trong string
        public static void ChangeUniqueValue( string valueNeedChange,string newvalue,ref Store data)
        {
            bool duplicate;
            duplicate = Check.DuplicateCheckLabel(newvalue, data);
            if (newvalue == null)
            {
                Console.WriteLine("Giá trị không thay đổi");
            }
            else
            {
                while (duplicate)
                {
                    Console.WriteLine("Giá trị đã tồn tại\nGiá trị mới: ");
                    newvalue = Console.ReadLine()!.ToUpper();
                    duplicate = Check.DuplicateCheckLabel(newvalue, data);
                    
                }
                
                for (int i = 0; i < data.Label.Length; i++) 
                {
                    if (data.Label[i] == valueNeedChange)
                    {
                        data.Label[i] = newvalue;
                        break;
                    }
                }
                
            }
            Console.WriteLine($"Đã thay đổi loại hàng: {valueNeedChange} thành {newvalue}");
        }
        
        //Thay doi gia tri Items chi phuc vu cho function thay doi gia tri label trong edit label
        public static void ChangeLabelInEditLabel(ref Item[] packageds, string[] idStrings, string newLabel)
        {
            for (int i = 0;  i < packageds.Length; ++i)
            {
                bool change;
                foreach (var idItemNeedChange in idStrings)
                {
                    change = idItemNeedChange == packageds[i].Id;
                    switch (change)
                    {
                        case true:
                            
                            Console.WriteLine($"Lô hàng thay đổi loại hàng:");
                            Print.PrintInfItem(packageds[i]);
                            packageds[i].Type = newLabel;
                            break;
                    }
                }
            }
        }
        //Xoa 1 element string trong array co san
        public static void RemoveString(ref string[] array, string target)
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
                    default:
                        Console.WriteLine($"Giá trị {array[i]} đã bị xóa");
                        break;
                }
            }

            array = newarray;
        }
        
        
        //----------------------------
        //Item
        //xoa 1 item trong array list item
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
                        Console.Write("Xóa lô hàng: ");
                        Print.PrintInfItem(listItems[i]);
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
        
    }

}