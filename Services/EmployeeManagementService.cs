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

        public async Task<Employee> AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                // Transform employee model to employee
                Employee NewEmployee = employeeModel.Convert();
                // Save the infromation of the employee
                var res = await this.applicationDbContext.Employees.AddAsync(NewEmployee);
                await this.applicationDbContext.SaveChangesAsync(); // Save the changes
                return res.Entity;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task DeleteEmployee(int id)
        {
            try
            {
                var employeeDel = await this.applicationDbContext.Employees.FindAsync(id);

                // If the users exist, delete and save the changes
                if (employeeDel != null) { 
                    this.applicationDbContext.Employees.Remove(employeeDel);
                    await this.applicationDbContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
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

        // Return list of employees where have the EmployeeTitleId equals to "TL" or "SM"
        public async Task<List<ReportToModel>> GetEmployeeReportTo()
        {
            try
            {
                var employees = await (from e in this.applicationDbContext.Employees
                                       join i in this.applicationDbContext.EmployeeJobTitles
                                       on e.EmployeeTitleId equals i.EmployeeTitleId
                                       where i.Name.ToUpper() == "SM" || i.Name.ToUpper() == "TL"
                                       select new ReportToModel
                                       {
                                           ReportToEmpId = e.Id,
                                           ReportToName = e.FirstName + " " + e.Surname.Substring(0, 1).ToUpper() + ".",
                                       }).ToListAsync();
                employees.Add(new ReportToModel { ReportToEmpId = null, ReportToName = "<None>" });

                return employees.OrderBy(o => o.ReportToEmpId).ToList();
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

        public async Task UpdateEmployee(EmployeeModel employee)
        {
            try
            {
                var employeeUpdate = await this.applicationDbContext.Employees.FindAsync(employee.Id);
                if (employeeUpdate != null) // If the users exists, change all the values to the new values.
                {
                    employeeUpdate.FirstName = employee.FirstName;
                    employeeUpdate.Surname = employee.Surname;
                    employeeUpdate.ReportToEmpId= employee.ReportToEmpId;
                    employeeUpdate.DateOfBirth = employee.DateOfBirth;
                    employeeUpdate.ImagePath = employee.ImagePath;
                    employeeUpdate.Gender = employee.Gender;
                    employeeUpdate.Email = employee.Email;
                    employeeUpdate.EmployeeTitleId= employee.EmployeeTitleId;

                    await this.applicationDbContext.SaveChangesAsync(); // Save user changes
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
