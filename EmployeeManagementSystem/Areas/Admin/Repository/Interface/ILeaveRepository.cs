using EmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Areas.Admin.Repository.Interface
{
    public interface ILeaveRepository
    {
        Leave GetLeave(int id);
        IEnumerable<Leave> GetLeaves();
        Leave Add(Leave leave);
        Leave Update(Leave leave);
        Leave Delete(int id);
    }
}
