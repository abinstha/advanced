using EmployeeManagementSystem.Areas.Admin.Includes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Models
{

    public class User : Encryption
    {       

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public int Gender { get; set; }

        [Required]
        [Column(TypeName = "Date")]
        public DateTime Dob { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "{0} must be greater than {1} characters")]
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public string PhotoPath { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public int DesignationId { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual ICollection<Leave> Leaves { get; set; }
    }
}
