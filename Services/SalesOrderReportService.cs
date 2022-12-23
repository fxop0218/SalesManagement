using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
using SalesManagment.Entities;
using SalesManagment.Models.ReportModels;
using SalesManagment.Services.Contracts;

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
                                        group s by s.OrderDateTime.Month into GroupedData
                                        orderby GroupedData.Key
                                        select new GroupedFieldPriceModel
                                        {
                                            GroupedFieldKey = (
                                                GroupedData.Key == 1 ? "Jan" :
                                                GroupedData.Key == 2 ? "Feb" :
                                                GroupedData.Key == 3 ? "Mar" :
                                                GroupedData.Key == 4 ? "Apr" :
                                                GroupedData.Key == 5 ? "May" :
                                                GroupedData.Key == 6 ? "Jun" :
                                                GroupedData.Key == 7 ? "Jul" :
                                                GroupedData.Key == 8 ? "Aug" :
                                                GroupedData.Key == 9 ? "Sep" :
                                                GroupedData.Key == 10 ? "Oct" :
                                                GroupedData.Key == 11 ? "Nov" :
                                                GroupedData.Key == 12 ? "Dec" :
                                                ""
                                            ),
                                            Price = Math.Round(GroupedData.Sum(o => o.OrderItemPrice), 2)

                                        }).ToListAsync();
                return reportData;
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
