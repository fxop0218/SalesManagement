using SalesManagment.Models;
using SalesManagment.Services.Contracts;
using SalesManagment.Data;
using SalesManagment.Entities;

namespace SalesManagment.Services
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext applicationDbContext;
        public OrderService(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;

        }
        public async Task CreateOrder(OrderModel orderModel)
        {
            try
            {
                Order order = new Order
                {
                    OrderDataTime = DateTime.Now,
                    ClinetId = orderModel.ClientId,
                    EmployeeId = 9,
                    Price = orderModel.OrderItems.Sum(o=>o.Price),
                    Quantity = orderModel.OrderItems.Sum(o=>o.Quantity), 
                };

                var addedOrder = await this.applicationDbContext.Orders.AddAsync(order);
                await this.applicationDbContext.SaveChangesAsync();
                int orderId = addedOrder.Entity.Id;

                var orderItemsToAdd = ReturnOrderItemsWithOrderId(orderId, orderModel.OrderItems);
                this.applicationDbContext.AddRange(orderItemsToAdd);
                await this.applicationDbContext.SaveChangesAsync();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private List<OrderItem> ReturnOrderItemsWithOrderId(int orderId, List<OrderItem> orderItems) 
        { 
            return (from oi in orderItems
                    select new OrderItem
                    {
                        OrderId = orderId,
                        Price = oi.Price,
                        Quantity = oi.Quantity,
                        ProductId= oi.ProductId,

                    }).ToList();
        }
    }
}
