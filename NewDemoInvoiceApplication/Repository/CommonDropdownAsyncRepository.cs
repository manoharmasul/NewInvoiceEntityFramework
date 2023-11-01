using Microsoft.EntityFrameworkCore;
using NewDemoInvoiceApplication.Context;
using NewDemoInvoiceApplication.Model;
using NewDemoInvoiceApplication.Repository.Interface;

namespace NewDemoInvoiceApplication.Repository
{
    public class CommonDropdownAsyncRepository : ICommonDropdownAsyncRepository
    {
        private readonly MyContext context;
        public CommonDropdownAsyncRepository(MyContext context)
        {
            this.context = context;
        }

        public async Task<List<Invoice>> GetInvoiceDropdown()
        {
            var query = from item in context.Invoice select item;

            var invoicelist = await query.ToListAsync();

            return invoicelist;
        }

        public async Task<List<Item>> GetItemDropdown()
        {

            var query = from item in context.Item select item;

            var itemlist = await query.ToListAsync();

            return itemlist;
        }
    }
}
