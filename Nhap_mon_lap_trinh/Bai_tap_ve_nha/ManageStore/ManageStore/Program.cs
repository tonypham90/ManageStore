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
            Print.Instruction();
            var warehouse = new Store();
            Function.CreateFirstData(ref warehouse);
            // Print.PrintTable("Danh Sách lô hàng trong kho",warehouse);
            // bool show = true;
            // while (show)
            // {
            //     Function.FindItems(warehouse);
            //     show = stringmodifine.Inputyn("Bạn có muốn tìm giá trị khác không?");
            // }
            var show = true;
            while (show)
            {
                Print.EndSeparate();
                Print.PrintTable("Danh Sách lô hàng trong kho", warehouse);
                Console.WriteLine("Chức năng chính".ToUpper());
                Print.MidSeparate();
                Console.WriteLine(
                    "Chức năng:\n1. Tạo mới\n2. Tìm thông tin\n3. Thay đổi thông tin\n4. Xóa\n5. Hướng dẫn sử dụng\n6. Thoát");
                var userchoose = stringmodifine.Inputnumber("chức năng", 1, 6);
                switch (userchoose)
                {
                    case 1: //nhap hang
                        Function.AddNewPackaged(ref warehouse);
                        break;
                    case 2: // tim hang
                        Function.FindItems(warehouse);
                        break;
                    case 3: //Thay doi Thong tin hang
                        Function.ChangeInf(ref warehouse);
                        break;

                    case 4:
                        Function.RemoveItem(ref warehouse);
                        break;
                    case 5:
                        Print.MidSeparate();
                        Print.Instruction();
                        break;
                    case 6:
                        show = false;
                        Print.EndSeparate();
                        Print.EndSeparate();
                        Console.WriteLine("Kết thúc phần mềm - Cảm ơn đã sử dụng".ToUpper());
                        Print.FirstNote();
                        Print.EndSeparate();
                        break;
                }
            }
        }
    }
}