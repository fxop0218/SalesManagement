using SalesManagment.Models;

namespace SalesManagment.Services.Contracts
{
    public interface IClientService
    {
        Task<List<ClientModel>> GetClient();
    }
}
