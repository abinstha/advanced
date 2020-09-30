using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Implementation
{
    [Area("Admin")]
    public class SQLDepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public SQLDepartmentRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Department GetDepartment(int id)
        {
            return _context.Departments.Single(d => d.Id == id);
        }
        public Department GetEditDepartment(int id)
        {
            return _context.Departments.Find(id);
        }
        public List<Department> GetDepartments()
        {
            return _context.Departments.Include(d => d.Users).ToList();
        }
        public Department Add(Department department)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return department;
        }
        public Department Update(Department department)
        {
            var dep = _context.Departments.Attach(department);
            dep.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return department;
        }
        public Department Delete(int id)
        {
            Department dep = _context.Departments.Find(id);
            if(dep != null)
            {
                _context.Departments.Remove(dep);
                _context.SaveChanges();
            }
            return dep;
        }
        public List<SelectListItem> DepartmentTitles()
        {
            return _context.Departments.Select(m => new SelectListItem
            {
                Value = m.Id.ToString(),
                Text = m.Name,
            }).ToList();
        }
    }
}
