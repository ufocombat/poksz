using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using poksz.Models;

namespace poksz.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<ItemClass> items;
        public static List<UserClass> users;

        public HomeController(ILogger<HomeController> logger)
        {
            users = users??new List<UserClass>();

            if (items == null)
            {
                items = new List<ItemClass>();

                items.Add(new ItemClass("Молоко", "/img/1.jpg", 55));
                items.Add(new ItemClass("Мед", "/img/2.png", 100));
                items.Add(new ItemClass("Печенье", "/img/3.jpg", 55));

                items.Add(new ItemClass("Молоко", "/img/1.jpg", 55));
                items.Add(new ItemClass("Мед", "/img/2.png", 100));
                items.Add(new ItemClass("Печенье", "/img/3.jpg", 55));
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Items()
        {
            ViewBag.items = items;
            return View();
        }

        public IActionResult Users()
        {
            ViewBag.users = users;
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reg(String email)
        {
            UserClass u = new UserClass();
            u.email = email;
            users.Add(u);
            return Ok();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
