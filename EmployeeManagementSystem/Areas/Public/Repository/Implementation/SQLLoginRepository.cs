using EmployeeManagementSystem.Areas.Public.Repository.Interface;
using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Public.Repository.Implementation
{
    public class SQLLoginRepository : ILoginRepository
    {
        private readonly AppDbContext _context;
        public SQLLoginRepository (AppDbContext context)
        {
            this._context = context;
        }
        public User Add (User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User GetUser(User user)
        {
            return _context.Users.SingleOrDefault(a => a.Email.Equals(user.Email) && 
                    a.Password.Equals(user.Password) && a.IsAdmin == true);
        }
    }
}
