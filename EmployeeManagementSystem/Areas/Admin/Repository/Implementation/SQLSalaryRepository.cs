using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Implementation
{
    public class SQLSalaryRepository : ISalaryRepository
    {
        private readonly AppDbContext _context;
        public SQLSalaryRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Salary GetSalary(int id)
        {
            return _context.Salaries.Find(id);
        }
        public IEnumerable<Salary> GetSalaries()
        {
            return _context.Salaries.Include(c => c.Designation);
        }
        public Salary Add(Salary salary)
        {
            _context.Salaries.Add(salary);
            _context.SaveChanges();
            return salary;
        }
        public Salary Update(Salary salary)
        {
            var s = _context.Salaries.Attach(salary);
            s.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return salary;
        }
        public Salary Delete(int id)
        {
            Salary s = _context.Salaries.Find(id);
            if(s != null)
            {
                _context.Salaries.Remove(s);
                _context.SaveChanges();
            }
            return s;
        }
    }
}
