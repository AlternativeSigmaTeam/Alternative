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

        [HttpGet("/speciality")]
        public IActionResult Speciality()
        {
            return this.View();
        }

        [HttpGet("/course")]
        public IActionResult Course()
        {
            return this.View();
        }

        [HttpGet("/alternative")]
        public IActionResult PickAlternative()
        {
            return this.View();
        }

        [HttpGet("/description")]
        public IActionResult Description()
        {
            return this.View();
        }

        [HttpGet("/admin")]
        public IActionResult Admin()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
