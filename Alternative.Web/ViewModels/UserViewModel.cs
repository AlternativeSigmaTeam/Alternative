using Alternative.Model.Entities;

namespace Alternative.Web.ViewModels
{
    public class UserViewModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Specialty Specialty { get; set; }

        public Role Role { get; set; }
    }
}
