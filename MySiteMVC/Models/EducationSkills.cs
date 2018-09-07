using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class EducationSkills
    {
        public int EducationId { get; set; }
        public Education Education { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
