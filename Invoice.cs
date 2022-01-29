

namespace DataInvoiceManager.API.Core.Models
{
    public class Invoice : Base
    {
        public string? InvoiceId { get; set; }
        public string? PurchaseOrder { get; set; }
        public string? InvoiceTotal { get; set; }
        public string? SubTotal { get; set; }
        public string? TotalTax { get; set; }
        public string? InvoiceDate { get; set; }
        public string? DueDate { get; set; }
        public string? CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? BillingAddress { get; set; }
        public string? BillingAddressRecipient { get; set; }
        public string? ShippingAddress { get; set; }
        public string? ShippingAddressRecipient { get; set; }
        public string? SupplierId { get; set; }
        public string? SupplierName { get; set; }
        public string? SupplierAddress { get; set; }
        public string? SupplierAddressRecipient { get; set; }
        public string? Status { get; set; }
    }
}
