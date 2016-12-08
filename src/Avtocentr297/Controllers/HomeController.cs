using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Avtocentr297.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Информационная страница.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Свяжитесь с нами:";
            ViewData["Address"] = "Наш адрес:";
            ViewData["Working"] = "Мы работаем:";
            ViewData["Phones"] = "Телефоны:";
            ViewData["Email"] = "Email:";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
