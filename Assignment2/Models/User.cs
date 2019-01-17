using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string lastActivityDate { get; set; }
        public List<Project> Projects { get; set; }
        public List<Car> Cars { get; set; }
        //public int Id { get; set; }
        //public string Name { get; set; }
        ////public Car Car { get; set; }
        ////public Project Project { get; set; }
        //public ICollection<Car> Cars { get; set; }
        //public ICollection<Project> Projects { get; set; }
        ////public List<Car> Cars { get; set; }
        ////public List<Project> Projects { get; set; }
    }
}
