using EmployeeManagementSystem.Areas.Public.Repository.Interface;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Public.Repository.Implementation
{
    public class SQLUserRepository : IUserRepository
    {
        private readonly AppDbContext _context;
        public SQLUserRepository (AppDbContext context)
        {
            this._context = context;
        }
        public User Add (User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user;
        }
        public User GetUserDetails(int id)
        {
            return _context.Users.Include(d => d.Department).Include(u => u.Designation).Single(d => d.Id == id);
        }
        public User GetUser(User user)
        {
            return _context.Users.SingleOrDefault(a => a.Email.Equals(user.Email) && 
                    a.Decrypt(a.Password).Equals(user.Password) && a.IsAdmin == true);
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users
                            .Include(u => u.Department)
                            .Include(u => u.Designation)
                            .Include(u => u.Designation.Salaries)
                            .Include(u => u.Leaves);
        }
        public List<SelectListItem> UserNames()
        {
            return _context.Users.Select(u => new SelectListItem
            {
                Value = u.Id.ToString(),
                Text = u.Name,
            }).ToList();
        }
        public User Delete(int id)
        {
            User v = _context.Users.Find(id);
            if (v != null)
            {
                _context.Users.Remove(v);
                _context.SaveChanges();
            }
            return v;
        }
        public User GetEditData(int id)
        {
            return _context.Users.Find(id);
        }
    }
}
