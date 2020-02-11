using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmerhubEmployeeManagementSystem.Controllers
{
    public class PayrollController : Controller
    {
        // GET: Payroll
        public ActionResult PayrollManagement()
        {
            return View();
        }
        public ActionResult PayrollHistory()
        {
            return View();
        }
    }
}