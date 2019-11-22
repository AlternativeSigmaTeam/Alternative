using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.Model.Entities;

namespace Alternative.Web.ViewModels
{
    public class UserViewModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Faculty Faculty { get; set; }

        public Role Role { get; set; }
    }
}
