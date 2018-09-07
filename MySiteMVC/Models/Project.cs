using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }
        public string Video { get; set; }
        public string DemoLink { get; set; }
        public string SourceCode { get; set; }
        public List<ProjectTags> ProjectTags { get; set; }
        public Experience Experience { get; set; }
        public List<ProjectSkills> ProjectSkills { get; set; }
    }
}
