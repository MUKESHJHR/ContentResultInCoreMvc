using ContentResultInCoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text.Json.Serialization;

namespace ContentResultInCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ContentResult Index()
        {
            //Using ContentResult Helper Method
            //string plainText = "This is plain content text";
            //return Content(plainText, "plain/text");

            //return new ContentResult
            //{
            //    ContentType = "plain/text",
            //    Content = plainText
            //};

            //Returning HTML
            //string htmlText = "<html><body><h1>Hello, Welcome to Dot Net Tutorials</h1></body></html>";
            //return Content(htmlText, "text/html");

            //Returning JSON
            //var jsonData = new { Name = "Mukesh", Age = 34, Occupation = "Software Developer" };
            //return Content(JsonConvert.SerializeObject(jsonData), "application/json");

            //Using String Directly
            //string content = "This is simple string";
            //return Content(content);

            //Customizing Content
            string customContent = "This is simple custom content with specific settings";
            return new ContentResult
            {
                Content = customContent,
                ContentType = "text/plain",
                StatusCode = 200 //OK Status code
            };
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}