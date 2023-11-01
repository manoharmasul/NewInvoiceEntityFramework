using System.ComponentModel.DataAnnotations;

namespace NewDemoInvoiceApplication.Model
{
    public class Item
    {
        //Item_code, Item_name, item_category, Item_unitprice, Item_discountInPer
        [Key]
        public int item_code { get; set; }
        public string item_name { get; set; }
        public string item_catagory { get; set; }
        public double item_uprice { get; set; }
        public double item_discountInPer { get; set; }
    }


}
