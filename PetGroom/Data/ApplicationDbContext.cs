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
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
