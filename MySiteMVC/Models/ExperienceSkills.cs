using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class ExperienceSkills
    {
        public int ExperienceId { get; set; }
        public Experience Experience { get; set; }

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
