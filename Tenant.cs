namespace DataInvoiceManager.API.Core.Models
{
    public class Tenant : Base
    {
        public string TenantName { get; set; }
        public Status Status { get; set; }
    }
}
