﻿using System;
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
        public List<ItemClass> items = new List<ItemClass>();

        public HomeController(ILogger<HomeController> logger)
        {
            items.Add(new ItemClass("Молоко", "/img/1.jpg",55));
            items.Add(new ItemClass("Мед", "/img/2.png",100));
            items.Add(new ItemClass("Печенье", "/img/3.jpg",55));

            items.Add(new ItemClass("Молоко", "/img/1.jpg", 55));
            items.Add(new ItemClass("Мед", "/img/2.png", 100));
            items.Add(new ItemClass("Печенье", "/img/3.jpg", 55));

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
