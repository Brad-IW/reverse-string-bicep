using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;

namespace ReverseStringFunction;

public static class ReverseString
{
    [FunctionName(nameof(ReverseString))]
    public static IActionResult Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
        ILogger log)
    {
        log.LogInformation("C# HTTP trigger function processed a request.");

        var textQuery = req.Query["text"];
        
        string responseText;
        if (textQuery.Count > 0 && !string.IsNullOrWhiteSpace(textQuery[0]))
        {
            var text = textQuery[0];
            var chars = new char[text.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = text[chars.Length - i - 1];
            }
            responseText = new string(chars);
        }
        else
        {
            responseText = "Please add text as a query parameter with some text to be reversed";
        }

        return new OkObjectResult(responseText);
    }
}
