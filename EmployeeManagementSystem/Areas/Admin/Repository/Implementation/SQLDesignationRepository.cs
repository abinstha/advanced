using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Implementation
{
    public class SQLDesignationRepository : IDesignationRepository
    {
        private readonly AppDbContext _context;
        public SQLDesignationRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Designation GetDesignation(int id)
        {
            return _context.Designations.Single(d => d.Id == id);
        }
        public Designation GetEditDesignation(int id)
        {
            return _context.Designations.Find(id);
        }
        public IEnumerable<Designation> GetDesignations()
        {
            return _context.Designations;
        }
        public Designation Add(Designation designation)
        {
            _context.Designations.Add(designation);
            _context.SaveChanges();
            return designation;
        }
        public Designation Update(Designation designation)
        {
            var d = _context.Designations.Attach(designation);
            d.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return designation;
        }
        public Designation Delete (int id)
        {
            Designation d = _context.Designations.Find(id);
            if(d != null)
            {
                _context.Designations.Remove(d);
                _context.SaveChanges();
            }
            return d;
        }

        public List<SelectListItem> DesignationTitles()
        {
            return _context.Designations.Select(d => new SelectListItem
            {
                Value = d.Id.ToString(),
                Text = d.Title
            }).ToList();
        }
    }
}
