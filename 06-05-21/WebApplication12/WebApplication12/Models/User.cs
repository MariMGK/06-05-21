using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication12.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName{ get; set; }
        public Role Role{ get; set; }

    }
    public enum Role
    {
        Admin,
        Guest,
        Normal
    }
}
