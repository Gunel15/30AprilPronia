using _30AprilClassTaskPronia.Contexts;
using _30AprilClassTaskPronia.ViewModels;
using _30AprilClassTaskPronia.ViewModels.services;
using _30AprilClassTaskPronia.ViewModels.sliders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _30AprilClassTaskPronia.Controllers
{
    public class HomeController(ProniaNewDbContext _context) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var sliders=await _context.Sliders.ToListAsync();
            var services = await _context.Services.ToListAsync();

            List<SliderGetVM> slideViewModels = [];
            List<ServiceGetVM> serviceViewModels = [];

            foreach(var slider in sliders)
            {
                SliderGetVM vm = new()
                {
                    Title = slider.Title,
                    Description = slider.Description,
                    ImagePath = slider.ImagePath,
                    Offer = slider.Offer
                };
                slideViewModels.Add(vm);
            }

            foreach (var service in services)
            {
                ServiceGetVM vm = new()
                {
                    Title = service.Title,
                    Description = service.Description,
                    ImagePath = service.ImagePath,
                  
                };
                serviceViewModels.Add(vm);
            }

            HomeVM homeVM = new()
            {
                Sliders = slideViewModels,
                Services = serviceViewModels,
            };
            return View(homeVM);
        }
    }
}
