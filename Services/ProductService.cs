using SalesManagment.Data;
using SalesManagment.Models;
using SalesManagment.Services.Contracts;

namespace SalesManagment.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public ProductService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;             
        }
        public Task<List<ProductModel>> GetProducts()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
                  
        }
    }
}
