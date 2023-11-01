using Microsoft.EntityFrameworkCore;
using NewDemoInvoiceApplication.Context;
using NewDemoInvoiceApplication.Model;
using NewDemoInvoiceApplication.Repository.Interface;

namespace NewDemoInvoiceApplication.Repository
{
    public class InvoiceItemAsyncRepository:IInvoiceAsycRepositoryAsync
    {
        private readonly MyContext context;
        public InvoiceItemAsyncRepository(MyContext context)
        {
            this.context = context;
        }

        public async Task<int> AddInvoiceData(InvoiceItem item)
        {
            var query = context.AddAsync(item);
            var result = await context.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteInvoiceData(int Id)
        {
            var item = await context.InvoiceItem.FindAsync(Id);
            var result = context.Remove(item);
            var ret = await context.SaveChangesAsync();
            return ret;
        }

        public async Task<List<InvoiceItem>> GetInvoiceData()
        {
        
            var query = from item in context.InvoiceItem select item;
            var invoiceitem = await query.ToListAsync();


            return invoiceitem;
        }

        public async Task<InvoiceItem> GetInvoiceDataById(int Id)
        {
            var item = await context.InvoiceItem.FindAsync(Id);
            return item;
        }

        public async Task<int> UpdateInvoiceData(InvoiceItem item)
        {
            // context.Entry(item).State = EntityState.Modified;
            var quefind = await context.InvoiceItem.FindAsync(item.Id);
            // context.InvoiceItem.Update(item);
            quefind.Id=item.Id;
            quefind.Inovice_NO=item.Inovice_NO;
            quefind.Intem_Code = item.Intem_Code;
            quefind.Item_Qty = item.Item_Qty;
            quefind.Item_UnitPrice = item.Item_UnitPrice;
            quefind.Intem_Discount = item.Intem_Discount;
            quefind.Intem_Amount = item.Intem_Amount;
            quefind.Item_AmountPaid = item.Item_AmountPaid;

             var result = context.SaveChanges();
            return result;
        }



    }
}
