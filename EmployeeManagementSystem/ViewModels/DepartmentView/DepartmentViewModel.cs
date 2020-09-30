using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModels
{
    public class DepartmentViewModel
    {
        
        public IEnumerable<Department> Departments { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Department")]
        public string Name { get; set; }

        [Display(Name = "Head of Department")]
        public string DepartmentHead { get; set; }

        [Display(Name = "Department Address")]
        public string Address { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Deaprtment Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Department Contact Number")]
        public string Contact { get; set; }
    }
}
