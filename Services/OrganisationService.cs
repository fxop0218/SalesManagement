using SalesManagment.Data;
using SalesManagment.Extensions;
using SalesManagment.Models;
using SalesManagment.Services.Contracts;

namespace SalesManagment.Services
{
    public class OrganisationService : IOriganisationService
    {
		private readonly ApplicationDbContext applicationDbContext;
		public OrganisationService(ApplicationDbContext applicationDbContext)
		{
			this.applicationDbContext = applicationDbContext;
		}
        public async Task<List<OrganisationModel>> GetHierarchy()
        {
			try
			{
				return await this.applicationDbContext.Employees.ConvertToH(applicationDbContext);
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
