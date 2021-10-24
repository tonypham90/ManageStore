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
            Store warehouse = new Store();
            Function.createfistdata(ref warehouse);
            Function.PrintTable(warehouse);
            
        }
    }
}