using System;
using System.Collections.Generic;
using System.Text;

namespace ManageStore
{
    internal class Program
    {
        // ReSharper disable once UnusedParameter.Local
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine();
            var warehouse = new Store();
            warehouse.ItemsList = new Item[];
            for (var i = 0; i < 10; i++)
            {
                var text = $"Nhap du lieu thu {i}";
                warehouse.ItemsList.Add(Function.InputItem(text, warehouse, true));
            }
            
        }
    }
}