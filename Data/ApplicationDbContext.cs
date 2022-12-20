using Microsoft.EntityFrameworkCore;
using SalesManagment.Entities;

namespace SalesManagment.Data
{
    public class ApplicationDbContext:DbContext
    {
        // ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData.AddEmployeeData(modelBuilder);
            SeedData.AddProductData(modelBuilder);
            SeedData.AddClientData(modelBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJobTitle> EmployeeJobTitles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RetailOutlet> RetailOutlets { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrederItems { get; set; }
    }
}
