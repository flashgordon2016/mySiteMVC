using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySiteMVC.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string[] SectionHeadings = new string[10];
            ViewData["SectionHeadings"] = SectionHeadings;
            SectionHeadings[0] = "5 Key Takeaways from Rocket Surgery Made Easy";
            SectionHeadings[1] = "The Christofides Algorithm: 40 Years Later";
            SectionHeadings[2] = "Cuckoo's Nest: A Look at Network Security Issues in 1987";
            SectionHeadings[3] = "Social Engineering: Is the Issue Overblown?";
            SectionHeadings[4] = "ASP.NET Core: Razor Pages vs MVC";
            SectionHeadings[5] = "Model-View-Controller Design Pattern Explained in 3 Levels of Difficulty";
            SectionHeadings[6] = "Still using Bootstrap 3? Here's why you Should Switch to Bootstrap 4";
            SectionHeadings[7] = "The Soul of the New Machine and the Modern Disruption Myth";
            SectionHeadings[8] = "Microsoft Azure's Consistent Hybrid Cloud Explained in 3 Levels of Difficulty";
            SectionHeadings[9] = "What Upgrading Memory Capacity Can and Can't do for your Computer ";
            return View();
        }
    }
}
