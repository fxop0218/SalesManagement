using System.ComponentModel.DataAnnotations;

namespace SalesManagment.Entities
{
    public class EmployeeJobTitle
    {
        [Key]
        public int EmployeeTitleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 

    }
}
