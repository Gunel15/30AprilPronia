﻿using Microsoft.AspNetCore.Mvc;

namespace _30AprilClassTaskPronia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
