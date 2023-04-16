﻿using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["message"] = "Hello " + name;
            ViewData["numTimes"] = numTimes;
            return View();
        }
    }
}
