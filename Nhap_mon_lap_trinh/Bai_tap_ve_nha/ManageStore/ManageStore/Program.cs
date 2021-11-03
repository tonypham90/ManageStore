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
            Print.PrintTable(warehouse,true);
            ArrayManipulate.InsertMultiItem(ref warehouse,2);
            Console.Clear(); 
            Print.PrintTable(warehouse,false);
            bool show = true;
            while (show)
            {
                Function.FindItems(warehouse);
                show = stringmodifine.Inputyn("Bạn có muốn tìm giá trị khác không?");
            }
            
            //Console.Write(Check.Findvalue(Console.ReadLine(),Console.ReadLine(),true));
            
    


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
            // stringmodifine.PrintStringArray(newlable);
            // Console.WriteLine("nhap gia tri can xoa");
            // Function.Removestring(ref newlable,Console.ReadLine());
            // stringmodifine.PrintStringArray(newlable);
            //




        }
    }
}