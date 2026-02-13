using invoice.Core.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Invoice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvoicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // ✅ Get All Invoices
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var invoices = await _unitOfWork.Invoices.GetAllAsync();
            return Ok(invoices);
        }

        // ✅ Get Invoice By Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var invoice = await _unitOfWork.Invoices.GetByIdAsync(id);

            if (invoice == null)
                return NotFound();

            return Ok(invoice);
        }

        // ✅ Create Invoice
        [HttpPost]
        public async Task<IActionResult> Create(CreateInvoiceRequest request)
        {
            var customer = await _unitOfWork.Customers.GetByIdAsync(request.CustomerId);
            if (customer == null)
                return BadRequest("Customer not found");

            var invoice = new Invoice(request.CustomerId, Guid.NewGuid().ToString());

            foreach (var item in request.Items)
            {
                var product = await _unitOfWork.Products.GetByIdAsync(item.ProductId);
                if (product == null)
                    return BadRequest($"Product {item.ProductId} not found");

                invoice.AddItem(product.Id, product.Name, product.Price, item.Quantity);
            }

            await _unitOfWork.Invoices.AddAsync(invoice);
            await _unitOfWork.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = invoice.Id }, invoice);
        }

        // ✅ Update Invoice
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, UpdateInvoiceRequest request)
        {
            var invoice = await _unitOfWork.Invoices.GetByIdAsync(id);
            if (invoice == null)
                return NotFound();

            foreach (var item in request.Items)
            {
                invoice.UpdateItem(item.ItemId, item.Quantity);
            }

            _unitOfWork.Invoices.Update(invoice);
            await _unitOfWork.SaveChangesAsync();

            return Ok(invoice);
        }

        // ✅ Delete Invoice
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var invoice = await _unitOfWork.Invoices.GetByIdAsync(id);
            if (invoice == null)
                return NotFound();

            _unitOfWork.Invoices.Delete(invoice);
            await _unitOfWork.SaveChangesAsync();

            return NoContent();
        }
    }
}
