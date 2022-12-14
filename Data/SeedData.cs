using Microsoft.EntityFrameworkCore;
using SalesManagment.Entities;

namespace SalesManagment.Data
{
    public static class SeedData
    {
        public static void AddEmployeeData(ModelBuilder modelBuilder)
        {
            //Add Employee Job Titles
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeJobTitleId = 1,
                Name = "SM",
                Description = "Sales Manager"

            });
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeJobTitleId = 2,
                Name = "TL",
                Description = "Team Leader"

            });
            modelBuilder.Entity<EmployeeJobTitle>().HasData(new EmployeeJobTitle
            {
                EmployeeJobTitleId = 3,
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
    }
}