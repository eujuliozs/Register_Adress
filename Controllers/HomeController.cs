using Microsoft.AspNetCore.Mvc;

namespace Register_with_address.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
