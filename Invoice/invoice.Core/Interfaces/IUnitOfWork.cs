using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice.Core.IRepository
{
    internal interface IUnitOfWork : IDisposable
    {
        IInvoiceRepository Invoices { get; }
        ICustomerRepository Customers { get; }
        IProductRepository Products { get; }

        Task<int> SaveChangesAsync();
    }
}
