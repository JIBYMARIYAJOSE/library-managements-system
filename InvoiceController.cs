using Microsoft.AspNetCore.Mvc;
using DataInvoiceManager.API.Core.Models;
using DataInvoiceManager.API.Core.Helpers;
using DataInvoiceManager.API.Core.Interfaces;

namespace DataInvoiceManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class InvoiceController : Controller
    {
       

        private readonly IWebHostEnvironment _env;
        private readonly IConfiguration _config;
        private readonly IInvoiceRepository _invoiceRepo;


        public InvoiceController(IWebHostEnvironment env, IConfiguration config, IInvoiceRepository invoiceRepo)
        {
            _env = env;
            _config = config;
            _invoiceRepo = invoiceRepo;
        }

        [HttpGet("getList/{supplierId}")]
        public async Task<IEnumerable<Invoice>> getList(int? supplierId, [FromQuery] int? limit)
        {
            return await _invoiceRepo.getList(supplierId, Common.getLimit(limit, _config));
        }
        
        [HttpGet("GetSnowflake")]
                public async Task<IEnumerable<Invoice>> GetSnowflake([FromQuery] string fileName, string destPrefix, string stageName, string compression)
                {   Invoice invoice = new Invoice();
                    var requestContent = new MultipartFormDataContent();
                    requestContent.Add(new StringContent(fileName), "fileName");
                    requestContent.Add(new StreamContent(file.OpenReadStream()), "files");
                    requestContent.Add(new StringContent(destPrefix), "destPrefix");
                    requestContent.Add(new StringContent(compression), "compression");
                    requestContent.Add(new StringContent(stageName), "stageName");
                    var client = await Common.getClient(_config);
                    string url = Common.getConfigValue(_config, "AzureBaseURL");
                    url = url + "FileUpload";
                    var response = await client.PostAsync(url,requestContent);
                    var payload = JsonSerializer.Deserialize<Invoice>(response);
                    Stream streamToReadFrom = await response.Content.ReadAsStreamAsync();
                    invoice.fileContent = streamToReadFrom;
                    InsertToSnowflake();
                    return invoices;
                }
        [HttpGet("snowflakeInsert")]
        public async Task<long> InsertToSnowflake()
        {
            var repo  = new InvoiceRepo();
            

             return await repo.StoreAsync();
           
        }

        [HttpGet("getInvoiceFile")]
        public async Task<IActionResult> getInvoiceFile([FromQuery] string fileName, string destPrefix, string stageName, string compression)
        {
            var client = await Common.getClient(_config);
            string url = Common.getConfigValue(_config, "AzureBaseURL");
            url = url + "FileDownload";
            client.BaseAddress = new Uri(url);
            var requestContent = new MultipartFormDataContent();

            requestContent.Add(new StringContent(destPrefix), "destPrefix");
            requestContent.Add(new StringContent(fileName), "fileName");
            requestContent.Add(new StringContent(compression), "compression");
            requestContent.Add(new StringContent(stageName), "stageName");

            try
            {
                var response = await client.PostAsync(url, requestContent);

                if (response.IsSuccessStatusCode)
                {
                    return Ok(await response.Content.ReadAsStreamAsync());
                }

                return NotFound(response.StatusCode.ToString());
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
            
        }
           
         [HttpPost("uploadFile")]
        public async Task<IActionResult> uploadFile(IFormCollection data)
        {
            string clientId, clientSecret;
            InvoiceinputParameter invoiceData = new InvoiceinputParameter();
            try
            {
                Stream fileData;
                string compression, destPrefix, supplierId;
                var file = Request.Form.Files[0];
                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
               // invoiceData.supplierId = data["supplierId"];
                  invoiceData.destPrefix = data["supplierId"];
                 invoiceData.compression = Common.getConfigValue(_config, "Compression");
                invoiceData.stageName = Common.getConfigValue(_config, "StageName");
                invoiceData.destPrefix = data["destPrefix"];
                invoiceData.fileName = fileName;
                invoiceData.files = file;
                //string invoicePath = _env.ContentRootPath.ToString();
                var client = await Common.getClient(_config);
                string url = Common.getConfigValue(_config, "AzureBaseURL");
                url = url + "fileUpload";
                client.BaseAddress = new Uri(url);
               var requestContent = new MultipartFormDataContent();
               // requestContent.Add(new StringContent(invoiceData.supplierId), "supplierId");
                requestContent.Add(new StreamContent(invoiceData.files.OpenReadStream()), "file");
                requestContent.Add(new StringContent(invoiceData.destPrefix), "destPrefix");
                requestContent.Add(new StringContent(invoiceData.fileName), "fileName");
                requestContent.Add(new StringContent(invoiceData.compression), "compression");
                requestContent.Add(new StringContent(invoiceData.stageName), "stageName");
                var response = await client.PostAsync(url, requestContent);
                if (response.IsSuccessStatusCode)
                {
                    
                    return Ok(await response.Content.ReadAsStreamAsync());
                }
                return NotFound(response.StatusCode.ToString());

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }


        }
    }



}
