using EfCoreApp.CoreModels.Employee;
using EfCoreApp.Models;
using EfCoreApp.Repositories.EmployeeRepository;
using EfCoreApp.Services.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp.Services.Employees
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeeRepository employeeRpository { get; set; }

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRpository = employeeRepository;
        }

        public async Task<IEnumerable<EmployeeDto>> GetEmployees()
        {
            var employees = await this.employeeRpository.GetAllAsync();
            return employees.MapCollectionTo<Employee, EmployeeDto>();
        }

        public async Task<Guid> AddEmployee(EmployeeDto employee)
        {
            return await this.employeeRpository.AddEmployee(employee.MapTo<Employee>());
        }
    }
}
