using EmployeeManagement.API.Employees.Data.Repository;
using EmployeeManagement.API.Employees.Data.Models;
using EmployeeManagement.API.Employees.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Crypto;
using AutoMapper;
using EmployeeManagement.API.Employees.Mapping;

namespace EmployeeManagement.API.Employees.Business.Service
{
    public class EmployeeServiceImpl : IEmpoyeeService
    {
        IEmployeeRepository employeeRepo = new EmployeeDatabase();

        public IMapper Mapper => EmployeeMapper.Mapper;

        public EmployeeResponse GetEmployee(string employeeId)
        {
            return Mapper.Map<EmployeeResponse>(employeeRepo.GetEmployeeByEmployeeId(employeeId));
        }

        public EmployeeResponse AddEmployee(EmployeeRequest employeeRequestModel)
        {
            Employee newEmployee = Mapper.Map<Employee>(employeeRequestModel);
            newEmployee.EmployeeId = Guid.NewGuid().ToString();
            newEmployee.TimesheetId = Guid.NewGuid().ToString();
            if (!employeeRepo.AddEmployee(newEmployee))
                throw new Exception();

            return Mapper.Map<EmployeeResponse>(newEmployee);
            
        }

        public bool DeleteEmployee(string employeeId)
        { 
            return employeeRepo.DeleteEmployee(employeeId);
        }
    }
}
