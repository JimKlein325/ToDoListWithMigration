using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MTest.Models;

namespace ToDoListWithMigrations.Models
{
    public class ToDoDbContext : IdentityDbContext<BTUser>
    {
        //private IConfigurationRoot _config;

        public DbSet<Category> Categories { get; set; } 

        public DbSet<Item> Items { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)//(IConfigurationRoot config, DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
            //_config = config;

        }

        //public ToDoDbContext(IConfigurationRoot config)
        //{
        //    _config = config;
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer(_config["Data:DefaultConnection:ConnectionString"]);
        }
    }
}