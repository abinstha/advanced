using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.ViewModels.UserView
{
    public class UserDetailsViewModel
    {
        public User user { get; set; }
        public IFormFile Photo { get; set; }
    }
}
