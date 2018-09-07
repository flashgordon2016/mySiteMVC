using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public double YearsOfExperience { get; set; }
        public string Description { get; set; }
        public List<EducationSkills> SkillEducation { get; set; }
        public List<ProjectSkills> SkillProjects { get; set; }
        public List<ExperienceSkills> SkillExperience { get; set; }
    }
}
