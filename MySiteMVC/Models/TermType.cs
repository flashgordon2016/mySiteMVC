using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySiteMVC.Models
{
    public class TermType
    {
        public int TermTypeId { get; set; }

        [Required]
        [MaxLength(64)]
        public string Term { get; set; }
        public List<Education> Education { get; set; }
    }
}
