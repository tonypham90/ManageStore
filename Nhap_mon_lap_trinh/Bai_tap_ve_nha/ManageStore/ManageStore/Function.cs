using System;

namespace ManageStore
{
    public class Function
    {
        public static void PrintTable(store table)
        {
            Stringmodifine.HeaderTable();
            foreach (var item in table.Itemslist)
            {
                Stringmodifine.printItem(item);
            }
        }
    }
}