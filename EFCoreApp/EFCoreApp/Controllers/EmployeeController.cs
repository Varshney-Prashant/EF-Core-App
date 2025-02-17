using EfCoreApp.CoreModels.Employee;
using EfCoreApp.Services.Employees;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService EmployeeService { get; set; }

        public EmployeeController(IEmployeeService employeeService)
        {
            this.EmployeeService = employeeService;
        }

        [HttpGet("all")]
        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            return await this.EmployeeService.GetEmployees();
        }

        [HttpPost("add")]
        public async Task<Guid> AddEmployee(EmployeeDto employee)
        {
            return await this.EmployeeService.AddEmployee(employee);
        }
    }
}
