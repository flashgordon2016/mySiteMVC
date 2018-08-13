using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySiteMVC.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string[] SectionHeadings = new string[10];
            ViewData["SectionHeadings"] = SectionHeadings;
            SectionHeadings[0] = "Employee Achievement Recognition System";
            SectionHeadings[1] = "Stuff Tracker Mobile App";
            SectionHeadings[2] = "My Personal Site";
            SectionHeadings[3] = "Apache URLValidator Fuzzer";
            SectionHeadings[4] = "Report-a-Spill Mobile Prototype";
            SectionHeadings[5] = "Velomobile Data REST API";
            SectionHeadings[6] = "Snopes for Chrome Extension";
            SectionHeadings[7] = "Medicaid Alaska Mobile App";
            SectionHeadings[8] = "It could be worse - Weather App";
            SectionHeadings[9] = "Flashcard Maker";
            return View();
        }
    }
}
