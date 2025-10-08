//namespace BlazorCRUDWebApp.Services

using BlazorCRUDWebApp.Components.Pages;
using BlazorCRUDWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace BlazorCRUDWebApp.Services
{
    public class EmployeeService : IEmployeeService
    {

        private readonly EmployeeDbContext _context;

        public EmployeeService(EmployeeDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _context.Employees.ToListAsync();
        }


        public async Task<Employee> GetEmployee(Guid id)
        {
            Employee? employeeModel = await _context.Employees
                                                .AsNoTracking()
                                                .FirstOrDefaultAsync(e => e.Id == id);
            if (employeeModel == null)
            {
                throw new Exception("Employee not found");
            }
            return employeeModel;
        }


        public async Task AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployee(Guid id, string pos, double sal) //Employee employee)
        {
            //_context.Entry(employee).State = EntityState.Modified;
            //await _context.SaveChangesAsync();
            await _context.Employees
                .Where(o => o.Id == id)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(o => o.Salary, o => sal)
                    .SetProperty(o => o.Position, o => pos));
            //await _context.SaveChangesAsync();
            //return id;
        }


        public async Task DeleteEmployee(Guid id)
        {
            var employeeEntity = await _context.Employees.FindAsync(id);
            if (employeeEntity != null)
            {
                _context.Employees.Remove(employeeEntity);
                await _context.SaveChangesAsync();
            }
        }
    }
}


