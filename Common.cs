using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Microsoft.Extensions.Configuration;

namespace DataInvoiceManager.API.Core.Helpers
{
    public class Common
    {
        public static String getConfigValue(IConfiguration _config, String key)
        {
            return _config[key];
        }
        public static async Task<AuthenticationResult> getBearerToken(IConfiguration _config, ClientCredential clientSecretCredential)
        {
            var authContext = new AuthenticationContext(Common.getConfigValue(_config, "AccessLogin") + Common.getConfigValue(_config, "TenantId"), false);
            var token = await authContext.AcquireTokenAsync(Common.getConfigValue(_config, "ObjectId"), clientSecretCredential);
            return token;
        }

        public static int getLimit(int? limit, IConfiguration _config)
        {
            if (!limit.HasValue)
            {
                limit = int.Parse(Common.getConfigValue(_config, "DefaultPageSize"));
            }

            return (int)limit;
        }

        public static async Task<HttpClient> getClient(IConfiguration _config)
        {
            string clientId = Common.getConfigValue(_config, "ClientId");
            string clientSecret = Common.getConfigValue(_config, "ClientSecret");
            string tenantId = Common.getConfigValue(_config, "TenantId");
            
            var credentials = new ClientCredential(clientId, clientSecret);
            var token = await Common.getBearerToken(_config, credentials);

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token.AccessToken);
 
            return client;
        }
    }
}
