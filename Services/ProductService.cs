using SalesManagment.Data;
using SalesManagment.Extensions;
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
        public async Task<List<ProductModel>> GetProducts()
        {
            try
            {
                return await this.applicationDbContext.Products.Convert(applicationDbContext);
            }
            catch (Exception)
            {

                throw;
            }
                  
        }
    }
}
