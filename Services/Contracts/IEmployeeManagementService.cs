using SalesManagment.Entities;

namespace SalesManagment.Services.Contracts
{
    public interface IEmployeeManagementService
    {
        Task<List<Employee>> GetEmployees();
    }
}
