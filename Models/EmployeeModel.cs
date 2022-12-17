using System.ComponentModel.DataAnnotations;

namespace SalesManagment.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(40, ErrorMessage= "The {0} value cannot exceed {1} characters", MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(40, ErrorMessage = "The {0} value cannot exceed {1} characters", MinimumLength = 2)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? ReportToEmpId { get; set; }
        public string ImagePath { get; set; }
        public int EmployeeTitleId { get; set; }
    }
}
