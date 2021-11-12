using System;

namespace ManageStore
{
    public class Print
    {
        /*Width of column gioi han so space in trong bang*/
        private const int Limitmsp = 11,
            Limitth = 30,
            Limitsl = 8,
            Limithd = 10,
            Limitsx = 11,
            Limitlh = 11,
            Limitcty = 20;

        // Header Table format
        public static void EndSeparate()
        {
            string dast = null;
            var countdast = Limitcty + Limithd + Limitlh + Limitmsp + Limitsl + Limitsx + Limitth + 3 * 8 - 2;
            for (var i = 0; i < countdast; i++) dast += "~";
            Console.WriteLine(dast);
        }

        // seperate midle function
        public static void MidSeparate()
        {
            string dast = null;
            var countdast = (Limitcty + Limithd + Limitlh + Limitmsp + Limitsl + Limitsx + Limitth + 3 * 8 - 2) / 2;
            for (var i = 0; i < countdast; i++) dast += "~";
            Console.WriteLine(dast);
        }

        //Printout format table


        public static void HeaderTable()
        {
            EndSeparate();
            string id, name, exp, mfg, com, type, qty;
            id = FixFormatTableText("Mã Lô Hàng", Limitmsp);
            name = FixFormatTableText("Tên Hàng", Limitth);
            qty = FixFormatTableText("Số lượng", Limitsl);
            exp = FixFormatTableText("HSD (mm/yy)", Limithd);
            mfg = FixFormatTableText("NSX (mm/yy)", Limitsx);
            com = FixFormatTableText("Cty sản xuất", Limitcty);
            type = FixFormatTableText("Loại hàng", Limitlh);
            string text = $"| {id} | {name} | {qty} | {exp} | {mfg} | {com} | {type} |";

            Console.WriteLine(text);
            EndSeparate();
        }

        //cố định định dạng bảng khi in kết quả ra trong bảng
        public static string FixFormatTableText(string field, int limitChar)
        {
            // Gioi han so luong ky tu in;
            string texta = null;
            int limit = Math.Min(field.Length, limitChar);
            if (limit < limitChar)
            {
                for (int i = 0; i < field.Length; i++) texta += field[i].ToString();

                // ReSharper disable once PossibleNullReferenceException
                while (texta.Length < limitChar) texta += " ";
            }
            else
            {
                for (int i = 0; i < limitChar; i++) texta += field[i].ToString();
            }

            return texta;
        }

        //in gia tri cua lo hang
        public static void PrintRowItem(Item anItem)
        {
            string id, name, exp, mfg, com, type, qty;
            id = FixFormatTableText(anItem.Id, Limitmsp);
            name = FixFormatTableText(anItem.Name, Limitth);
            qty = FixFormatTableText(anItem.Qty.ToString(), Limitsl);
            exp = FixFormatTableText(DateString(anItem.Exp), Limithd);
            mfg = FixFormatTableText(DateString(anItem.Mfg), Limitsx);
            com = FixFormatTableText(anItem.Com, Limitcty);
            type = FixFormatTableText(anItem.Type, Limitlh);
            Console.WriteLine($"| {id} | {name} | {qty} | {exp} | {mfg} | {com} | {type} |");
        }

        public static void PrintInfItem(Item anItem)
        {
            string id, name, exp, mfg, com, type, qty;
            id = anItem.Id;
            name = anItem.Name;
            qty = anItem.Qty.ToString();
            exp = DateString(anItem.Exp);
            mfg = DateString(anItem.Mfg);
            com = anItem.Com;
            type = anItem.Type;
            Console.WriteLine(
                $"| Mã lô hàng: {id} | Tên: {name} | Số lượng: {qty} | HD: {exp} | NSX: {mfg} | Cty SX: {com} | Loại hàng: {type} |");
        }

        public static void PrintTable(string tableName, Store data)
        {
            EndSeparate();
            Console.WriteLine($"BẢNG: {tableName.ToUpper()}");
            HeaderTable();
            int noitems = data.ItemsList.Length;
            switch (noitems)
            {
                case 0:
                    break;
                default:
                    foreach (Item item in data.ItemsList) PrintRowItem(item);
                    break;
            }

            EndSeparate();
        }

        //Print first note
        public static void FirstNote()
        {
            string row1, row2, row3, row4;
            row1 = "ĐỒ ÁN MÔN HỌC NHẬP MÔN LẬP TRÌNH";
            row2 = "Tên Đồ Án: Phần Mềm Quản Lý Hàng Hóa";
            row3 = "MSSV:21880005 - Họ Tên Sinh Viên: Phạm Tuấn Anh";
            row4 = "MSMH:CSC10001 - GVGD: Phạm Minh Tuấn";
            Console.WriteLine($"{row1}\n{row2}\n{row3}\n{row4}");
        }

        public static void PrintElementArray(string note, string[] array)
        {
            Console.WriteLine(note);
            for (int i = 0; i < array.Length; i++) Console.WriteLine($"{i + 1}. {array[i]}");
        }

        public static string DateString(Date a) /*in dinh dang ngay thang cho du lieu struct Date*/
        {
            string textdate = $"{a.Month:00}/{a.Year:00}";
            return textdate;
        }

        public static void Instruction()
        {
            EndSeparate();

            Console.WriteLine("Hướng dẫn sử dụng".ToUpper() +
                              "\n Quy trình tạo mới: Tạo danh sách loại hàng -> Nhập hàng mới vào kho (Có chức năng tạo hàng mẫu tự động và tạo hàng thủ công)" +
                              "\n1. Tạo mới: Tạo lô hàng mới vào kho; có 2 chức năng là tạo tự động và tạo thủ công" +
                              "\n2. Tìm thông tin: Chức năng tìm kiếm thông tin lô hàng theo các ký tự đầu mỗi từ hoặc chuỗi ký tự" +
                              "\n3. Thay đổi thông tin: Thay đổi thông tin của từng lô hàng hoặc theo thông tin loại hàng (ngoại trừ mã hàng không được thay đổi)" +
                              "\n - Đối với thay đổi thông tin loại hàng có thể xóa hoặc tạo mới loại hàng" +
                              "\n - Việc xóa loại hàng sẽ khiến các các mặt hàng cùng loại hàng sẽ bị xóa theo nên trước khi xóa loại hàng cần chuyển các mặt hàng qua loại hàng mới" +
                              "\n4. Xóa: Xóa lô hàng đang có trong kho" +
                              "\n - Nên lưu ý xóa loại hàng sẽ khiến các mặt hàng cùng loại hàng bị xóa theo");
        }

        public static void ShortSeparate()
        {
            string dast = null;
            int countdast = (Limitcty + Limithd + Limitlh + Limitmsp + Limitsl + Limitsx + Limitth + 3 * 8 - 2) / 4;
            for (int i = 0; i < countdast; i++) dast += "~";
            Console.WriteLine(dast);
        }
    }
}