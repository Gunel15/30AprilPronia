using _30AprilClassTaskPronia.Contexts;
using _30AprilClassTaskPronia.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _30AprilClassTaskPronia.Areas.Admin.Controllers;
[Area("Admin")]
public class ServiceController : Controller
{
    public async Task<IActionResult> Index()
    {
        using var context = new ProniaNewDbContext();
        var sliders = await context.Services.ToListAsync();
        return View(sliders);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]

    public async Task <IActionResult> Create (Service service)
    {
        if (!ModelState.IsValid) 
            return View(service);
        using var context = new ProniaNewDbContext();
        await context.Services.AddAsync(service);
        await context.SaveChangesAsync();

        return RedirectToAction(nameof(Index));

    }
    public async Task<IActionResult> Delete(int? id)
    {
        if(id is null || id<1)
            return BadRequest();    
        using var context = new ProniaNewDbContext();
        var services= await context.Services.FirstOrDefaultAsync(x=>x.Id==id);
        if(services == null)
            return NotFound();
        context.Services.Remove(services);
        await context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    //public async Task<IActionResult>

}

