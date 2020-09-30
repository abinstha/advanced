using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("admin/home")]
    public class DashboardController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogOut()
        {

            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login", new { area = "Public" });
        }
    }
}