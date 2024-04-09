using EmployeeManagement.API.Employees.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.API.Employees.Data.Repository
{
    public class EmployeeDatabase : IEmployeeRepository
    {
        private EmployeeContext db = new EmployeeContext();

        public Employee GetEmployeeByEmployeeId(string id)
        {
            return db.employees.FirstOrDefault(x => x.EmployeeId == id);
        }

        public bool AddEmployee(Employee employee)
        {
            db.employees.Add(employee);
            return db.SaveChanges() > 0;
        }

    }
}
