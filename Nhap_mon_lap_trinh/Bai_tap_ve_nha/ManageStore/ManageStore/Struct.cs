using System.Collections.Generic;

namespace ManageStore
{
    public struct Item
    {
        public string Id; /*Mã sản phẩm*/
        public string Name; /*Tên sản phẩm*/
        public int Qty; /*So luong san pham*/
        public Date Exp; /*Hạn sử dụng*/
        public Date Mfg; /*Năm sản xuất*/
        public string Com; /*Cty San xuat*/
        public string Type; /*Loai Hang*/
    }

    public struct Store
    {
        public List<Item> ItemsList;
        public List<string> Label;
    }
    public struct Date
    {
        public int Month;
        public int Year;
    }
}