using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PetGroom.Models;

namespace PetGroom.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
      
        }

       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Groomer", NormalizedName = "GROOMER" });
                
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Customer", NormalizedName = "CUSTOMER" });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = "Employee", NormalizedName = "EMPLOYEE" });
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Groomer> Groomers { get; set; }
        
        public DbSet<GroomService> GroomServices { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        
    }
}
