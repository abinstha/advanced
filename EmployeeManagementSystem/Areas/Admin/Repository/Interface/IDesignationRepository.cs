using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Interface
{
    public interface IDesignationRepository
    {
        Designation GetDesignation(int id);
        Designation GetEditDesignation(int id);
        IEnumerable<Designation> GetDesignations();
        Designation Add(Designation designation);
        Designation Update(Designation designation);
        Designation Delete(int id);
        List<SelectListItem> DesignationTitles();
    }
}
