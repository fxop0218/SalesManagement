using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
using SalesManagment.Entities;
using SalesManagment.Extensions;
using SalesManagment.Models;
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

        public async Task<List<EmployeeJobTitle>> GetEmployeeJobTitle()
        {
            try
            {
                return await this.applicationDbContext.EmployeeJobTitles.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<EmployeeModel>> GetEmployees()
        {
            try
            {
                return await this.applicationDbContext.Employees.Convert();
            } 
            catch (Exception)
            {
                throw;
            }
            throw new NotImplementedException();
        }
    }
}
