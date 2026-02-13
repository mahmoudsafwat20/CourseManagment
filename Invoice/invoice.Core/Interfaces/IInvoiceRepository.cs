using invoice.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice.Core.IRepository
{
    public interface IInvoiceRepository
    {
        Task<Invoicee> GetByIdAsync(Guid id);
        Task<List<Invoicee>> GetAllAsync();
        Task AddAsync(Invoicee invoice);
        void Update(Invoicee invoice);
        void Delete(Invoicee invoice);
    }
}
