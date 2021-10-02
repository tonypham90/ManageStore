using System;

namespace Bai_tap_mang_v2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Giai bai tap mang 1 chieu");
            Console.Write("Bai tap so: ");
            var input = Console.ReadLine()!;
            switch (input)
            {
                case "122":
                    practice_source.bai122();
                    break;
                case "123":
                    practice_source.bai123();
                    break;
                case "311":
                    practice_source.bai311();
                    break;
                case "313":
                    practice_source.bai312();
                    break;
                case "315":
                    practice_source.bai315();
                    break;
            }
        }
    }
}