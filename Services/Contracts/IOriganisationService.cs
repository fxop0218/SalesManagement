using SalesManagment.Models;

namespace SalesManagment.Services.Contracts
{
    public interface IOriganisationService
    {
        Task<List<OrganisationModel>> GetHierarchy();
    }
}
