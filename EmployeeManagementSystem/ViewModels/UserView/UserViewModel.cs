using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.ViewModels
{
    public enum Gender
    {
        Male,
        Female,
        Others
    }
    public class UserViewModel
    {
        public IEnumerable<User> Users { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
               ApplyFormatInEditMode = true)]
        public DateTime Dob { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Contact")]
        public string Mobile { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "{0} must be greater than {1} characters")]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public string PhotoPath { get; set; }
        public IFormFile Photo { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        [Display(Name = "Designation")]
        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }

        public List<SelectListItem> Designations { get; set; }

        public List<SelectListItem> Departments { get; set; }
    }
}
