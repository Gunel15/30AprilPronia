using Microsoft.AspNetCore.Mvc;

namespace _30AprilClassTaskPronia.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
