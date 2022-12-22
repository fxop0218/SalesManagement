using Microsoft.EntityFrameworkCore;
using SalesManagment.Data;
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
                var repData = await (from sales in this.applicationDbContext.SalesOrderReports
                                     where sales.EmployeeId == 9
                                     group sales by sales.OrderDateTime
                                     into GroupedData
                                     orderby GroupedData.Key
                                     select new GroupedFieldPriceModel
                                     {
                                         GroupedFieldKey = (GroupedData.Key == 1 ? "Jan":
                                                            GroupedData.Key == 2 ? "Feb": 
                                                            GroupedData.Key == 3 ? "Mar":
                                                            GroupedData.Key == 4 ? "Apr":
                                                            GroupedData.Key == 5 ? "May":
                                                            GroupedData.Key == 6 ? "Jun":
                                                            GroupedData.Key == 7 ? "Jul":
                                                            GroupedData.Key == 8 ? "Aug" :
                                                            GroupedData.Key == 9 ? "Sep" :
                                                            GroupedData.Key == 10 ? "Oct" :
                                                            GroupedData.Key == 11 ? "Nov" :
                                                            GroupedData.Key == 12 ? "Dec" :
                                                            ""),
                                        Price = Math.Round(GroupedData.Sum(o => o.OrderItemPrice), 2)
                                     }).ToArrayAsync();
                return repData;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
