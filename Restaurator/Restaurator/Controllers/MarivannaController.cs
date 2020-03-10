using Microsoft.AspNetCore.Mvc;

namespace Restaurator.Controllers
{
    public class MarivannaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}