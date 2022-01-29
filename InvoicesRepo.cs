using Microsoft.AspNetCore.Mvc;
using DataInvoiceManager.API.Core.Models;
using DataInvoiceManager.API.Core.Helpers;
using DataInvoiceManager.API.Core.Interfaces;

namespace DataInvoiceManager.API.Snowflake.Repo

{
    public class InvoiceRepo
    {
        public InvoiceRepo(IConfiguration config)
        {
            _config = config;
        }
        public async Task<long> StoreAsync()
        {
          
            var snowflakeClient = await Database.client(_config);
            var obj = new Invoice();
            var obj1 = new Invoice();
            var obj2 = new InvoiceItems();
            var obj3 = new InvoiceItems();




            try
            {
                string useRoleResult = await snowflakeClient.ExecuteScalarAsync("USE ROLE ACCOUNTADMIN;");

                var vals = "values (" + obj.InvoiceId + ",'" + obj.PurchaseOrder + ",'" + obj.InvoiceTotal + ",'" + obj.SubTotal + ",'" + obj.TotalTax + ",'" + obj.InvoiceDate + ",'" + obj.DueDate + ",'" + obj.ServiceAddress + ",'" + obj.ServiceStartDate + ",'" + obj.CustomerId + ",'" + obj.CustomerName + ",'" + obj.CustomerAddress + ",'" + obj.RemittanceAddressRecipient + ",'" + obj.RemittanceAddress + ",'" + obj.BillingAddress + ",'" + obj.BillingAddressRecipient + ",'" + obj.ShippingAddress + ",'" + obj.ShippingAddressRecipient + ",'" + obj.VendorName + ",'" + obj.VendorAddress + ",'" + obj.VendorAddressRecipient + ",'" + obj.AmountDue + "')";

                vals += "values(" + obj1.InvoiceId + ", '" + obj1.PurchaseOrder + ",'" + obj1.InvoiceTotal + ", '" + obj1.SubTotal + ",'" + obj1.TotalTax + ", '" + obj1.InvoiceDate + ",'" + obj1.DueDate + ", '" + obj1.ServiceAddress + ",'" + obj1.ServiceStartDate + ", '" + obj1.CustomerId + ",'" + obj1.CustomerName + ", '" + obj1.CustomerAddress + ",'" + obj1.RemittanceAddressRecipient + ", '" + obj1.RemittanceAddress + ",'" + obj1.BillingAddress + ", '" + obj1.BillingAddressRecipient + ",'" + obj1.ShippingAddress + ", '" + obj1.ShippingAddressRecipient + ",'" + obj1.VendorName + ", '" + obj1.VendorAddress + ",'" + obj1.VendorAddressRecipient + ", '" + obj1.AmountDue + "')";

                var values = "values (" + obj2.Description + ",'" + obj2.Id + ",'" + obj2.InvoiceId + ",'" + obj2.ProductCode + ",'" + obj2.Quantity + ",'" + obj2.TotalAmount + ",'" + obj2.Unit + ",'" + obj2.UnitPrice + "')";

                values += "values(" + obj3.Description + ", '" + obj3.Id + ",'" + obj3.InvoiceId + ", '" + obj3.ProductCode + ",'" + obj3.Quantity + ", '" + obj3.TotalAmount + ",'" + obj3.Unit + ", '" + obj3.UnitPrice + "')";


                var sqlstmt = "INSERT INTO KLINEELECTRIC.PUBLIC.INVOICES (InvoiceId,PurchaseOrder,InvoiceTotal,SubTotal,TotalTax,InvoiceDate,DueDate,ServiceAddress,ServiceStartDate,CustomerId,CustomerName,CustomerAddress,RemittanceAddressRecipient,RemittanceAddress,BillingAddress,BillingAddressRecipient,ShippingAddress,ShippingAddressRecipient,VendorName,VendorAddress,VendorAddressRecipient,AmountDue) " + vals;
                var sqlStmt = "INSERT INTO KLINEELECTRIC.PUBLIC.INVOICEITEMS (Description,Id,InvoiceId,ProductCode,Quantity,TotalAmount,Unit,UnitPrice) " + values;
                var results = await snowflakeClient.ExecuteAsync(sqlstmt);
                var result = await snowflakeClient.ExecuteAsync(sqlStmt);
                return results;

            }
            catch (Exception ex)
            {
                throw new Exception("some Isue: " + ex.Message);
            }

        }
    }
}
