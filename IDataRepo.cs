using DataInvoiceManager.API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataInvoiceManager.API.Core.Interfaces
{
    public interface IDataRepo
    {
        Task<IEnumerable<Invoice>> getInvoiceList(int? supplierId, int limit);
        Task<IEnumerable<Supplier>> getSupplierList(int limit);
    
    }
}
