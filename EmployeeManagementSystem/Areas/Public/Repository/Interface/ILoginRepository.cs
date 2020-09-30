using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Public.Repository.Interface
{
    public interface ILoginRepository
    {
        User Add(User user);
        User GetUser(User user);
    }
}
