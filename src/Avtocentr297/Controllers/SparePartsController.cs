using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Avtocentr297.Controllers
{
    public class SparePartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TITAN()
        {
            ViewData["Title"] = "TITAN";
            ViewData["Info"] = "����� �� ������ � ������. ���� ������ � �������. ���� ���� ��� ������. ������������ � ��������";
            return View();
        }


    }
}