using Microsoft.AspNetCore.Mvc;

namespace Rock.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
