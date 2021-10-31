using System;

namespace ManageStore
{
    internal class Program
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            // Console.OutputEncoding = Encoding.UTF8;
            // Console.InputEncoding = Encoding.UTF8;
            // Console.WriteLine();
            
            // test create data
            // Console.Clear();
            // Print.FirstNote();
            // Store warehouse = new Store();
            // Function.CreateFirstData(ref warehouse);
            // Print.PrintTable(warehouse,true);
            // Function.ManualAddData(ref warehouse,2);
            // Console.Clear(); 
            // Print.PrintTable(warehouse,false);
            // bool show = true;
            // while (show)
            // {
            //     Function.FindItems(warehouse);
            //     show = Stringmodifine.Inputyn("Bạn có muốn tìm giá trị khác không?");
            // }
            
            Console.Write(Function.Findvalue(Console.ReadLine(),Console.ReadLine(),true));
            
    


            // Console.WriteLine("so item xoa");
            // int qty = int.Parse(Console.ReadLine()!);
            // string[] idremove = new string[qty];
            // for (int i = 0; i < qty; i++)
            // {
            //     Console.WriteLine($"ID thu {i+1}");
            //     idremove[i] = Console.ReadLine()!.ToUpper();
            // }
            //
            //
            //
            // Function.RemoveItem(ref warehouse.ItemsList, idremove);
            // Console.WriteLine("sau khi remove");
            // Function.PrintTable(warehouse,false);
            
            // string[] newlable = warehouse.Label;
            // Stringmodifine.PrintStringArray(newlable);
            // Console.WriteLine("nhap gia tri can xoa");
            // Function.Removestring(ref newlable,Console.ReadLine());
            // Stringmodifine.PrintStringArray(newlable);
            //




        }
    }
}