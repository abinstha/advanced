using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Areas.Public.Repository.Interface;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Public")]
    [Route("/register")]
    public class RegisterController : Controller
    {
        private readonly ILoginRepository _ILoginRepo;
        public RegisterController(ILoginRepository ILoginRepo)
        {
            this._ILoginRepo = ILoginRepo;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}