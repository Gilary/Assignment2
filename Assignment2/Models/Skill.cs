using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Skill
    {
        [Key]
        public string Name { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
