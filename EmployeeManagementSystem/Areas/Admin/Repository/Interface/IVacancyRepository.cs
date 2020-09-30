using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Interface
{
    public interface IVacancyRepository
    {
        Vacancy GetVacancy(int id);
        IEnumerable<Vacancy> GetVacancies();
        Vacancy Add(Vacancy vacancy);
        Vacancy Update(Vacancy vacancy);
        Vacancy Delete(int id);
        Vacancy GetDetailVacancy(int id);
    }
}
