using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Company
    {
        [Key]
        public string Name { get; set; }
        //public List<Car> Cars { get; set; }
        //public ICollection<Car> Cars { get; set; }
    }
}
