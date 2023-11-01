namespace NewDemoInvoiceApplication.Model
{
    public class BaseResponseModel
    {
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public Object ResponseData { get; set; }
    }
}
