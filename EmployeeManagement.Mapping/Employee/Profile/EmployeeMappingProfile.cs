using AutoMapper;
using EmployeeManagement.API.Employees.Data.Models;
using EmployeeManagement.API.Employees.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementt.API.Employees.Mapping
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile() {
            CreateMap<Employee,EmployeeResponse>();
            CreateMap<EmployeeRequest,Employee>();
        }
    }
}
