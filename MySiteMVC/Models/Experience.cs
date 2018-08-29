using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class Experience
    {
        public int ExperienceId { get; set; }

        [Required]
        public string Organization { get; set; }
        public string OrgLogo { get; set; }

        [Required]
        public string JobTitle { get; set; }

        [Required]
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Project> Projects { get; set; }
    }
}
