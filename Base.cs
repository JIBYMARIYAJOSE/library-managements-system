namespace DataInvoiceManager.API.Core.Models
{
    public class Base
    {
        public int Id { get; set; }
        //public Tenant TenantId { get; set; }
        // public User CreatedBy { get; set; }

        public DateTime? DeletedAt { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
