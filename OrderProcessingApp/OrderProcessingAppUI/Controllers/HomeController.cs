using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace OrderProcessingAppUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClient = httpClientFactory.CreateClient();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(IFormCollection form)
        {
            var selection = form["PaymentType"].FirstOrDefault();

            var httpRequest = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("http://localhost:57922/payment"),
                Content = new StringContent(JsonConvert.SerializeObject(new {SelectedItem = selection}), Encoding.UTF8,
                    "application/json")
            };

            var response = _httpClient.SendAsync(httpRequest).Result;

            if (response.IsSuccessStatusCode)
                ViewBag.Result = response.Content.ReadAsStringAsync().Result;

            return View();
        }
    }
}