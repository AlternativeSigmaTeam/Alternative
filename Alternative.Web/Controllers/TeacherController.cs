using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Alternative.BLL.Interfaces;
using Alternative.Model.Entities;
using Alternative.Web.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Alternative.Web.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public TeacherController(ITeacherService teacherService, IUserService userService, IMapper mapper)
        {
            _teacherService = teacherService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("teacher/new")]
        public IActionResult Create()
        {
            var teacher = new TeacherViewModel();
            teacher.Users = _userService.GetAllFreeUsers().Select(x => new SelectListItem(x.FullName, x.Id.ToString()));
            return View(teacher);
        }

        [HttpPost("teacher/new")]
        public IActionResult Create(TeacherViewModel teacherViewModel)
        {
            if (ModelState.IsValid)
            {
                var teacher = _mapper.Map<TeacherViewModel, Teacher>(teacherViewModel);
                if (teacherViewModel.Photo != null)
                {
                    byte[] imageData = null;
                    using (var binaryReader = new BinaryReader(teacherViewModel.Photo.OpenReadStream()))
                    {
                        imageData = binaryReader.ReadBytes((int) teacherViewModel.Photo.Length);
                    }

                    teacher.Photo = imageData;
                }

                _teacherService.Create(teacher);

                return RedirectToAction("GetAllTeachers");
            }

            return View(teacherViewModel);
        }

        [HttpGet("teachers")]
        public IActionResult GetAllTeachers()
        {
            var teachersViewModel = _mapper.Map<IEnumerable<Teacher>, IEnumerable<TeacherViewModel>>(_teacherService.GetAllTeahers());
            return View(teachersViewModel);
        }
    }
}