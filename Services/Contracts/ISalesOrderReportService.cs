using SalesManagment.Models.ReportModels;

namespace SalesManagment.Services.Contracts
{
    public interface ISalesOrderReportService
    {
        // Sales Representative
        Task<List<GroupedFieldQuantityModel>> GetQuantityPerCategory();
        Task<List<GroupedFieldPriceModel>> GetEmployeePricePerMonth();
        Task<List<GroupedFieldQuantityModel>> GetQuantitiyPerMonth();

        // Team leader

        Task<List<GroupedFieldPriceModel>> GetGrossSalerPerMember();
        Task<List<GroupedFieldQuantityModel>> GetQuantityPerMember();
        Task<List<GroupedFieldQuantityModel>> GetTeamQuantityMonth();
        // Sales leader

        Task<List<LocationProductCategoryModel>> GetQuantityLocationProduct();
        Task<List<GroupedFieldQuantityModel>> GetQuantityPerLocation();
        Task<List<MonthLocationModel>> GetQuantityPerMonthLocation();

    }
}
