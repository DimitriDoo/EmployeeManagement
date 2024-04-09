using EmployeeManagement.API.Employees.Business.Service;
using EmployeeManagement.API.Employees.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Employees.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpoyeeService _EmployeeService;

        public EmployeeController(IEmpoyeeService employeeService)
        {
            _EmployeeService = employeeService;
        }

        [HttpGet("/Employee/{employeeId}")]
        public EmployeeResponse GetEmployee(string employeeId)
        {
            return _EmployeeService.GetEmployee(employeeId);
        }

        [HttpPost("/Employee")]
        public EmployeeResponse AddEmployee(EmployeeRequest employeeRequest)
        {
            return _EmployeeService.AddEmployee(employeeRequest);
        }

    }
}
