using Microsoft.AspNetCore.Mvc;

namespace Lexa.Controllers
{
    public class NotifikasiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HalamanNotifikasi()
        {
            return View();
        }
    }
}
