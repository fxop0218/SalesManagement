using Microsoft.EntityFrameworkCore.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace SalesManagment.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ImgPath { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
