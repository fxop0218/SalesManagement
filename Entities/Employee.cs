﻿namespace SalesManagment.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string JobTitle { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? ReportToEmpId { get; set; }
        public string ImagePath { get; set; }
        public int EmployeeJobTitleId { get; set; }
    }
}
