using Microsoft.AspNetCore.Mvc;

namespace Restaurator.Controllers
{
    public class MayaMexicanController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}