using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace ToDoListWithMigrations.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } 

        public DbSet<Item> Items { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
        }

        public ToDoDbContext()
        {

            //(@"Server=(localdb)\\MSSQLLocalDB;Database=ToDoListWithMigrations;Trusted_Connection=True;");
        //var optionsBuilder = new DbContextOptionsBuilder<ToDoDbContext
        //        >();
        //    optionsBuilder.UseSqlServer(Configuration["Data:DefaultConnection:ConnectionString"]));
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}