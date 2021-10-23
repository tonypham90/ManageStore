using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ManageStore
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Store warehouse = new Store();
            warehouse.ItemsList = new List<Item>();
            for (int i = 0; i < 10; i++)
            {
                string text = $"Nhap du lieu thu {i}";
                warehouse.ItemsList.Add(Function.InputItem(text, warehouse,true));
            }
            Function.PrintTable(warehouse);

            warehouse.ItemsList.Add(item: Function.InputItem("moi", warehouse,true));

            Function.PrintTable(warehouse);

        }
    }
}