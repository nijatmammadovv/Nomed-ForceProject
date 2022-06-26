using Microsoft.EntityFrameworkCore;
using Nomed_Force_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomed_Force_Project.Data_Access_Layer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Team> Teams { get; set; }
    }
}
