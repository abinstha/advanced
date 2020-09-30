using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModels
{
    public class DesignationViewModel
    {
        public IEnumerable<Designation> Designations { get; set; }
        public Designation designation { get; set; }
        [Required]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Responsibilities { get; set; }
    }
}
