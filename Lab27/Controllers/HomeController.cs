using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Lab27.Models;
using System.Net.Http;
using Newtonsoft.Json;
using RestSharp;

namespace Lab27.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Forecast(string latitude, string longitude)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://forecast.weather.gov");
            client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; GrandCircus/1.0)");
            var response = await client.GetStringAsync("MapClick.php?lat=" + latitude + "&lon=" + longitude+ "&FcstType=json");
            var result = JsonConvert.DeserializeObject<Weather>(response);
            return View(result);
        }
        public IActionResult RestSharp()
        {
            var restClient = new RestClient("http://forecast.weather.gov");
            var request = new RestRequest("MapClick.php?lat=38.4247341&lon=-86.9624086&FcstType=json");
            request.AddHeader("Accept", "application/json");
            var response = restClient.Get(request);
            var result = JsonConvert.DeserializeObject<Weather>(response.Content);
            
            return View();
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
