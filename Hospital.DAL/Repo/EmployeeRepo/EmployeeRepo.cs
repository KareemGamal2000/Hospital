using Hospital.DAL.Context;
using Hospital.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repo.EmployeeRepo
{
    public class EmployeeRepo: IEmployeeRepo
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepo(ApplicationDbContext context)
        {
            _context = context;

        }
        public async Task<IEnumerable<Entities.Employee>> GetAllEmployeess()
        {
            return await _context.Employees.ToListAsync();

        }
        public async Task<int> Add(Entities.Employee employee)
        {
            await _context.Employees.AddAsync(employee);
            return await _context.SaveChangesAsync();
        }
    }
}
