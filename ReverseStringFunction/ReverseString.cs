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

        var text = req.Query["text"];

        string responseText;
        if (text.Count > 0 && string.IsNullOrWhiteSpace(text[0]))
        {
            var chars = new char[text[0].Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = text[0][chars.Length - i - 1];
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
