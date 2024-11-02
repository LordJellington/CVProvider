using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Ellijim.Demo.CVProvider.Services;

namespace Ellijim.Demo.CVProvider
{
    public class CVRetrieverFunction
    {
        private readonly ICVRetrieverService _cvRetrieverService;

        public CVRetrieverFunction(ICVRetrieverService cvRetrieverService)
        {
            _cvRetrieverService = cvRetrieverService;
        }

        [FunctionName("GetCV")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];
            
            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            var result = _cvRetrieverService.GetCV(name);

            if (result == null)
            {
                return new NotFoundResult();
            } 
            else
            {
                return new OkObjectResult(result);
            }
        }
    }
}
