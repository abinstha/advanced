using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name="Department")]
        public string Name { get; set; }

        [Display(Name="Head of Department")]
        public string DepartmentHead { get; set; }

        [Display(Name="Department Address")]
        public string Address { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name="Department Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name ="Department Contact Number")]
        public string Contact { get; set; }

        internal Department Include()
        {
            throw new NotImplementedException();
        }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
