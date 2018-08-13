using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySiteMVC.Models;

namespace MySiteMVC.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            string[] SectionHeadings = new string[5];
            ViewData["SectionHeadings"] = SectionHeadings;
            SectionHeadings[0] = "intro";
            SectionHeadings[1] = "experience";
            SectionHeadings[2] = "education";
            SectionHeadings[3] = "skills";
            SectionHeadings[4] = "hobbies";
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
