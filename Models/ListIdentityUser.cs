using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneWeb.Models
{
    public class ListIdentityUser
    {
        public List<User> ListUser { get; set; }
        public enum RoleType
        {
            Admin, User, HR
        }
    }
}
