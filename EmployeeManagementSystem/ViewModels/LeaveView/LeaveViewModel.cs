using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModels
{
    public class LeaveViewModel
    {
        public int Id { get; set; }
        public IEnumerable<Leave> Leaves { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime From { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime To { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }
        [Display(Name = "Employee")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public List<SelectListItem> UserNames { get; set; }
    }
}
