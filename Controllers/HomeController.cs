using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EntraIdLoginDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // login page
        }

        [Authorize]
        public IActionResult Success()
        {
            return View(); // shown after login
        }

        public IActionResult Logout()
        {
            return SignOut("Cookies", "OpenIdConnect");
        }
    }
}
