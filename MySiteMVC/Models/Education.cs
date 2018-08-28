using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class Education
    {
        public int EducationId { get; set; }

        [Required]
        public string Institution { get; set; }

        [Required]
        public string Logo { get; set; }
        public string Website { get; set; }
        public string Major { get; set; }
        public string Degree { get; set; }
        public int Credits { get; set; }
        public double GPA { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<EducationProjects> EducationProjects { get; set; }
    }
}
