using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.Helper;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        API _api = new API();

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Usar()
        {
            List<User> user = new List<User>();
            HttpClient client = _api.Initial();
            HttpResponseMessage resu = await client.GetAsync("api/Users");
            if (resu.IsSuccessStatusCode)
            {
                var result = resu.Content.ReadAsStringAsync().Result;
                user = JsonConvert.DeserializeObject<List<User>>(result);
            }
            return View(user);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
