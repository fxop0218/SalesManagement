using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
using SalesManagment.Entities;
using SalesManagment.Extensions;
using SalesManagment.Models.ReportModels;
using SalesManagment.Services.Contracts;
using Syncfusion.Blazor.Grids;

namespace SalesManagment.Services
{
    public class SalesOrderReportService : ISalesOrderReportService
    {
        private const string JANUARY = "Jan";
        private const string FEBRUARY = "Feb";
        private const string MARCH = "Mar";
        private const string APRIL = "Apr";
        private const string MAY = "May";
        private const string JUNE = "Jun";
        private const string JULY = "Jul";
        private const string AUGUST = "Aug";
        private const string SEPTEMBER = "Sep";
        private const string OCTOBER = "Oct";
        private const string NOVEMBER = "Nov";
        private const string DECEMBER = "Dec";
        private readonly ApplicationDbContext applicationDbContext;
        private readonly AuthenticationStateProvider asp;

        public SalesOrderReportService(ApplicationDbContext applicationDbContext, AuthenticationStateProvider asp)
        {
            this.applicationDbContext = applicationDbContext;
            this.asp = asp;
        }
        public async Task<List<GroupedFieldPriceModel>> GetEmployeePricePerMonth()
        {
            try
            {
                var emp = await GetLoggedOnEmployee();

                var reportData = await (from s in this.applicationDbContext.SalesOrderReports
                                        where s.EmployeeId == emp.Id && s.OrderDateTime.Year == DateTime.Now.Year
                                        group s by s.OrderDateTime.Month into GD
                                        orderby GD.Key
                                        select new GroupedFieldPriceModel
                                        {
                                            GroupedFieldKey = (
                                                GD.Key == 1 ? JANUARY :
                                                GD.Key == 2 ? FEBRUARY :
                                                GD.Key == 3 ? MARCH :
                                                GD.Key == 4 ? APRIL :
                                                GD.Key == 5 ? MAY :
                                                GD.Key == 6 ? JUNE :
                                                GD.Key == 7 ? JULY :
                                                GD.Key == 8 ? AUGUST :
                                                GD.Key == 9 ? SEPTEMBER :
                                                GD.Key == 10 ? OCTOBER :
                                                GD.Key == 11 ? NOVEMBER :
                                                GD.Key == 12 ? DECEMBER :
                                                ""
                                            ),
                                            Price = Math.Round(GD.Sum(o => o.OrderItemPrice), 2)

                                        }).ToListAsync();
                return reportData;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public async Task<List<GroupedFieldQuantityModel>> GetQuantitiyPerMonth()
        {
            try
            {
                var emp = await GetLoggedOnEmployee();
                var repData = await (from s in this.applicationDbContext.SalesOrderReports
                                     where s.EmployeeId == emp.Id
                                     group s by s.OrderDateTime.Month into GD
                                     orderby GD.Key
                                     select new GroupedFieldQuantityModel
                                     {
                                         GroupedFieldKey = (
                                                GD.Key == 1 ? JANUARY :
                                                GD.Key == 2 ? FEBRUARY :
                                                GD.Key == 3 ? MARCH :
                                                GD.Key == 4 ? APRIL :
                                                GD.Key == 5 ? MAY :
                                                GD.Key == 6 ? JUNE :
                                                GD.Key == 7 ? JULY :
                                                GD.Key == 8 ? AUGUST :
                                                GD.Key == 9 ? SEPTEMBER :
                                                GD.Key == 10 ? OCTOBER :
                                                GD.Key == 11 ? NOVEMBER :
                                                GD.Key == 12 ? DECEMBER :
                                                ""
                                            ),
                                         Quantity = GD.Sum(o => o.OrderItemQty)
                                     }).ToListAsync();
                return repData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<GroupedFieldQuantityModel>> GetQuantityPerCategory()
        {
            try
            {
                var repData = await (from sal in this.applicationDbContext.SalesOrderReports
                                     group sal by sal.ProductCategoryName into GD
                                     orderby GD.Key
                                     select new GroupedFieldQuantityModel
                                     {
                                         GroupedFieldKey = GD.Key,
                                         Quantity = GD.Sum(o => o.OrderItemQty)
                                     }).ToListAsync();
                return repData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Team leader functions
        public async Task<List<GroupedFieldPriceModel>> GetGrossSalerPerMember()
        {
            try
            {
                List<int> memberIds = await GetMemberIds(3);

                var repData = await (from emp in this.applicationDbContext.SalesOrderReports
                                     where memberIds.Contains(emp.EmployeeId)
                                     group emp by emp.EmployeeFirstName into GD
                                     orderby GD.Key
                                     select new GroupedFieldPriceModel
                                     {
                                         GroupedFieldKey = GD.Key,
                                         Price = Math.Round((decimal)GD.Sum(o => o.OrderItemPrice), 2)
                                     }).ToListAsync();
                return repData;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public async Task<List<GroupedFieldQuantityModel>> GetQuantityPerMember()
        {
            try
            {
                List<int> memberIds = await GetMemberIds(3);

                var repData = await (from emp in this.applicationDbContext.SalesOrderReports
                                     where memberIds.Contains(emp.EmployeeId)
                                     group emp by emp.EmployeeFirstName into GD
                                     orderby GD.Key
                                     select new GroupedFieldQuantityModel
                                     {
                                         GroupedFieldKey = GD.Key,
                                         Quantity = GD.Sum(o => o.OrderItemQty)
                                     }).ToListAsync();
                return repData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<GroupedFieldQuantityModel>> GetTeamQuantityMonth()
        {
            try
            {
                List<int> memberIds = await GetMemberIds(3);
                var repData = await (from emp in this.applicationDbContext.SalesOrderReports
                                     where memberIds.Contains(emp.EmployeeId) && emp.OrderDateTime.Year == DateTime.Now.Year
                                     group emp by emp.OrderDateTime.Month into GD
                                     orderby GD.Key
                                     select new GroupedFieldQuantityModel
                                     {
                                         GroupedFieldKey = 
                                         (
                                                GD.Key == 1 ? JANUARY :
                                                GD.Key == 2 ? FEBRUARY :
                                                GD.Key == 3 ? MARCH :
                                                GD.Key == 4 ? APRIL :
                                                GD.Key == 5 ? MAY :
                                                GD.Key == 6 ? JUNE :
                                                GD.Key == 7 ? JULY :
                                                GD.Key == 8 ? AUGUST :
                                                GD.Key == 9 ? SEPTEMBER :
                                                GD.Key == 10 ? OCTOBER :
                                                GD.Key == 11 ? NOVEMBER :
                                                GD.Key == 12 ? DECEMBER :
                                                ""
                                         ), 
                                         Quantity = GD.Sum(o=>o.OrderItemQty)
 
                                     }).ToListAsync();
                return repData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // Sales Manager

        public async Task<List<LocationProductCategoryModel>> GetQuantityLocationProduct()
        {
            try
            {
                var respData = await (from loc in this.applicationDbContext.SalesOrderReports
                                      group loc by loc.RetailOutletLocation into GD
                                      orderby GD.Key
                                      select new LocationProductCategoryModel
                                      {
                                          Location = GD.Key,
                                          CPU = GD.Where(p => p.ProductCategoryId == 1).Sum(o => o.OrderItemQty),
                                          GPU = GD.Where(p => p.ProductCategoryId == 2).Sum(o => o.OrderItemQty),
                                          Mobiles = GD.Where(p => p.ProductCategoryId == 3).Sum(o => o.OrderItemQty),
                                          Computers = GD.Where(p => p.ProductCategoryId == 4).Sum(o => o.OrderItemQty),
                                          RAM = GD.Where(p => p.ProductCategoryId == 5).Sum(o => o.OrderItemQty),
                                          SSD = GD.Where(p => p.ProductCategoryId == 6).Sum(o => o.OrderItemQty),
                                          motherboard = GD.Where(p => p.ProductCategoryId == 7).Sum(o => o.OrderItemQty),
                                      }).ToListAsync();
                return respData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<GroupedFieldQuantityModel>> GetQuantityPerLocation()
        {
            try
            {
                var respData = await (from loc in this.applicationDbContext.SalesOrderReports
                                      group loc by loc.RetailOutletLocation
                                      into GD
                                      orderby GD.Key
                                      select new GroupedFieldQuantityModel
                                      {
                                          GroupedFieldKey = GD.Key,
                                          Quantity = GD.Sum(o => o.OrderItemQty)
                                      }).ToListAsync();
                return respData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<List<MonthLocationModel>> GetQuantityPerMonthLocation()
        {
            try
            {
                var repData = await (from loc in this.applicationDbContext.SalesOrderReports
                                     group loc by loc.OrderDateTime.Month
                                     into GD
                                     orderby GD.Key
                                     select new MonthLocationModel
                                     {
                                         Month =
                                         (
                                                GD.Key == 1 ? JANUARY :
                                                GD.Key == 2 ? FEBRUARY :
                                                GD.Key == 3 ? MARCH :
                                                GD.Key == 4 ? APRIL :
                                                GD.Key == 5 ? MAY :
                                                GD.Key == 6 ? JUNE :
                                                GD.Key == 7 ? JULY :
                                                GD.Key == 8 ? AUGUST :
                                                GD.Key == 9 ? SEPTEMBER :
                                                GD.Key == 10 ? OCTOBER :
                                                GD.Key == 11 ? NOVEMBER :
                                                GD.Key == 12 ? DECEMBER :
                                                ""
                                         ),
                                         CA = GD.Where(p => p.RetailOutletLocation == "CA").Sum(o=>o.OrderItemQty),
                                         NY = GD.Where(p => p.RetailOutletLocation == "NY").Sum(o => o.OrderItemQty),
                                         TX = GD.Where(p => p.RetailOutletLocation == "TX").Sum(o => o.OrderItemQty),
                                         WA = GD.Where(p => p.RetailOutletLocation == "WA").Sum(o => o.OrderItemQty),
                                     }).ToListAsync();
                return repData;
            }
            catch (Exception)
            {

                throw;
            }
        }

        // General fuctions

        private async Task<List<int>> GetMemberIds(int leaderId)
        {
            List<int> memberIds = await this.applicationDbContext.Employees
                    .Where(emp => emp.ReportToEmpId == leaderId).Select(emp => emp.Id).ToListAsync();
            return memberIds;
        }

        private async Task<Employee> GetLoggedOnEmployee()
        {
            var authState = await this.asp.GetAuthenticationStateAsync();
            var user = authState.User;

            return await user.GetEmployeeObject(this.applicationDbContext);
        }


    }


}
