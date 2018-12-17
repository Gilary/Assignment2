using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment2.Data;
using Assignment2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment2.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly Context _context;

        public UserController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public List<User> Get()
        {
            return _context.Users.ToList();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}