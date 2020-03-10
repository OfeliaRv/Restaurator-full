using Microsoft.AspNetCore.Mvc;

namespace Restaurator.Controllers
{
    public class MalacannesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}