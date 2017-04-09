using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Avtocentr297.Controllers
{
    public class PricesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Diagnostics()
        {
            ViewData["Title"] = "Диагностика автомобиля";
            return View();
        }

        public IActionResult TechService()
        {
            ViewData["Title"] = "Техническое обслуживание";
            return View();
        }

        public IActionResult Repair()
        {
            ViewData["Title"] = "Ремонт";
            return View();
        }

        public IActionResult AutoElectricity()
        {
            ViewData["Title"] = "Услуги автоэлектрика";
            return View();
        }

        public IActionResult RazvalShozdenie()
        {
            ViewData["Title"] = "Компьютерный развал-схождение";
            return View();
        }

        public IActionResult Conditioning()
        {
            ViewData["Title"] = "Система кондиционирования воздуха";
            return View();
        }

    }
}