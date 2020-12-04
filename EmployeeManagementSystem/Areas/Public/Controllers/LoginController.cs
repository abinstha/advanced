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
    [Route("/login")]
    [Route("")]
    public class LoginController : Controller
    {
        private readonly ILoginRepository _ILoginRepo;
        public LoginController(ILoginRepository ILoginRepo)
        {
            this._ILoginRepo = ILoginRepo;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
   
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (user.Email != null && user.Password != null)
            {
                var account = _ILoginRepo.GetUser(user);
                if (account != null)
                {
                    HttpContext.Session.SetString("email", user.Email);
                    if(account.IsAdmin == true)
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                    }else if(account.IsAdmin == false)
                    {
                        return RedirectToAction("Index", "Dashboard", new { area = "Public" });
                    }
                    
                }
            }
            ViewBag.error = "Invalid!";
            return View("Index");
        }
    }
}