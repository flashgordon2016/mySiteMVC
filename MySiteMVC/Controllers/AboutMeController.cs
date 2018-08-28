using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySiteMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MySiteMVC.Controllers
{
    public class AboutMeController : Controller
    {
        private readonly MySiteDBContext _context;

        public AboutMeController(MySiteDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            AboutMeViewModel AMVM = new AboutMeViewModel(); 
            AMVM.Education = await _context.Education.ToListAsync();

            string[] SectionHeadings = new string[5];
            ViewData["SectionHeadings"] = SectionHeadings;
            SectionHeadings[0] = "intro";
            SectionHeadings[1] = "experience";
            SectionHeadings[2] = "education";
            SectionHeadings[3] = "skills";
            SectionHeadings[4] = "hobbies";

            return View(AMVM);
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
