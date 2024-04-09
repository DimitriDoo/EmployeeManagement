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

        public bool DeleteEmployee(string employeeId)
        {
            Employee em = db.employees.FirstOrDefault(x => x.EmployeeId == employeeId);
            if(em != null)
                db.Remove(em);
            return db.SaveChanges() > 0;
        }

        public bool UpdateEmployee(Employee employee)
        {
            db.Update(employee);
            return db.SaveChanges() > 0;
        }
    }
}
