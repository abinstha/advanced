using System.Collections.Generic;
using System.Net;
using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModels;
using EmployeeManagementSystem.ViewModels.SalaryView;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/salary")]
    public class SalaryController : Controller
    {
        private readonly ISalaryRepository _ISalaryRepo;
        private readonly IDesignationRepository _IDesiRepo;
        public SalaryController(ISalaryRepository ISalaryRepo, IDesignationRepository IDesiRepo)
        {
            this._ISalaryRepo = ISalaryRepo;
            this._IDesiRepo = IDesiRepo;
        }
        [Route("")]
        public IActionResult Index()
        {
            IEnumerable<Salary> salaries = _ISalaryRepo.GetSalaries();
            SalaryViewModel svm = new SalaryViewModel
            {
                Salaries = salaries,
            };
            return View(svm);
        }
        [HttpGet]
        [Route("create")]
        public ViewResult Create()
        {
            var designationTitles = _IDesiRepo.DesignationTitles();
            SalaryViewModel viewData = new SalaryViewModel
            {
                Designations = designationTitles,
            };
            return View(viewData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public IActionResult Create(SalaryViewModel salary)
        {
            if (ModelState.IsValid)
            {
                Designation newDesignation = _IDesiRepo.GetDesignation(salary.DesignationId);
                Salary s = new Salary
                {
                    Designation = newDesignation,
                    SalaryAmount = salary.SalaryAmount,
                };
                _ISalaryRepo.Add(s);
                return RedirectToAction("Index");
            }
            return View(salary);
        }
        [HttpGet]
        [Route("edit/{id}")]
        public ViewResult Edit(int id)
        {
            var designationTitles = _IDesiRepo.DesignationTitles();
            Salary salary = _ISalaryRepo.GetSalary(id);
            SalaryEditViewModel svm = new SalaryEditViewModel
            {
                SalaryAmount = salary.SalaryAmount,
                Designations = designationTitles,
            };
            return View(svm);
        }
        [HttpPost]
        public IActionResult Update(SalaryEditViewModel newData)
        {
            if (ModelState.IsValid)
            {
                Salary salary = _ISalaryRepo.GetSalary(newData.Id);
                Designation newDesignation = _IDesiRepo.GetDesignation(newData.DesignationId);
                salary.SalaryAmount = newData.SalaryAmount;
                salary.Designation = newDesignation;
                _ISalaryRepo.Update(salary);
                return RedirectToAction("Index");
            }
            return View("Edit", newData);
        }
        [HttpGet]
        [Route("delete/{id?}")]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salary sal = _ISalaryRepo.Delete(id);
            if (sal == null)
            {

            }
            return RedirectToAction("Index");
        }
    }
}