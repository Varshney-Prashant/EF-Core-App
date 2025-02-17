using EfCoreApp.Models;
using EfCoreApp.Repositories.BaseRepository;
using EFCoreApp.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreApp.Repositories.EmployeeRepository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext _context): base(_context)
        {
            this._context = _context;
        }

        public async override Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await this._context.Employees.Include(_ => _.Address).ToListAsync();
        }

        public async Task<Guid> AddEmployee(Employee employee)
        {
            await this._context.Employees.AddAsync(employee);
            await this._context.SaveChangesAsync();
            return employee.Id;
        }
    }
}
