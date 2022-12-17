using SalesManagment.Entities;
using SalesManagment.Models;

namespace SalesManagment.Services.Contracts
{
    public interface IEmployeeManagementService
    {
        Task<List<EmployeeModel>> GetEmployees();
        Task<List<EmployeeJobTitle>> GetEmployeeJobTitle();
        Task<List<ReportToModel>> GetEmployeeReportTo();
        Task<Employee> AddEmployee(EmployeeModel employee);
        Task UpdateEmployee(EmployeeModel employee);
        Task DeleteEmployee(int id);
    }
}
