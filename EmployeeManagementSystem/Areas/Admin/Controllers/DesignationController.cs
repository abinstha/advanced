using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModels;
using EmployeeManagementSystem.ViewModels.DesignationView;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/designation")]
    public class DesignationController : Controller
    {
        private readonly IDesignationRepository _IDesignationRepo;
        public DesignationController( IDesignationRepository IDesignationRepo)
        {
            _IDesignationRepo = IDesignationRepo;
        }
        [Route("index")]
        public IActionResult Index()
        {
            IEnumerable<Designation> items = _IDesignationRepo.GetDesignations();
            var view = new DesignationViewModel
            {
                Designations = items,
            };
            return View(view);
        }
        [HttpGet]
        [Route("create")]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        [Route("create")]
        public IActionResult Create(DesignationViewModel designation)
        {
            if (ModelState.IsValid)
            {
                Designation d = new Designation
                {
                    Title = designation.Title,
                    Responsibilities = designation.Responsibilities,
                };
                _IDesignationRepo.Add(d);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        [Route("edit/{id?}")]
        public IActionResult Edit(int id)
        {
            Designation designation = _IDesignationRepo.GetEditDesignation(id);
            DesignationEditViewModel dvm = new DesignationEditViewModel
            {
                Id = designation.Id,
                Title = designation.Title,
                Responsibilities = designation.Responsibilities,
            };
            return View(dvm);
        }
        [HttpPost]
        public IActionResult Update(DesignationEditViewModel editData)
        {
            if (ModelState.IsValid)
            {
                Designation designation = _IDesignationRepo.GetEditDesignation(editData.Id);
                designation.Title = editData.Title;
                designation.Responsibilities = editData.Responsibilities;
                _IDesignationRepo.Update(designation);
                return RedirectToAction("Index");
            }
            return View(editData);
        }
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Designation des = _IDesignationRepo.Delete(id);
            if (des == null)
            {

            }
            return RedirectToAction("Index");
        }
        [Route("details/{id?}")]
        public ViewResult Details(int id)
        {
            Designation designation = _IDesignationRepo.GetEditDesignation(id);
            DesignationDetailsViewModel dvm = new DesignationDetailsViewModel
            {
                Designation = designation,
            };
            return View(dvm);
        }
    }
}