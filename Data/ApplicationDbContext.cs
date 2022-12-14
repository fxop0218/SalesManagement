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

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeJobTitle> EmployeeJobTitles { get; set; }
    }
}
