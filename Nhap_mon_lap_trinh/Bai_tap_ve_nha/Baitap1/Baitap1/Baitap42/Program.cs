using System;

namespace Baitap42
{
    class Program
    {
        // ReSharper disable once UnusedParameter.Local
        static void Main(string[] args)
        {
            Console.WriteLine("Bài 42: Cho n là số nguyên dương. Hãy tìm giá trị nguyên dương k lớn nhất sao cho S(k)  < n. Trong đó chuỗi k được định nghĩa như sau: S(k) = 1 + 2 + 3 + … + k");
            Console.WriteLine("Nhap gia tri n");
            int n = int.Parse(Console.ReadLine()!);
            int i=0,result = 0,check=0;
            while (i < n)
            {
                i++;
                check += i;
                if (check<n)
                {
                    result = i;
                }
            }
            Console.WriteLine($"Kết quả số K lớn nhất là {result}");
        }
    }
}