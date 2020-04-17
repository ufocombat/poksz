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
        public List<ItemClass> items;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            items = new List<ItemClass>();

            var item1 = new ItemClass();
            item1.Description = "Молоко";

            var item2 = new ItemClass();
            item2.Description = "Мед";

            var item3 = new ItemClass();
            item3.Description = "Печенье";


            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
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
