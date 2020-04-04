using EmployeeManagement.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Data
{
    public class DataContext : IdentityDbContext<ApplicationUser>
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<Employee> Employees { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Seed();

        //    foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
        //        .SelectMany(e => e.GetForeignKeys()))
        //    {
        //        foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        //    }
        //}
    }
}
