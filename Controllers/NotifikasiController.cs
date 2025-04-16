using Microsoft.AspNetCore.Mvc;

namespace Lexa.Controllers
{
    public class NotifikasiController : Controller
    {
        public IActionResult HalamanNotifikasi()
        {
            return View();
        }
    }
}
