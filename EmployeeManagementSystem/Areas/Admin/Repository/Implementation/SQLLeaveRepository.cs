using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Implementation
{
    public class SQLLeaveRepository : ILeaveRepository
    {
        private readonly AppDbContext _context;
        public SQLLeaveRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Leave GetLeave(int id)
        {
            return _context.Leaves.Find(id);
        }
        public IEnumerable<Leave> GetLeaves()
        {
            return _context.Leaves.Include(l => l.User)
                                    .Include(l => l.User.Department)
                                    .Include(l => l.User.Designation);
        }
        public Leave Add(Leave leave)
        {
            _context.Leaves.Add(leave);
            _context.SaveChanges();
            return leave;
        }
        public Leave Update(Leave leave)
        {
            var l = _context.Leaves.Attach(leave);
            l.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return leave;
        }
        public Leave Delete(int id)
        {
            Leave l = _context.Leaves.Find(id);
            if(l != null)
            {
                _context.Leaves.Remove(l);
                _context.SaveChanges();
            }
            return l;
        }
    }
}
