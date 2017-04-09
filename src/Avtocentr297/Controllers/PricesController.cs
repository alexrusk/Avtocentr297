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
            ViewData["Title"] = "����������� ����������";
            return View();
        }

        public IActionResult TechService()
        {
            ViewData["Title"] = "����������� ������������";
            return View();
        }

        public IActionResult Repair()
        {
            ViewData["Title"] = "������";
            return View();
        }

        public IActionResult AutoElectricity()
        {
            ViewData["Title"] = "������ �������������";
            return View();
        }

        public IActionResult RazvalShozdenie()
        {
            ViewData["Title"] = "������������ ������-���������";
            return View();
        }

        public IActionResult Conditioning()
        {
            ViewData["Title"] = "������� ����������������� �������";
            return View();
        }

    }
}