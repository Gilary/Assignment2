using Assignment2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            :base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
