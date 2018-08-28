using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public partial class EducationProjects
    {
        public int EducationId { get; set; }
        public Education Education { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
