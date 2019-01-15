using System.ComponentModel.DataAnnotations;

namespace EmployeeManagerWithEFCore.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string FirstName { get; set; }
        [MaxLength(60)]
        public string LastName { get; set; }
        [Required]
        public int Salary { get; set; }
        [Required]
        [MaxLength(20)]
        public string Title { get; set; }
    }
}
