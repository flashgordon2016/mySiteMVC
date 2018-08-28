using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySiteMVC.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySiteMVC.Controllers
{
    public class BlogController : Controller
    {
        private readonly MySiteDBContext _context;

        public BlogController(MySiteDBContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public async Task<IActionResult> Index()
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
            return View(await _context.BlogPost.Include(p => p.PostTagsJunction).ThenInclude(pt => pt.Tag).ToListAsync());
        }

        public async Task<IActionResult> Post(int? id)
        {
            //check that id was supplied
            if (id == null)
            {
                return NotFound();
            }

            //retrieve post and/or check that it exists
            var post = await _context.BlogPost.Include(p => p.PostTagsJunction).ThenInclude(pt => pt.Tag).FirstOrDefaultAsync(m => m.BlogPostId == id);
            if (post == null)
            {
                return NotFound();
            }

            //prepare page menu items
            string[] SectionHeadings = new string[5];
            ViewData["SectionHeadings"] = SectionHeadings;
            SectionHeadings[0] = "5 Key Takeaways from Rocket Surgery Made Easy";
            SectionHeadings[1] = "The Christofides Algorithm: 40 Years Later";
            SectionHeadings[2] = "Cuckoo's Nest: A Look at Network Security Issues in 1987";
            SectionHeadings[3] = "Social Engineering: Is the Issue Overblown?";
            SectionHeadings[4] = "ASP.NET Core: Razor Pages vs MVC";

            return View(post);
        }
    }
}
