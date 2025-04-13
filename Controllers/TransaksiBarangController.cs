using Microsoft.AspNetCore.Mvc;

namespace Lexa.Controllers
{
    public class TransaksiBarangController : Controller
    {
        public IActionResult PermintaanBarang()
        {
            return View();
        }
        public IActionResult PemasukkanBarang()
        {
            return View();
        }       
    }
}
