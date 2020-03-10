using Microsoft.AspNetCore.Mvc;

namespace Restaurator.Controllers
{
    public class LavenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}