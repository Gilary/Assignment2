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
        public string Name { get; set; }
        //public ICollection<User> Users { get; set; }
        //public ICollection<Skill> Skills { get; set; }
        //public List<Skill> Skills { get; set; }
        //public ICollection<Skill> Skills { get; set; }
    }
}
