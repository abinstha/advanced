using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using EmployeeManagementSystem.Areas.Admin.Repository.Interface;
using EmployeeManagementSystem.Areas.Public.Repository.Interface;
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.ViewModels;
using EmployeeManagementSystem.ViewModels.UserView;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/user")]
    public class UserController : Controller
    {
        private readonly IUserRepository _IUserRepo;
        private readonly IDesignationRepository _IDesiRepo;
        private readonly IDepartmentRepository _IDepartRepo;
        private readonly IHostingEnvironment _hostingEnvironment;
        public UserController(IUserRepository IUserRepo, IDepartmentRepository IDepartRepo, IDesignationRepository IDesiRepo, IHostingEnvironment hostingEnv)
        {
            this._IUserRepo = IUserRepo;
            this._IDepartRepo = IDepartRepo;
            this._IDesiRepo = IDesiRepo;
            this._hostingEnvironment = hostingEnv;
        }
        [Route("")]
        public ViewResult Index()
        {

            IEnumerable<User> users = _IUserRepo.GetUsers();

            UserViewModel uvm = new UserViewModel
            {
                Users = users,
            };
            return View(uvm);
        }

        [HttpGet]
        [Route("create")]
        public ViewResult Create()
        {
            var departmentTitles = _IDepartRepo.DepartmentTitles();
            var designationTitles = _IDesiRepo.DesignationTitles();
            var viewData = new UserViewModel
            {
                Departments = departmentTitles,
                Designations = designationTitles,
            };
            return View(viewData);
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(UserViewModel user)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (user.Photo != null)
                {
                    string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "dist/img/user");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + user.Photo.FileName;
                    string path = Path.Combine(uploadFolder, uniqueFileName);
                    user.Photo.CopyTo(new FileStream(path, FileMode.Create));
                }
                Department newDepartment = _IDepartRepo.GetDepartment(user.DepartmentId);
                Designation newDesignation = _IDesiRepo.GetDesignation(user.DesignationId);
                User e = new User();
                e = new User
                {
                    Name = user.Name,
                    Gender = 0,
                    Dob = user.Dob,
                    Address = user.Address,
                    Email = user.Email,
                    Mobile = user.Mobile,
                    PhotoPath = uniqueFileName,
                    Department = newDepartment,
                    Designation = newDesignation,
                    Password = e.Encrypt(user.Password)
                };
                _IUserRepo.Add(e);
                return RedirectToAction("Index");
            }
            return View(user);
        }
        [Route("edit/{id}")]
        [HttpGet]
        public ViewResult Edit(int id)
        {
            User user = _IUserRepo.GetUserDetails(id);
            var designationTitles = _IDesiRepo.DesignationTitles();
            var deparmentTitle = _IDepartRepo.DepartmentTitles();
            UserEditViewModel empVM = new UserEditViewModel
            {

                Id = user.Id,
                Name = user.Name,
                Gender = 0,
                Email = user.Email,
                Dob = user.Dob,
                Address = user.Address,
                Mobile = user.Mobile,
                Department = user.Department,
                Designations = designationTitles,
                Departments = deparmentTitle,
                ExistingPhotoPath = user.PhotoPath
            };
            return View(empVM);
        }
        [HttpGet]
        [Route("delete/{id?}")]
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = _IUserRepo.Delete(id);
            if (user == null)
            {

            }
            return RedirectToAction("Index");
        }
        [Route("details/{id?}")]
        public ViewResult Details(int id)
        {
            User user = _IUserRepo.GetUserDetails(id);
            UserDetailsViewModel userDetails = new UserDetailsViewModel
            {
                user = user,
            };
            return View(userDetails);
        }
    }
}