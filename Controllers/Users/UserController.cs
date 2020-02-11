using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmerhubEmployeeManagementSystem.Controllers
{
    public partial class UserController : Controller
    {
        // GET: User
        public ActionResult ManageCompanies()
        {
            return View();
        }

        public ActionResult AddCompany()
        {
            return View();
        }

        public ActionResult EditCompany(string companyId)
        {
            return View();
        }

        public ActionResult ManageEmployees()
        {
            return View();
        }

        public ActionResult AddEmployees()
        {
            return View();
        }

        public ActionResult EditEmployee(string employeeId)
        {
            return View();
        }
    }
}