using System;

namespace ManageStore
{
    public class Print
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
    }
}