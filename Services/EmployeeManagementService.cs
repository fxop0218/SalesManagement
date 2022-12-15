using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
using SalesManagment.Entities;
using SalesManagment.Extensions;
using SalesManagment.Services.Contracts;

namespace SalesManagment.Services
{
    public class EmployeeManagementService : IEmployeeManagementService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public EmployeeManagementService(ApplicationDbContext applicationDbContext) 
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<List<Employee>> GetEmployees()
        {
            try
            {
                return await this.applicationDbContext.Employees.Convert();
            } 
            catch (Exception ex)
            {
                throw;
            }
            throw new NotImplementedException();
        }
    }
}
