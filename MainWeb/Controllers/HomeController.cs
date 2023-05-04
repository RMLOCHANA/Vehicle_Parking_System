using MainWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MainWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Auth.CheckUser();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
