using DataInvoiceManager.API.Core.Helpers;
using Microsoft.Extensions.Configuration;
using Snowflake.Client;


namespace DataInvoiceManager.API.Data.Snowflake.Helpers
{
    public static class Database
    {
        public static SnowflakeClient getConnectionObject(IConfiguration _config)
        {
            return new SnowflakeClient(
                            Common.getConfigValue(_config, "DbUser"),
                            Common.getConfigValue(_config, "DbPassword"),
                            Common.getConfigValue(_config, "DbAccount"),
                            Common.getConfigValue(_config, "DbRegion")
                            );
            
        }

        public static async Task<string> executeScalar(IConfiguration _config, SnowflakeClient snowflakeClient, string key)
        {
            return await snowflakeClient.ExecuteScalarAsync("USE " + Common.getConfigValue(_config, key) + ";");
        }

        public static async Task setContext(this SnowflakeClient client, IConfiguration _config)
        {
            await client.ExecuteScalarAsync("USE " + Common.getConfigValue(_config, "DbName") + ";");
            await client.ExecuteScalarAsync("use schema " + Common.getConfigValue(_config, "Schema") + ";");
            await client.ExecuteScalarAsync("USE ROLE " + Common.getConfigValue(_config, "Role") + ";");
        }

        public static async Task<SnowflakeClient> client(IConfiguration _config)
        {
           var connection = getConnectionObject(_config);
           await connection.setContext(_config);
           return connection;
        }




    }
}
