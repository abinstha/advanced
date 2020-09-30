using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Vacancy
    {
        public int Id { get; set; }

        [Required]
        public int NumberOfVacancy { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Specification { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }
    }
}
