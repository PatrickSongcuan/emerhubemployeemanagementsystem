using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmerhubEmployeeManagementSystem.Controllers
{
    public partial class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult ManageUsers()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddUser()
        {
            return View();
        }
        public ActionResult EditUser(int userId)
        {
            return View();
        }
    }
}