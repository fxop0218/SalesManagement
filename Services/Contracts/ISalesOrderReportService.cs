using SalesManagment.Models.ReportModels;

namespace SalesManagment.Services.Contracts
{
    public interface ISalesOrderReportService
    {
        Task<List<GroupedFieldPriceModel>> GetEmployeePricePerMonth();
    }
}
