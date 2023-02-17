using System.Net;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace Dotnet_Isolated_Repro
{
    public class Function2
    {
        private readonly ILogger _logger;

        public Function2(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function2>();
        }
        private static HttpClient httpClient = new HttpClient();

        [Function(nameof(Function2))]
        public async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            try
            {
                // Get the connection string from app settings and use it to create a connection.
                var str = Environment.GetEnvironmentVariable("sqlConnStr");
                using (SqlConnection conn = new SqlConnection(str))
                {
                    conn.Open();
                    var text = "UPDATE SalesLT.SalesOrderHeader SET [ModifiedDate] = GetDate();";

                    using (SqlCommand cmd = new SqlCommand(text, conn))
                    {
                        // Execute the command and log the # rows affected.
                        var rows = await cmd.ExecuteNonQueryAsync();
                        _logger.LogInformation($"{rows} rows were updated");
                        response.WriteString($"{rows} rows were updated");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError("Error: " + ex.ToString());
                
                response = req.CreateResponse(HttpStatusCode.BadRequest);                
                response.WriteString(ex.ToString());
            }

            return response;
        }
    }
}
