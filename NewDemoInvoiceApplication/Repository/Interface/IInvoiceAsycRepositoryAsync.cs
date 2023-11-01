using NewDemoInvoiceApplication.Model;

namespace NewDemoInvoiceApplication.Repository.Interface
{
    public interface IInvoiceAsycRepositoryAsync
    {
        Task<int> AddInvoiceData(InvoiceItem item);
        Task<int> UpdateInvoiceData(InvoiceItem item);
        Task<int> DeleteInvoiceData(int Invoice_no);
        Task<List<InvoiceItem>> GetInvoiceData();
        Task<InvoiceItem> GetInvoiceDataById(int Invoice_no);
    }
}
