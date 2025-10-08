
using BlazorCRUDWebApp.Models;



namespace BlazorCRUDWebApp.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(Guid id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Guid id, string pos, double sal);
        Task DeleteEmployee(Guid id);
    }
}
