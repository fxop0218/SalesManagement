using SalesManagment.Models.ReportModels;

namespace SalesManagment.Services.Contracts
{
    public interface ISalesOrderReportService
    {
        Task<List<GroupedFieldQuantityModel>> GetQuantityPerCategory();
        Task<List<GroupedFieldPriceModel>> GetEmployeePricePerMonth();
        Task<List<GroupedFieldQuantityModel>> GetQuantitiyPerMonth();
    }
}
