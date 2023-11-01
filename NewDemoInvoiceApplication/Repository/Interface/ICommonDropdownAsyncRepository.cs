using NewDemoInvoiceApplication.Model;

namespace NewDemoInvoiceApplication.Repository.Interface
{
    public interface ICommonDropdownAsyncRepository
    {
        Task<List<Item>> GetItemDropdown();
        Task<List<Invoice>> GetInvoiceDropdown();
    }
}
