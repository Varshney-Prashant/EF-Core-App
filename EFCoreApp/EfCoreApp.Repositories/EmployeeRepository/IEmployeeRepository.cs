using EfCoreApp.Models;
using EfCoreApp.Repositories.BaseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<Guid> AddEmployee(Employee employee);
    }
}
