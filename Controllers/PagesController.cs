using Microsoft.AspNetCore.Mvc;

namespace Lexa.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Error500()
        {
            return View();
        }
        public IActionResult Directory()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult Lock()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Recoverpw()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Timeline()
        {
            return View();
        }
    }
}
