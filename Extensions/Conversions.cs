using SalesManagment.Models;
using SalesManagment.Entities;
using Microsoft.EntityFrameworkCore;

namespace SalesManagment.Extensions
{
    public static class Conversions
    {
        public static async Task<List<EmployeeModel>> Convert(this IQueryable<Employee> employees)
        {
            return await (from e in employees
                          select new EmployeeModel
                          {
                              Id = e.Id,
                              FirstName= e.FirstName,
                              Surname= e.Surname,   
                              EmployeeTitleId= e.EmployeeTitleId,
                              Email= e.Email,
                              DateOfBirth= e.DateOfBirth,
                              ReportToEmpId= e.ReportToEmpId,
                              Gender= e.Gender,
                              ImagePath= e.ImagePath,
                          }).ToListAsync();
        }
        public static Employee Convert(this EmployeeModel employeeModel)
        {
            return new Employee
            {
                FirstName = employeeModel.FirstName,
                Surname = employeeModel.Surname,
                EmployeeTitleId = employeeModel.EmployeeTitleId,
                Email = employeeModel.Email,
                DateOfBirth = employeeModel.DateOfBirth,
                ReportToEmpId = employeeModel.ReportToEmpId,
                Gender = employeeModel.Gender,
                ImagePath = employeeModel.Gender.ToUpper() == "MALE" ? "/Images/Profile/MaleDefault.jpg" :
                                                              "/Images/Profile/FamaleDefault.jpg"
            };
        }
    }
}
