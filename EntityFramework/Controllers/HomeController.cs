using EntityFramework.Data;
using EntityFramework.Models;
using EntityFramework.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EntityFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            List<Futures> futures = _context.Futures.ToList();
            List<Service> services = _context.Services.ToList();
            List<Project> projects = _context.Projects.ToList();

            HomeVM model = new HomeVM()
            { 
            Slider = sliders,
            Futures = futures,
            Services = services,    
            Projects = projects
            };


            return View(model);
        }

    }
}