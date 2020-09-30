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
    public class SQLVacancyRepository : IVacancyRepository
    {
        private readonly AppDbContext _context;
        public SQLVacancyRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Vacancy GetVacancy(int id)
        {
            return _context.Vacancies.Find(id);
        }
        public Vacancy GetDetailVacancy(int id)
        {
            return _context.Vacancies
                            .Include(v => v.Department)
                            .Include(v => v.Designation)
                            .SingleOrDefault(v => v.Id == id);
        }
        public IEnumerable<Vacancy> GetVacancies()
        {
            return _context.Vacancies
                           .Include(v => v.Department)
                           .Include(v => v.Designation);
        }
        public Vacancy Add(Vacancy vacancy)
        {
            _context.Vacancies.Add(vacancy);
            _context.SaveChanges();
            return vacancy;
        }
        public Vacancy Update(Vacancy vacancy)
        {
            var v = _context.Vacancies.Attach(vacancy);
            v.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return vacancy;
        }
        public Vacancy Delete (int id)
        {
            Vacancy v = _context.Vacancies.Find(id);
            if(v != null)
            {
                _context.Vacancies.Remove(v);
                _context.SaveChanges();
            }
            return v;
        }
        
        
    }
}
