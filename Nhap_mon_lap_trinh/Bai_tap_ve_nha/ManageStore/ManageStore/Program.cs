using System;
using System.Text;

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
            Store warehouse = new Store();
            Function.CreateFirstData(ref warehouse);
            Function.PrintTable(warehouse,true);
            Function.adddata(ref warehouse,2);
            Function.PrintTable(warehouse,false);

        }
    }
}