﻿using Microsoft.AspNetCore.Mvc;

namespace Restaurator.Controllers
{
    public class CoffeeStationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}