// ReSharper disable once RedundantUsingDirective
using System;

namespace ManageStore
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Item a;
            Stringmodifine.HeaderTable();
            a = Itemmodifine.InputiItemtem("Nhap item");
            Stringmodifine.PrintDate(a.Exp);
            Console.Write(Stringmodifine.PrintDate(a.Exp));
        }
    }
}