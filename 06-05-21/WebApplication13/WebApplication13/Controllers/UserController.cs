using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        private readonly User[] Userdata =
       {
            new User { FirstName="Edy" ,Role=Role.Admin},
            new User { FirstName="Joe" ,Role=Role.Normal},
            new User { FirstName="Ey" ,Role=Role.Guest},
            new User { FirstName="Edy" ,Role=Role.Normal}

        };
        public ActionResult Index()
        {
            return View(Userdata);
        }
        public PartialViewResult GetUserData(string selectedRole = "All")
        {
            IEnumerable data = Userdata;
            if (selectedRole != "All")
            {
                var selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                data = Userdata.Where(p => p.Role == selected);
            }
            return PartialView(data);
        }
        public ActionResult GetUser(string selectedRole = "All")
        {
            return View((object)selectedRole);
        }
    }
}