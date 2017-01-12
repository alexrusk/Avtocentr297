﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Avtocentr297.Controllers
{
    public class ServiceController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Diagnostics()
        {
            ViewData["Title"] = "Диагностика автомобиля";
            ViewData["Diag1"] = "Диагностика подвески";
            ViewData["CompDiag"] = "Компьютерная диагностика";
            return View();
        }

        public IActionResult TechService()
        {
            ViewData["Title"] = "Техническое обслуживание";
            return View();
        }
    }
}