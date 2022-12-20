using SalesManagment.Models;

namespace SalesManagment.Services.Contracts
{
    public interface IOrderService
    {
        Task CreateOrder(OrderModel orderModel); 
    }
}
