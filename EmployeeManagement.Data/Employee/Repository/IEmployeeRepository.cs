using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.API.Employees.Data.Models;

namespace EmployeeManagement.API.Employees.Data.Repository
{
    public interface IEmployeeRepository
    {
        public Employee GetEmployeeByEmployeeId(string id);
        public bool AddEmployee(Employee employee);
        public bool DeleteEmployee(string employeeId);
        public bool UpdateEmployee(Employee employee);
    }
}
