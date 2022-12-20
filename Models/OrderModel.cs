using SalesManagment.Entities;

namespace SalesManagment.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public DateTime OrderDataTime { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public List<OrderItem> OrderItems { get; set; }

    }
}
