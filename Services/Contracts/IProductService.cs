using SalesManagment.Models;

namespace SalesManagment.Services.Contracts
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProducts();
    }
}
