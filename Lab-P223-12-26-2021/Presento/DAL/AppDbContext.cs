using Microsoft.EntityFrameworkCore;
using Presento.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presento.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CardCategory> CardCategories { get; set; }

    }
}
