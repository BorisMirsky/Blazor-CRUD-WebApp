//namespace BlazorCRUDWebApp.Models

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace BlazorCRUDWebApp.Models
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}

