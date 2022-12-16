using SalesManagment.Entities;
using SalesManagment.Models;

namespace SalesManagment.Services.Contracts
{
    public interface IEmployeeManagementService
    {
        Task<List<EmployeeModel>> GetEmployees();
        Task<List<EmployeeJobTitle>> GetEmployeeJobTitle();
    }
}
