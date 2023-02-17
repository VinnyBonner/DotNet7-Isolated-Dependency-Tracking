using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using static Grpc.Core.Metadata;


namespace Dotnet_Isolated_Repro
{
    public class Function1
    {
        private readonly ILogger _logger;       

        public Function1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
        }
        private static HttpClient httpClient = new HttpClient();

        [Function(nameof(Function1))]
        public HttpResponseData Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req,
            FunctionContext executionContext)
        {

            try
            {
                _logger.LogInformation("C# HTTP trigger function processed a request.");
                
                var res = httpClient.GetAsync("https://google.com").Result;               
                
                _logger.LogInformation("Response: " + res.StatusCode);

                var response = req.CreateResponse(HttpStatusCode.OK);
                response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

                var body = res.Content.ReadAsStringAsync().Result;

                response.WriteString(body);
                

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError("Error: " + ex.ToString());
                var response = req.CreateResponse(HttpStatusCode.BadRequest);
                response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
                response.WriteString(ex.ToString());

                return response;
            }
        }
    }
}
