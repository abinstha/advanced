using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Interface
{
    public interface IDepartmentRepository
    {
        Department GetDepartment(int id);
        Department GetEditDepartment(int id);
        List<Department> GetDepartments();
        Department Add(Department department);
        Department Update(Department department);
        Department Delete(int id);
        List<SelectListItem> DepartmentTitles();
    }
}
