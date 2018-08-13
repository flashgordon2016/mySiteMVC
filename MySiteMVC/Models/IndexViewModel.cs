using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class IndexViewModel
    {
        public string[] SectionHeadings { get; set; }

        public void OnGet()
        {
            SectionHeadings = new string[5];
            SectionHeadings[0] = "intro";
            SectionHeadings[1] = "experience";
            SectionHeadings[2] = "education";
            SectionHeadings[3] = "skills";
            SectionHeadings[4] = "hobbies";
        }
    }
}
