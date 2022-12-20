using Microsoft.Data.SqlClient;
using SalesManagment.Data;
using SalesManagment.Extensions;
using SalesManagment.Models;
using SalesManagment.Services.Contracts;

namespace SalesManagment.Services
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext applicationDbContext;

        public ClientService(ApplicationDbContext applicationDbContext)
        {
               this.applicationDbContext = applicationDbContext;
        }          
        public async Task<List<ClientModel>> GetClient()
        {
			try
			{
                return await this.applicationDbContext.Clients.Convert(applicationDbContext);
            }
			catch (Exception)
			{

				throw;
			}
        }
    }
}
