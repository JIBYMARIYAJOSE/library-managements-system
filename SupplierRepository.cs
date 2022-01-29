using DataInvoiceManager.API.Core.Interfaces;
using DataInvoiceManager.API.Core.Models;

namespace DataInvoiceManager.API.Infrastructure
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly IConfiguration _config;
        private readonly IDataRepo _repo;
        public SupplierRepository(IConfiguration config, IDataRepo repo)
        {
            _config = config;
            _repo = repo;
        }
        public async Task<IEnumerable<Supplier>> getList(int limit)
        {
            return await _repo.getSupplierList(limit);
        }
    }
}
