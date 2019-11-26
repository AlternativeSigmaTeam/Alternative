using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alternative.BLL.Interfaces;
using Alternative.Model.Entities;
using Alternative.Web.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Alternative.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public AccountController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet("user/{userId}")]
        public IActionResult Profile(Guid userId)
        {
            if (_userService.IsUserExisted(userId))
            {
                var user = _mapper.Map<User,UserViewModel>(_userService.GetUserById(userId));
                return View(user);
            }

            return NotFound();
        }
    }
}