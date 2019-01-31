using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class SkillProject
    {
        [Key]
        public int SkillProjectId { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
