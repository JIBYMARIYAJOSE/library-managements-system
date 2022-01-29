using DataInvoiceManager.API.Core.Interfaces;
using DataInvoiceManager.API.Core.Models;

namespace DataInvoiceManager.API.Infrastructure
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly IConfiguration _config;
        private readonly IDataRepo _repo;
        public InvoiceRepository(IConfiguration config, IDataRepo repo)
        {
            _config = config;
            _repo = repo;
        }
        public async Task<IEnumerable<Invoice>> getList(int? supplierId, int limit)
        {
            return await _repo.getInvoiceList(supplierId, limit);
        }
         
    }
}
