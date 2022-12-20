using Microsoft.EntityFrameworkCore;
using SalesManagment.Entities;
using System.Reflection.Emit;

namespace SalesManagment.Data
{
    public static class SeedData
    {
        public static void AddEmployeeData(ModelBuilder modelBuilder)
        {
            //Add Employee Job Titles
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeTitleId = 1,
                Name = "SM",
                Description = "Sales Manager"

            });
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeTitleId = 2,
                Name = "TL",
                Description = "Team Leader"

            });
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeTitleId = 3,
                Name = "SR",
                Description = "Sales Rep"

            });
            //Add Employees
            //Sales Manager
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 1,
                FirstName = "Bob",
                Surname = "Jones",
                Email = "bob.jones@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("10 Feb 1974"),
                ReportToEmpId = null,
                ImagePath = "/Images/Profile/BobJones.jpg",
                EmployeeTitleId = 1

            });
            //Team Leaders
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 2,
                FirstName = "Jenny",
                Surname = "Marks",
                Email = "jenny.marks@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("06 May 1976"),
                ReportToEmpId = 1,
                ImagePath = "/Images/Profile/JennyMarks.jpg",
                EmployeeTitleId = 2

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 3,
                FirstName = "Henry",
                Surname = "Andrews",
                Email = "henry.andrews@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("06 May 1981"),
                ReportToEmpId = 1,
                ImagePath = "/Images/Profile/HenryAndrews.jpg",
                EmployeeTitleId = 2

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 4,
                FirstName = "John",
                Surname = "Jameson",
                Email = "john.jameson@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("17 Apr 1984"),
                ReportToEmpId = 1,
                ImagePath = "/Images/Profile/JohnJameson.jpg",
                EmployeeTitleId = 2

            });
            //Sales Reps
            //Sales Team for Team Leader Name: Jenny, Id: 2
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 5,
                FirstName = "Noah",
                Surname = "Robinson",
                Email = "noah.robinson@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("12 Feb 1993"),
                ReportToEmpId = 2,
                ImagePath = "/Images/Profile/NoahRobinson.jpg",
                EmployeeTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 6,
                FirstName = "Elijah",
                Surname = "Hamilton",
                Email = "elijah.hamilton@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("17 Jun 1993"),
                ReportToEmpId = 2,
                ImagePath = "/Images/Profile/ElijahHamilton.jpg",
                EmployeeTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 7,
                FirstName = "Jamie",
                Surname = "Fisher",
                Email = "jamie.fisher@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("13 Jul 1992"),
                ReportToEmpId = 2,
                ImagePath = "/Images/Profile/JamieFisher.jpg",
                EmployeeTitleId = 3

            });
            //Sales Team for Team Leader Name: Henry, Id: 3

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 8,
                FirstName = "Olivia",
                Surname = "Mills",
                Email = "olivia.mills@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("17 Apr 1990"),
                ReportToEmpId = 3,
                ImagePath = "/Images/Profile/OliviaMills.jpg",
                EmployeeTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 9,
                FirstName = "Benjamin",
                Surname = "Lucas",
                Email = "benjamin.lucas@oexl.com",
                Gender = "Male",
                DateOfBirth = DateTime.Parse("12 Feb 1993"),
                ReportToEmpId = 3,
                ImagePath = "/Images/Profile/BenjaminLucas.jpg",
                EmployeeTitleId = 3

            });

            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 10,
                FirstName = "Sarah",
                Surname = "Henderson",
                Email = "sarah.henderson@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("12 Aug 1993"),
                ReportToEmpId = 3,
                ImagePath = "/Images/Profile/SarahHenderson.jpg",
                EmployeeTitleId = 3

            });
            //Sales Team for Team Leader Name: John, Id: 4          
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 11,
                FirstName = "Emma",
                Surname = "Lee",
                Email = "emma.lee@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("12 Nov 1995"),
                ReportToEmpId = 4,
                ImagePath = "/Images/Profile/EmmaLee.jpg",
                EmployeeTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 12,
                FirstName = "Ava",
                Surname = "Williams",
                Email = "ava.williams@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("12 May 1998"),
                ReportToEmpId = 4,
                ImagePath = "/Images/Profile/AvaWilliams.jpg",
                EmployeeTitleId = 3

            });
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                Id = 13,
                FirstName = "Angela",
                Surname = "Moore",
                Email = "angela.moore@oexl.com",
                Gender = "Female",
                DateOfBirth = DateTime.Parse("06 Jul 1994"),
                ReportToEmpId = 4,
                ImagePath = "/Images/Profile/AngelaMoore.jpg",
                EmployeeTitleId = 3

            });
        }
    
        public static void AddProductData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "CPU"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "GPU"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Mobiles"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Computers"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 5,
                Name = "RAM"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 6,
                Name = "SSD"

            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 7,
                Name = "motherboard"

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "i5 13600K",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/13600k.jpg",
                Price = 200,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "I7-13700K ",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/13700k.jpg",
                Price = 210,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "RTX 2080 FE",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/rtx2080.jpg",
                Price = 500,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "RTX 3080 FE",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/rtx3080.jpg",
                Price = 800,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "RTX 4080 FE",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/rtx4080.jpg",
                Price = 252,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "RTX 4090 FE",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/rtx4090.jpg",
                Price = 2000,
                CategoryId = 2

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "POCO F1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/pf1.jpg",
                Price = 230,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Samsung s22",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/s22.jpg",
                Price = 600,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "IPhone13",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/IPhone13.jpg",
                Price = 1000,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "IPhone14",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/IPhone14.jpg",
                Price = 1600,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "IPhone14 PRO",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/IPhone14Pro.jpg",
                Price = 2000,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "IPhone14 ProMax",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/IPhone14ProMax.jpg",
                Price = 4000,
                CategoryId = 3

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "MacBook",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/MacBook.jpg",
                Price = 2000,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Razer",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/Razer.jpg",
                Price = 1500,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Surface",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/Surface.jpg",
                Price = 1200,
                CategoryId = 4

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "RAM 8gb",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/ram.jpg",
                Price = 60,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "RAM 16gb",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/ram.jpg",
                Price = 100,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "RAM 32gb",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/ram.jpg",
                Price = 200,
                CategoryId = 5

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "RAM 64gb",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/ram.jpg",
                Price = 300,
                CategoryId = 5

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "SSD 1Tb",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/ssd1t.jpg",
                Price = 100,
                CategoryId = 6

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "SSD m.2 2Tb",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/m2tb.jpg",
                Price = 200,
                CategoryId = 6

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "SSD m.2 5Tb",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/m2tb.jpg",
                Price = 400,
                CategoryId = 6

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "MB 1",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/mb1.jpg",
                Price = 200,
                CategoryId = 7

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 24,
                Name = "MB 2",
                Description = "Lorem ipsum dolor sit amet. Qui esse quos est impedit ipsa et modi saepe in culpa quia. ",
                ImgPath = "/Images/Products/mb1.jpg",
                Price = 400,
                CategoryId = 7

            });
        }
        public static void AddClientData(ModelBuilder modelBuilder)
        {
            //Add Retail Outlet Data
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 1,
                Name = "Texas Outdoor Store",
                Location = "TX"
            });
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 2,
                Name = "California Outdoor Store",
                Location = "CA"
            });
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 3,
                Name = "New York Outdoor Store",
                Location = "NY"
            });
            modelBuilder.Entity<RetailOutlet>().HasData(new RetailOutlet
            {
                Id = 4,
                Name = " Washington Outdoor Store",
                Location = "WA"
            });

            //Add Client data
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 1,
                FirstName = "James",
                Surname = "Tailor",
                JobTitle = "Buyer",
                Phone = "000000000",
                Email = "james.tailor@company.com",
                RetailOutletId = 1
            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 2,
                FirstName = "Jill",
                Surname = "Hutton",
                JobTitle = "Buyer",
                Phone = "000000000",
                Email = "jill.hutton@company.com",
                RetailOutletId = 2
            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 3,
                FirstName = "Craig",
                Surname = "Rice",
                JobTitle = "Buyer",
                Phone = "000000000",
                Email = "craig.rice@company.com",
                RetailOutletId = 3
            });
            modelBuilder.Entity<Client>().HasData(new Client
            {
                Id = 4,
                FirstName = "Amy",
                Surname = "Smith",
                JobTitle = "Buyer",
                Phone = "000000000",
                Email = "amy.smith@company.com",
                RetailOutletId = 4
            });
        }
    }
}