using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Assignment2.Data;
using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Helper;
using MVC.Models;
using Newtonsoft.Json;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }
        API _api = new API();

        public IActionResult Index()
        {
            return View();
        }

        //public async Task<IActionResult> Usar()
        //{
        //    List<User> user = new List<User>();
        //    HttpClient client = _api.Initial();
        //    HttpResponseMessage resu = await client.GetAsync("api/Users");
        //    if (resu.IsSuccessStatusCode)
        //    {
        //        var result = resu.Content.ReadAsStringAsync().Result;
        //        user = JsonConvert.DeserializeObject<List<User>>(result);
        //    }
        //    return View(user);
        //}

        //public async Task<IActionResult> Skall()
        //{
        //    List<Skill> skill = new List<Skill>();
        //    HttpClient client = _api.Initial();
        //    HttpResponseMessage resu = await client.GetAsync("api/Skills");
        //    if (resu.IsSuccessStatusCode)
        //    {
        //        var result = resu.Content.ReadAsStringAsync().Result;
        //        skill = JsonConvert.DeserializeObject<List<Skill>>(result);
        //    }
        //    return View(skill);
        //}

        //public async Task<IActionResult> Cors()
        //{
        //    List<Car> car = new List<Car>();
        //    HttpClient client = _api.Initial();
        //    HttpResponseMessage resu = await client.GetAsync("api/Cars");
        //    if (resu.IsSuccessStatusCode)
        //    {
        //        var result = resu.Content.ReadAsStringAsync().Result;
        //        car= JsonConvert.DeserializeObject<List<Car>>(result);
        //    }
        //    return View(car);
        //    //return View(await _context.Cars.ToListAsync());
        //}

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
