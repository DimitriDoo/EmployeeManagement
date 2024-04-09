using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.API.Employees.Data.Models;
using EmployeeManagement.API.Employees.DTO;


namespace EmployeeManagement.API.Employees.Business.Service
{
    public interface IEmpoyeeService
    {
        public EmployeeResponse GetEmployee(string employeeId);
        public EmployeeResponse AddEmployee(EmployeeRequest employeeRequestModel);
    }
}
