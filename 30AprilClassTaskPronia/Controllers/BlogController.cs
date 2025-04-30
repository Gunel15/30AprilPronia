using Microsoft.AspNetCore.Mvc;

namespace _30AprilClassTaskPronia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
