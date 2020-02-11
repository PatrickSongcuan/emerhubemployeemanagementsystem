using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmerhubEmployeeManagementSystem.Models
{
    public class UserModel
    {
        public string txtFname { get; set; }
        public string txtLname { get; set; }
        public string txtEmailAdd { get; set; }
        public string txtContactNumber { get; set; }
        public int optRole { get; set; }
    }
}