using Microsoft.AspNetCore.Mvc;

namespace ReservaFL.Controllers
{
    public class Access : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
