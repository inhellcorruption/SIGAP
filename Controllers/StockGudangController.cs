using Microsoft.AspNetCore.Mvc;

namespace Lexa.Controllers
{
    public class StockGudangController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TambahBarang()
        {
            return View();
        }
    }
}
