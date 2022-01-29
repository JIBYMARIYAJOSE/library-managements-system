using DataInvoiceManager.API.Core.Interfaces;
using DataInvoiceManager.API.Core.Models;
using DataInvoiceManager.API.Data.Snowflake.Helpers;
using Microsoft.Extensions.Configuration;

namespace DataInvoiceManager.API.Snowflake.Repo
{
    public class DataRepo : IDataRepo
    {
        private readonly IConfiguration _config;
        public DataRepo(IConfiguration config)
        {
            _config = config;
        }

        public async Task<IEnumerable<Supplier>> getSupplierList(int limit)
        {
            var snowflakeClient = await Database.client(_config);
 
           return await snowflakeClient.QueryAsync<Supplier>($"SELECT * FROM SUPPLIERS limit {limit}");
        }

        public async Task<IEnumerable<Invoice>> getInvoiceList(int? supplierId, int limit)
        {
            var snowflakeClient = await Database.client(_config);
 
            string sqlQuery = $"SELECT * FROM Invoices where supplierId = {supplierId } limit {limit}";

            if (!supplierId.HasValue)
                sqlQuery = "SELECT * FROM Invoices limit {limit}";

            return await snowflakeClient.QueryAsync<Invoice>(sqlQuery);
            
        }

  
    }
}