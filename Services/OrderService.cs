using SalesManagment.Models;
using SalesManagment.Services.Contracts;
using SalesManagment.Data;
using SalesManagment.Entities;
using Microsoft.EntityFrameworkCore;

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
            using (var dbContextTransaction = await this.applicationDbContext.Database.BeginTransactionAsync())
            {
                try
                {
                    //var employee = await GetLoggedOnEmployee();

                    Order order = new Order
                    {
                        OrderDateTime = DateTime.Now,
                        ClientId = orderModel.ClientId,
                        EmployeeId = 9,
                        Price = orderModel.OrderItems.Sum(o => o.Price),
                        Quantity = orderModel.OrderItems.Sum(o => o.Quantity)
                    };

                    var addedOrder = await this.applicationDbContext.Orders.AddAsync(order);
                    await this.applicationDbContext.SaveChangesAsync();
                    int orderId = addedOrder.Entity.Id;

                    var orderItemsToAdd = ReturnOrderItemsWithOrderId(orderId, orderModel.OrderItems);
                    this.applicationDbContext.AddRange(orderItemsToAdd);

                    await this.applicationDbContext.SaveChangesAsync();

                    await UpdateSalesOrderReport(orderId, order);

                    await dbContextTransaction.CommitAsync();

                }

                catch (Exception)
                {
                    await dbContextTransaction.DisposeAsync();
                    throw;
                }
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

        private async Task UpdateSalesOrderReport(int orderId, Order order)
        {
            try
            {
                List<SalesOrderReport> srItems = await (from oi in this.applicationDbContext.OrderItems
                                                        where oi.OrderId == orderId
                                                        select new SalesOrderReport
                                                        {
                                                            OrderId = orderId,
                                                            OrderDateTime = order.OrderDateTime,
                                                            OrderPrice = order.Price,
                                                            OrderQty = order.Quantity,
                                                            OrderItemId = oi.Id,
                                                            OrderItemPrice = oi.Price,
                                                            OrderItemQty = oi.Quantity,
                                                            EmployeeId = order.EmployeeId,
                                                            EmployeeFirstName = applicationDbContext.Employees.FirstOrDefault(e => e.Id == order.EmployeeId).FirstName,
                                                            EmployeeSurname = applicationDbContext.Employees.FirstOrDefault(e => e.Id == order.EmployeeId).Surname,
                                                            ProductId = oi.ProductId,
                                                            ProductName = applicationDbContext.Products.FirstOrDefault(p => p.Id == oi.ProductId).Name,
                                                            ProductCategoryId = applicationDbContext.Products.FirstOrDefault(p => p.Id == oi.ProductId).CategoryId,
                                                            ProductCategoryName = applicationDbContext.ProductCategories.FirstOrDefault(c => c.Id == applicationDbContext.Products.FirstOrDefault(p => p.Id == oi.ProductId).CategoryId).Name,
                                                            ClientId = order.ClientId,
                                                            ClientFirstName = applicationDbContext.Clients.FirstOrDefault(c => c.Id == order.ClientId).FirstName, // error aqui.
                                                            ClientSurname = applicationDbContext.Clients.FirstOrDefault(c => c.Id == order.ClientId).Surname,
                                                            RetailOutletLocation = applicationDbContext.RetailOutlets.FirstOrDefault(r => r.Id == applicationDbContext.Clients.FirstOrDefault(c => c.Id == order.ClientId).RetailOutletId).Location
                                                        }).ToListAsync();
                this.applicationDbContext.AddRange(srItems);
                await this.applicationDbContext.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
