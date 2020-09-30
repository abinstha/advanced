using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{
    public class Designation
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Responsibilities { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Vacancy> Vacancies { get; set; }
    }
}
