using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModels;
using EmployeeManagementSystem.ViewModels.DepartmentView;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/department")]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _IDepartRepo;
        public DepartmentController(IDepartmentRepository IDepartRepo)
        {
            _IDepartRepo = IDepartRepo;
        }
        [Route("")]
        public IActionResult Index()
        { 
            IEnumerable<Department> model = _IDepartRepo.GetDepartments();
            var view = new DepartmentViewModel
            {
                Departments = model,
            };
            return View(view);
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(DepartmentViewModel department)
        {
            if (ModelState.IsValid)
            {
                Department d = new Department
                {
                    Name = department.Name,
                    Address = department.Address,
                    Contact = department.Contact,
                    Email = department.Email,
                    DepartmentHead = department.DepartmentHead
                };
                _IDepartRepo.Add(d);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        [Route("edit/{id?}")]
        public ViewResult Edit(int id)
        {
            Department department = _IDepartRepo.GetEditDepartment(id);
            DepartmentEditViewModel dvm = new DepartmentEditViewModel
            {
                Id = department.Id,
                Name = department.Name,
                Address = department.Address,
                Email = department.Email,
                Contact = department.Contact,
                DepartmentHead = department.DepartmentHead,
            };
            return View(dvm);
        }
        [HttpPost]        
        public IActionResult Update(DepartmentEditViewModel editData)
        {
            if (ModelState.IsValid)
            {
                Department d = _IDepartRepo.GetEditDepartment(editData.Id);
                d.Name = editData.Name;
                d.Email = editData.Email;
                d.Address = editData.Address;
                d.Contact = editData.Contact;
                d.DepartmentHead = editData.DepartmentHead;
                _IDepartRepo.Update(d);
                return RedirectToAction("Index");
            }
            return View(editData);
        }
        [HttpGet]
        [Route("details/{id?}")]
        public ViewResult Details(int id)
        {
            Department department = _IDepartRepo.GetEditDepartment(id);
            DepartmentDetailsViewModel details = new DepartmentDetailsViewModel
            {
                department = department,
            };
            return View(details);
        }
        [HttpGet]
        [Route("delete/{id?}")]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Department dep = _IDepartRepo.Delete(id);
            if (dep == null)
            {

            }
            return RedirectToAction("Index");
        }
    }
}