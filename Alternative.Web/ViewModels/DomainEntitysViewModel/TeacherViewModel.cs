using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Alternative.Web.ViewModels
{
    public class TeacherViewModel
    {
        public Guid? TeacherId { get; set; }

        public string LinkKhNure { get; set; }

        public IFormFile Photo { get; set; }

        public byte[] PhotoByte { get; set; }

        public IEnumerable<SelectListItem> Alternatives { get; set; }

        public IEnumerable<Guid> SelectedAlternatives { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }

        public Guid SelectedUser { get; set; }

        public User User { get; set; }
    }
}
