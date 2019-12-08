using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alternative.Web.Models;

namespace Alternative.Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("~/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return this.View();
        }

        public IActionResult Speciality()
        {
            return this.View();
        }

        public IActionResult Course()
        {
            return this.View();
        }

        public IActionResult PickAlternative()
        {
            return this.View();
        }

        public IActionResult Description()
        {
            return this.View();
        }

        public IActionResult Admin()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(string err)
        {
            return this.View("Error", err);
        }
    }
}
