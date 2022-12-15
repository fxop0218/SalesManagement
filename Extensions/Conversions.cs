using SalesManagment.Models;
using SalesManagment.Entities;
using Microsoft.EntityFrameworkCore;

namespace SalesManagment.Extensions
{
    public static class Conversions
    {
        public static async Task<List<EmployeeModel>> Convert(this IQueryable<Entities.Employee> employees)
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
    }
}
