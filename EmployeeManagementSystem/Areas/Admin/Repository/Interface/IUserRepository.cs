using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace EmployeeManagementSystem.Areas.Public.Repository.Interface
{
    public interface IUserRepository
    {
        User Add(User user);
        User GetUser(User user);
        User GetUserDetails(int id);
        List<SelectListItem> UserNames();
        IEnumerable<User> GetUsers();
        User Delete(int id);
        User GetEditData(int id);
    }
}
