using Microsoft.AspNetCore.Mvc;

namespace Restaurator.Controllers
{
    public class YukaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}