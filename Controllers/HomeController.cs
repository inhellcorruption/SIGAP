using Microsoft.AspNetCore.Mvc;

namespace Lexa.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}