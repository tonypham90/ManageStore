﻿using System;

namespace bai20
{
    class Program
    {
        // ReSharper disable once IdentifierTypo
        static int Kiemtrauoc(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (n%i == 0 && i!=1)
                {
                    Console.WriteLine($"{i}");
                }
            }

            return 0;
        }

        static bool Songuyento(int n)
        {
            bool check = true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    check = false;
                    break;
                }
            }
            return check;
        }
        static void Main(string[] args)
        {
            Console.Write("tong cac so nguyen to cua n = ");
            int n = int.Parse(Console.ReadLine());
            var total = 0;
            for (int i = 1; i < n; i++)
            {
                bool a = Songuyento(i);
                if (a)
                { 
                    Console.WriteLine($"là số {i} nguyên tố");
                    total += i;
                }
            }
            Console.WriteLine($"Tong so nguyen to la {total}");
        }
    }
}