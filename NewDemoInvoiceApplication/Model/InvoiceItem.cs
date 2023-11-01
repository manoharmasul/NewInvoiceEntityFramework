using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewDemoInvoiceApplication.Model
{
    [Table("tblInvoiceItem")]

    public class InvoiceItem
    {
        //Id	Inovice_NO	Intem_Code	Item_Qty	Item_UnitPrice	Intem_Discount	Intem_Amount	Item_AmountPaid
        [Key]
        public int Id { get; set; }
        public int Inovice_NO { get; set; }
        public int Intem_Code { get; set; }
        public int Item_Qty { get; set; }
        public decimal Item_UnitPrice { get; set; }
        public decimal Intem_Discount { get; set; }
        public decimal Intem_Amount { get; set; }
        public decimal Item_AmountPaid { get; set; }
    }
}
