using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModels
{
    public class VacancyViewModel
    {
        public IEnumerable<Vacancy> Vacancies { get; set; }

        [Required]
        [Display(Name = "No. of Vacancies")]
        public int NumberOfVacancy { get; set; }

        [Required]
        [Display(Name = "Deadline")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}",
               ApplyFormatInEditMode = true)]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Description")]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Job Specification")]
        public string Specification { get; set; }
        
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
