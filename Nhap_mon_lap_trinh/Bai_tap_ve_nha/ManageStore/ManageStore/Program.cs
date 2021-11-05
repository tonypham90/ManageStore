using System;

namespace ManageStore
{
    internal class Program
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {

            // test create data
            Console.Clear();
            Print.FirstNote();
            Store warehouse = new Store();
            Function.CreateFirstData(ref warehouse);
            Print.PrintTable("Danh Sách lô hàng trong kho",warehouse);
            // bool show = true;
            // while (show)
            // {
            //     Function.FindItems(warehouse);
            //     show = stringmodifine.Inputyn("Bạn có muốn tìm giá trị khác không?");
            // }
            bool show = true;
            while (show)
            {
                Print.PrintTable("Danh Sách lô hàng trong kho",warehouse);
                Console.WriteLine("Lựa chọn chức năng:\n1. Nhập Hàng\n2. Tìm Hàng\n3. Thay đổi thông tin hàng\n4. Xóa lô hàng\n5. Hướng dẫn sử dụng\n6. Thoát");
                int userchoose = stringmodifine.Inputnumber("Lựa chọn chức năng (1~5): ",1,5);
                switch (userchoose)
                {
                    case 1://nhap hang
                        Function.AddNewPackaged(ref warehouse);
                        break;
                    case 2:// tim hang
                        Function.FindItems(warehouse);
                        break;
                    case 3://Thay doi Thong tin hang
                        Function.ChangeInf(ref warehouse);
                        break;
                        
                    case 4:
                        Function.RemoveItem(ref warehouse);
                        break;
                    case 5:
                        Print.MidSeparate();
                        Console.WriteLine("Hướng dẫn sử dụng");
                        break;
                    case 6:
                        show = false;
                        Print.EndSeparate();
                        Print.EndSeparate();
                        Console.WriteLine("Kết thúc phần mềm");
                        Print.FirstNote();
                        Print.EndSeparate();
                        break;
                }
            }
        }
    }
}