using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace ReverseStringFunction
{
    public static class ReverseString
    {
        [FunctionName(nameof(ReverseString))]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            var text = req.Query["text"].FirstOrDefault();

            var responseText = string.IsNullOrWhiteSpace(text)
                ? "Please add text as a query parameter with some text to be reversed"
                : new string(text.Reverse().ToArray());

            return new OkObjectResult(responseText);
        }
    }
}
