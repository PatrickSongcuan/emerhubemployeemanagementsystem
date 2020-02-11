using EmerhubEmployeeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmerhubEmployeeManagementSystem.Controllers
{
    public partial class AdminController : Controller
    {
        // GET: _post
        [HttpPost]
        public ActionResult AddUser(UserModel xModel)
        {
            var x = xModel.txtFname;
            var y = xModel.txtLname;

            return View();
        }
    }
}