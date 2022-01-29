using System.ComponentModel.DataAnnotations;


namespace  DataInvoiceManager.API.Core.Models
{
{
    public class InvoiceinputParameter
    {  [Required]  public string supplierId { get; set; }
       [Required] public IFormFile files { get; set; }
       [Required]  public string destPrefix { get; set; }
       [Required] public string fileName { get; set; }
        public string compression { get; set; }
       [Required] public string stageName { get; set; }
        
    }
}
