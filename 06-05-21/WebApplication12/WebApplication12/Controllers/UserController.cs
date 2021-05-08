using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class UserController : Controller
    {
        private readonly User[] Userdata =
        {
            new User { FirstName="Edy" ,Role=Role.Admin},
            new User { FirstName="Joe" ,Role=Role.Normal},
            new User { FirstName="Edy" ,Role=Role.Guest},
            new User { FirstName="Edy" ,Role=Role.Normal}

        };
        public IActionResult Index()
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