using DataInvoiceManager.API.Core.Models;
using Microsoft.AspNetCore.Mvc;
using DataInvoiceManager.API.Core.Helpers;
using DataInvoiceManager.API.Core.Interfaces;

namespace DataInvoiceManager.API.Controllers
{

    

    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {

        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly ISupplierRepository _supplierRepo;
        public SuppliersController(IWebHostEnvironment env, IConfiguration config, ISupplierRepository supplierRepo)
        {
            _env = env;
            _config = config;
            _supplierRepo = supplierRepo;
        }

        [HttpGet("getList")]
        public async Task<IEnumerable<Supplier>> getList([FromQuery] int? limit)
        {
            return await _supplierRepo.getList(Common.getLimit(limit, _config));
        }
    }
}
