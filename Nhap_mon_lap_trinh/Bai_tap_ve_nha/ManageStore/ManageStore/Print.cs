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
            int     countdast = Limitcty + Limithd + Limitlh + Limitmsp + Limitsl + Limitsx + Limitth + 3 * 8-2;
            for (int i = 0; i < countdast; i++) dast += "~";
            Console.WriteLine(dast);
        }
        // seperate midle function
        public static void MidSeparate()
        {
            string dast = null;
            var countdast = (Limitcty + Limithd + Limitlh + Limitmsp + Limitsl + Limitsx + Limitth + 3 * 8-2)/2;
            for (var i = 0; i < countdast; i++) dast += "~";
            Console.WriteLine(dast);
        }
        
        //Printout format table
        

        public static void HeaderTable()
        {
            EndSeparate();
            string id, name, exp, mfg, com, type, qty;
            id = FixFormatTableText("Mã Sản Phẩm", Limitmsp);
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
            var limit = Math.Min(field.Length, limitChar);
            if (limit < limitChar)
            {
                for (var i = 0; i < field.Length; i++) texta += field[i].ToString();

                // ReSharper disable once PossibleNullReferenceException
                while (texta.Length < limitChar) texta += " ";
            }
            else
            {
                for (var i = 0; i < limitChar; i++) texta += field[i].ToString();
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
            exp = FixFormatTableText(stringmodifine.DateString(anItem.Exp), Limithd);
            mfg = FixFormatTableText(stringmodifine.DateString(anItem.Mfg), Limitsx);
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
            exp = stringmodifine.DateString(anItem.Exp);
            mfg = stringmodifine.DateString(anItem.Mfg);
            com = anItem.Com;
            type = anItem.Type;
            Console.WriteLine($"| Mã SP: {id} | Tên: {name} | Số lượng: {qty} | HD: {exp} | NSX: {mfg} | Cty SX: {com} | Loại hàng: {type} |");
        }

        public static void PrintTable(string TableName, Store data)
                {
                    EndSeparate();
                    Console.WriteLine($"BẢNG: {TableName.ToUpper()}");
                    HeaderTable();
                    int noitems = data.ItemsList.Length;
                    switch (noitems)
                    {
                        case 0:
                            break;
                        default:
                            foreach (var item in data.ItemsList) PrintRowItem(item);
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
            row3 = "MSSV:21880005 - Họ Tên: Phạm Tuấn Anh";
            row4 = "MSMH:CSC10001 - GVGD: Phạm Minh Tuấn";
            Console.WriteLine($"{row1}\n{row2}\n{row3}\n{row4}");
        }

        public static void PrintElementArray(string note, string[] Array)
        {
            Console.WriteLine(note);
            for (int i = 0; i < Array.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Array[i]}");
            }
        }
        
    }
}