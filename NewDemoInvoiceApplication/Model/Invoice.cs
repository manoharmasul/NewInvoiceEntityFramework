using System.ComponentModel.DataAnnotations;

namespace NewDemoInvoiceApplication.Model
{
    public class Invoice
    {
        //Invoice_no, Invoice_Datetime, Invoice_customername, Invoice_customermno, Invoice_paymentmode
        [Key]
        public int InvoieNo { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public string Invoice_CustomerName { get; set; }
        public string Invoice_CustomerNo { get; set; }
        public string Inovice_PaymentMode { get; set; }
    }


}
