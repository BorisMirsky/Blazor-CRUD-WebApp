
using BlazorCRUDWebApp.Models;



namespace BlazorCRUDWebApp.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task<Employee> GetEmployee(Guid id);
        Task AddEmployee(Employee employee);
        Task UpdateEmployee(Guid id, string position, double salary);
        Task DeleteEmployee(Guid id);
        Task<List<Employee>> GroupEmployees(string position);
        Task<List<Employee>> OrderEmployees(double salary, string side);
    }
}
