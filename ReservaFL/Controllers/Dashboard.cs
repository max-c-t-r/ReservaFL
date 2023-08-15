using Microsoft.AspNetCore.Mvc;

namespace ReservaFL.Controllers
{
    public class Dashboard : Controller
    {
        public IActionResult User()
        {
            return View();
        }


        public IActionResult Admin()
        {
            return View();
        }
    }
}
