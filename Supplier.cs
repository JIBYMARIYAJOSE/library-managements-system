namespace DataInvoiceManager.API.Core.Models
{
    public class Supplier : Base
    {
        public string CompanyName { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string PrimaryAddress { get; set; }
        public string? SecondaryAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
