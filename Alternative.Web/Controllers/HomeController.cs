using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Alternative.Web.Models;

namespace Alternative.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return this.View();
        }

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
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            var t = 10;
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
