using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LodgeWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult History()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Officers()
        {
            return View();
        }

        public IActionResult Contributions()
        {
            ViewData["Message"] = "CHIPs description page.";

            return View();
        }

        public IActionResult Bylaws()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
