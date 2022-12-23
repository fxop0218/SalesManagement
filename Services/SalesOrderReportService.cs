using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
using SalesManagment.Entities;
using SalesManagment.Models.ReportModels;
using SalesManagment.Services.Contracts;
using Syncfusion.Blazor.Grids;

namespace SalesManagment.Services
{
    public class SalesOrderReportService : ISalesOrderReportService
    {
        private readonly ApplicationDbContext applicationDbContext; 
        public SalesOrderReportService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }
        public async Task<List<GroupedFieldPriceModel>> GetEmployeePricePerMonth()
        {
            try
            {

                var reportData = await (from s in this.applicationDbContext.SalesOrderReports
                                        where s.EmployeeId == 9 && s.OrderDateTime.Year == DateTime.Now.Year
                                        group s by s.OrderDateTime.Month into GD
                                        orderby GD.Key
                                        select new GroupedFieldPriceModel
                                        {
                                            GroupedFieldKey = (
                                                GD.Key == 1 ? "Jan" :
                                                GD.Key == 2 ? "Feb" :
                                                GD.Key == 3 ? "Mar" :
                                                GD.Key == 4 ? "Apr" :
                                                GD.Key == 5 ? "May" :
                                                GD.Key == 6 ? "Jun" :
                                                GD.Key == 7 ? "Jul" :
                                                GD.Key == 8 ? "Aug" :
                                                GD.Key == 9 ? "Sep" :
                                                GD.Key == 10 ? "Oct" :
                                                GD.Key == 11 ? "Nov" :
                                                GD.Key == 12 ? "Dec" :
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
                var repData = await (from sal in this.applicationDbContext.SalesOrderReports
                                     where sal.EmployeeId == 9
                                     group sal by sal.OrderDateTime.Month into GD
                                     orderby GD.Key
                                     select new GroupedFieldQuantityModel
                                     {
                                         GroupedFieldKey = (
                                                GD.Key == 1 ? "Jan" :
                                                GD.Key == 2 ? "Feb" :
                                                GD.Key == 3 ? "Mar" :
                                                GD.Key == 4 ? "Apr" :
                                                GD.Key == 5 ? "May" :
                                                GD.Key == 6 ? "Jun" :
                                                GD.Key == 7 ? "Jul" :
                                                GD.Key == 8 ? "Aug" :
                                                GD.Key == 9 ? "Sep" :
                                                GD.Key == 10 ? "Oct" :
                                                GD.Key == 11 ? "Nov" :
                                                GD.Key == 12 ? "Dec" :
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
                                     orderby GD.Key select new GroupedFieldQuantityModel
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
    }
}
