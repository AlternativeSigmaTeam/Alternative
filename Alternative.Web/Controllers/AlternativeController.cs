using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Alternative.BLL.DtoEntities;
using Alternative.BLL.Interfaces;
using Alternative.Model.Entities;
using Alternative.Web.ViewModels;
using Alternative.Web.ViewModels.DomainEntitysViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Alternative.Web.Controllers
{
    public class AlternativeController : Controller
    {
        private readonly IAlternativeService _alternativeService;
        private readonly ITeacherService _teacherService;
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AlternativeController(IAlternativeService alternativeService, IUserService userService,
            ITeacherService teacherService, IMapper mapper)
        {
            _alternativeService = alternativeService;
            _teacherService = teacherService;
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("alternatives")]
        public IActionResult GetAllAlternatives(FilterViewModel filter)
        {
            var filterDto = _mapper.Map<FilterViewModel, FilterDto>(filter);

           if (User.Identity.IsAuthenticated != false)
           {
                filterDto.UserId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
           }

           var alternatives =_mapper.Map<IEnumerable<Model.Entities.Alternative>, IEnumerable<AlternativeViewModel>>(_alternativeService
                .GetAlternativesByFilter(filterDto));
            var alternativeFilterViewModel = new AlternativeFilterViewModel
            {
                Alternatives = alternatives,
                SelectedSpecialty = filter.SelectedSpecialty,
                Semestr = filter.Semestr,
                SelectedCourses = filter.SelectedCourses
            };

            return View(alternativeFilterViewModel);
        }

        [HttpPost("alternatives")]
        public IActionResult GetAllAlternatives([FromBody]AlternativeFilterViewModel model)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userAltDto = _mapper.Map<AlternativeFilterViewModel, UserAlternativeDto>(model);
            userAltDto.UserId = Guid.Parse(userId);
            var savedPriority = _userService.SaveUserAlternativePriority(userAltDto);

            if (savedPriority)
            {

            }

            return View();
        }

        [HttpGet("alternative/new")]
        public IActionResult Create()
        {
            var alternative = new AlternativeViewModel();
            alternative.Teachers = _teacherService.GetAllTeahers()
                .Select(x => _mapper.Map<Teacher, TeacherViewModel>(x))
                .Select(x => new SelectListItem(x.User.FullName, x.TeacherId.ToString()));
            return View(alternative);
        }

        [HttpPost("alternative/new")]
        public IActionResult Create(AlternativeViewModel alternativeViewModel)
        {
            if (ModelState.IsValid)
            {
                var alternative = _mapper.Map<AlternativeViewModel, Model.Entities.Alternative>(alternativeViewModel);
                _alternativeService.Create(alternative);
            }

            return View();
        }

    }
}