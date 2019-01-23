using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public int ProjectType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Skill> Skills { get; set; }
        public ICollection<SkillProject> SkillProjects { get; set; }
        //public ICollection<Skill> Skills { get; set; }
        //public List<Skill> Skills { get; set; }
        //public ICollection<Skill> Skills { get; set; }
    }
}
