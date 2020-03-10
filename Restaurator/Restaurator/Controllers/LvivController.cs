using Microsoft.AspNetCore.Mvc;

namespace Restaurator.Controllers
{
    public class LvivController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}