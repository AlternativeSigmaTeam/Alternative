using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.BLL.Interfaces;
using Alternative.Model.Entities;
using Alternative.Web.ViewModels;
using Alternative.Web.ViewModels.DomainEntitysViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Alternative.Web.Controllers
{
    public class SpecialtyController : Controller
    {
        private readonly ISpecialtyService _specialtyService;
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;

        public SpecialtyController(ISpecialtyService specialtyService, ICourseService courseService, IMapper mapper)
        {
            _courseService = courseService;
            _specialtyService = specialtyService;
            _mapper = mapper;
        }

        [HttpGet("specialties")]
        public IActionResult GetAllSpecialties()
        {
            var filterViewModel = new FilterViewModel();
            var specialties = _specialtyService.GetAllSpecialties();
            filterViewModel.Specialties  = specialties.Select(x => _mapper.Map<Specialty, SpecialtyViewModel>(x))
                .Select(x => new SelectListItem(x.Name, x.SpecialtyId.ToString()));
            return View(filterViewModel);
        }

        [HttpPost("specialties")]
        public IActionResult GetAllSpecialties(FilterViewModel filter)
        {
            if (filter.SelectedSpecialty != Guid.Empty)
            {
                return RedirectToAction("GetCourse", new{ specialtyId = filter.SelectedSpecialty});
            }

            return RedirectToAction("GetAllSpecialties");
        }

        [HttpGet("specialties/courses")]
        public IActionResult GetCourse(Guid specialtyId)
        {
            var filter = new FilterViewModel();
            filter.SelectedSpecialty = specialtyId;
            filter.Courses = _courseService.GetCoursesByCurrentSpeciality(specialtyId)
                .Select(x => new SelectListItem(x.Name, x.Id.ToString()));
            return View(filter);
        }

        [HttpPost("specialties/courses")]
        public IActionResult GetCourse(FilterViewModel filter)
        {
            return RedirectToAction("GetAllAlternatives", "Alternative", filter);
        }
    }
}