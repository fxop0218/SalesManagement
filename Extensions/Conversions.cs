using SalesManagment.Models;
using SalesManagment.Entities;
using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
using System.Runtime.CompilerServices;

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
                ImagePath = employeeModel.Gender.ToUpper() == "MALE" ? "/Images/Profile/MaleDefault.jpg"
                                                                    : "/Images/Profile/FamaleDefault.jpg"
            };
        }

        public static async Task<List<ProductModel>> Convert(this IQueryable<Product> Products, ApplicationDbContext context)
        {
            return await (from product in Products
                          join prodCat in context.ProductCategories
                          on product.CategoryId equals prodCat.Id
                          select new ProductModel
                          {
                              Id = product.Id,
                              Name = product.Name,
                              Description = product.Description,
                              Price = product.Price,
                              CategoryId = product.CategoryId,
                              CategoryName = prodCat.Name,
                              ImgPath = product.ImgPath

                          }).ToListAsync();
        }

        public static async Task<List<ClientModel>> Convert(this IQueryable<Client> clients, ApplicationDbContext context)
        {
            return await (from c in clients
                          join r in context.RetailOutlets
                          on c.RetailOutletId equals r.Id
                          select new ClientModel
                          {
                              Id = c.Id,
                              FirstName = c.FirstName,
                              Surname = c.Surname,
                              JobTitle = c.JobTitle,
                              Phone = c.Phone,
                              Email = c.Email,
                              RetailOutletId = c.RetailOutletId,
                              RetailOutletName = r.Name,
                              RetailOutletLocation = r.Location

                          }).ToListAsync();
        }

        public static async Task<List<OrganisationModel>> ConvertToH(this IQueryable<Employee> employees, ApplicationDbContext context)
        {
            return await (from c in employees
                          join t in context.EmployeeJobTitles on c.EmployeeTitleId
                          equals t.EmployeeTitleId
                          orderby c.Id
                          select new OrganisationModel
                          {
                              EMployeeId = c.Id.ToString(),
                              ReportsToId = c.ReportToEmpId != null ? c.ReportToEmpId.ToString() : "",
                              Email = c.Email,
                              FirstName = c.FirstName,
                              Surname = c.Surname,
                              ImgPath = c.ImagePath,
                              JobTitle = t.Name,
                          }).ToListAsync();
        }
    }
}
