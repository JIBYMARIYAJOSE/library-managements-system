namespace DataInvoiceManager.API.Core.Models
{
    public class InvoiceItems
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public string InvoiceId { get; set; }
        public string? ProductCode { get; set; }
        public string? Quantity { get; set; }
        public string? TotalAmount { get; set; }
        public string? Unit { get; set; }
        public string? UnitPrice { get; set; }

    }
}
