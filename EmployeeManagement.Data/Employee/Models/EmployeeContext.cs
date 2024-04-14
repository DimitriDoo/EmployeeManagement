using EmployeeManagement.Core.Config;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Employees.Data.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext()
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(EmployeeConfig.config.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Employee> employees { get; set; }
    }
}
