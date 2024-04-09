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
        IConfiguration config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        public EmployeeContext()
        { 
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(config.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Employee> employees { get; set; }
    }
}
