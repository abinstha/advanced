using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Interface
{
    public interface ISalaryRepository
    {
        Salary GetSalary(int id);
        IEnumerable<Salary> GetSalaries();
        Salary Add(Salary salary);
        Salary Update(Salary salary);
        Salary Delete(int id);
    }
}
