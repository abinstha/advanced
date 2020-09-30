using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Areas.Public.Repository.Interface;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModels;
using EmployeeManagementSystem.ViewModels.LeaveView;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/leave")]
    public class LeaveController : Controller
    {
        private readonly IUserRepository _IUserRepo;
        private readonly ILeaveRepository _ILeaveRepo;
        private readonly IDesignationRepository _IDesiRepo;
        private readonly IDepartmentRepository _IDepartRepo;
        public LeaveController (IUserRepository IUserRepo, ILeaveRepository ILeaveRepo, IDesignationRepository IDesiRepo, IDepartmentRepository IDepartRepo)
        {
            this._IUserRepo = IUserRepo;
            this._ILeaveRepo = ILeaveRepo;
            this._IDesiRepo = IDesiRepo;
            this._IDepartRepo = IDepartRepo;
        }
        [Route("")]
        public IActionResult Index()
        {
            IEnumerable<Leave> leaves = _ILeaveRepo.GetLeaves();
            LeaveViewModel lvm = new LeaveViewModel
            {
                Leaves = leaves,
            };
            return View(lvm);
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            var userNames = _IUserRepo.UserNames();
            var viewData = new LeaveViewModel
            {
                UserNames = userNames,
            };
            return View(viewData);
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(LeaveViewModel leave)
        {
            if (ModelState.IsValid)
            {
                User user = _IUserRepo.GetUserDetails(leave.UserId);
                Leave l = new Leave
                {
                    User = user,
                    From = leave.From,
                    To = leave.To,
                    Description = leave.Description
                };
                _ILeaveRepo.Add(l);
                return RedirectToAction("Index");
            }
            return RedirectToAction("Create");
        }
        [HttpGet]
        [Route("delete/{id?}")]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Leave dep = _ILeaveRepo.Delete(id);
            if (dep == null)
            {

            }
            return RedirectToAction("Index");
        }
        [Route("details/{id?}")]
        public ViewResult Details(int id)
        {
            Leave leave = _ILeaveRepo.GetLeave(id);
            LeaveDetailsViewModel vvm = new LeaveDetailsViewModel
            {
                Leave = leave,
            };
            return View(vvm);
        }
        [HttpGet]
        [Route("edit/{id}")]
        public ViewResult Edit(int id)
        {
            var userNames = _IUserRepo.UserNames();
            Leave leaves = _ILeaveRepo.GetLeave(id);
            LeaveEditViewModel svm = new LeaveEditViewModel
            {
                Id = leaves.Id,
                From = leaves.From,
                To = leaves.To,
                Description = leaves.Description,
                UserNames = userNames,
            };
            return View(svm);
        }
        [HttpPost]
        public IActionResult Update(LeaveEditViewModel newData)
        {
            if (ModelState.IsValid)
            {
                Leave leave = _ILeaveRepo.GetLeave(newData.Id);
                User user = _IUserRepo.GetEditData(newData.UserId);
                leave.From = newData.From;
                leave.To = newData.To;
                leave.Description = newData.Description;
                leave.User = user;
                
                _ILeaveRepo.Update(leave);
                return RedirectToAction("Index");
            }
            return View("Edit", newData);
        }
    }
}