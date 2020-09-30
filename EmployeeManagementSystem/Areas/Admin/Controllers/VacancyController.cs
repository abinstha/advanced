using System;
using System.Collections.Generic;
using System.Net;
using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModels;
using EmployeeManagementSystem.ViewModels.VacancyView;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/vacancy")]
    public class VacancyController : Controller
    {
        private readonly IVacancyRepository _IVacancyRepo;
        private readonly IDepartmentRepository _IDepartRepo;
        private readonly IDesignationRepository _IDesiRepo;
        public VacancyController(IVacancyRepository IVacancyRepo, IDepartmentRepository IDepartRepo, IDesignationRepository IDesiRepo)
        {
            _IVacancyRepo = IVacancyRepo;
            _IDepartRepo = IDepartRepo;
            _IDesiRepo = IDesiRepo;
        }
        [Route("")]
        public IActionResult Index()
        {
            IEnumerable<Vacancy> vacancies = _IVacancyRepo.GetVacancies();
            var view = new VacancyViewModel
            {
                Vacancies = vacancies,
            };
            return View(view);
        }
        [HttpGet]
        [Route("create")]
        public ViewResult Create()
        {
            var departmentTitles = _IDepartRepo.DepartmentTitles();
            var designationTitles = _IDesiRepo.DesignationTitles();
            var viewData = new VacancyViewModel
            {
                Departments = departmentTitles,
                Designations = designationTitles,
            };
            return View(viewData);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public IActionResult Save(VacancyViewModel vacancy)
        {
            if (ModelState.IsValid)
            {
                Department newDepartment = _IDepartRepo.GetDepartment(vacancy.DepartmentId);
                Designation newDesignation = _IDesiRepo.GetDesignation(vacancy.DesignationId);
                Vacancy v = new Vacancy
                {
                    NumberOfVacancy = vacancy.NumberOfVacancy,
                    ExpiryDate = vacancy.ExpiryDate,
                    Description = vacancy.Description,
                    Specification = vacancy.Specification,
                    Department = newDepartment,
                    Designation = newDesignation
                };
                _IVacancyRepo.Add(v);
            }
            return RedirectToAction("Create");
        }
        [Route("edit/{id}")]
        [HttpGet]
        
        public IActionResult Edit(int id)
        {
            Vacancy vacancy = _IVacancyRepo.GetVacancy(id);
            var departmentTitles = _IDepartRepo.DepartmentTitles();
            var designationTitles = _IDesiRepo.DesignationTitles();
            var viewData = new VacancyEditViewModel
            {
                NumberOfVacancy = vacancy.NumberOfVacancy,
                ExpiryDate = vacancy.ExpiryDate,
                Description = vacancy.Description,
                Specification = vacancy.Specification,
                Departments = departmentTitles,
                Designations = designationTitles,
            };
            return View(viewData);
        }
        [Route("update/vacancy")]
        [HttpPost]
        
        public IActionResult Update(VacancyEditViewModel vacancy)
        {
            if (ModelState.IsValid)
            {
                Vacancy v = _IVacancyRepo.GetVacancy(vacancy.Id);

                Department newDepartment = _IDepartRepo.GetDepartment(vacancy.DepartmentId);
                Designation newDesignation = _IDesiRepo.GetDesignation(vacancy.DesignationId);

                v.NumberOfVacancy = vacancy.NumberOfVacancy;
                v.ExpiryDate = vacancy.ExpiryDate;
                v.Description = vacancy.Description;
                v.Specification = vacancy.Specification;
                v.Department = newDepartment;
                v.Designation = newDesignation;
                _IVacancyRepo.Update(v);
                return RedirectToAction("Index");
            }
            return View(vacancy);
        }

        [Route("details/{id?}")]
        public ViewResult Details(int id)
        {
            Vacancy vacancy = _IVacancyRepo.GetDetailVacancy(id);
            VacancyDetailsViewModel vvm = new VacancyDetailsViewModel
            {
                Vacancy = vacancy,
            };
            return View(vvm);
        }
        [HttpGet]
        [Route("delete/{id?}")]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vacancy c = _IVacancyRepo.Delete(id);
            if (c == null)
            {

            }
            return RedirectToAction("Index");
        }
    }
}