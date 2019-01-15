using System;
using System.Collections.Generic;

namespace EmployeeManagerWithEFCore.Models
{
    public class Department
    {
        public Department()
        {
            Employees = new List<Employee>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
