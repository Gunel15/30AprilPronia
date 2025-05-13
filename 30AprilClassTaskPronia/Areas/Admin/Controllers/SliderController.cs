using _30AprilClassTaskPronia.Contexts;
using Microsoft.AspNetCore.Mvc;

namespace _30AprilClassTaskPronia.Areas.Admin.Controllers
{
    public class SliderController(ProniaNewDbContext _context) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
