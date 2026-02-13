using invoice.Core.IRepository;
using invoice.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoice.EF.Services
{
    public class InvoiceRepository : InvoiceRepository
    {
        private readonly ApplicationDbContext _context;

        public InvoiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Invoicee invoice)
        {
            await _context.Invoices.AddAsync(invoice);
        }

        public void Delete(Invoicee invoice)
        {
            _context.Invoices.Remove(invoice);
        }

        public async Task<List<Invoicee>> GetAllAsync()
        {
            return await _context.Invoices
                .Include(i => i.Items)
                .ToListAsync();
        }

        public async Task<Invoicee> GetByIdAsync(Guid id)
        {
            return await _context.Invoices
                .Include(i => i.Items)
                .FirstOrDefaultAsync(i => i.Id == id);
        }

        public void Update(Invoicee invoice)
        {
            _context.Invoices.Update(invoice);
        }
    }
}
