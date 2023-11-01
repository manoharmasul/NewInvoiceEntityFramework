using Microsoft.EntityFrameworkCore;
using NewDemoInvoiceApplication.Model;

namespace NewDemoInvoiceApplication.Context
{
    public class MyContext : DbContext
    {
      
            public MyContext(DbContextOptions<MyContext> options) : base(options)
            {
            }
        public DbSet<Item> Item { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }
    }
}
