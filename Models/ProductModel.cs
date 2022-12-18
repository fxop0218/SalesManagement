namespace SalesManagment.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ImgPath { get; set; }
        public decimal Price { get; set; }
    }
}
