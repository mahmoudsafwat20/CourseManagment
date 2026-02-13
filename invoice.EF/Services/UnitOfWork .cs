using invoice.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice.EF.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IInvoiceRepository Invoices { get; }
        public ICustomerRepository Customers { get; }
        public IProductRepository Products { get; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Invoices = new InvoiceRepository(context);
            Customers = new CustomerRepository(context);
            Products = new ProductRepository(context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
