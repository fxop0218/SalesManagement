namespace SalesManagment.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDataTime { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int EmployeeId { get; set; }
        public int ClinetId { get; set; }
    }
}
