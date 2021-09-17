using System;

namespace Bai_tap_mang_v2
{
    public class practice_source
    {
        public static void bai122()
        {
            Console.WriteLine("Tim gia tri so thuc lon nhat cua mang");
            var array = array_basic.double_array(true);
            manipulate.print_DbArray(array); /*in chuoi*/
            manipulate.double_max(array);
        }

        public static void bai123()
        {
            Console.WriteLine("Bài 123: Viết hàm tìm 1 vị trí mà giá trị tại vị trí đó là giá trị nhỏ nhất trong mảng 1 chiều các số nguyên");/*De bai*/
            array_basic.int_array(true);
            
        }
    }
}