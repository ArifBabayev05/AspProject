using DAL.Data;
using DAL.Models;
using Fiorello.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fiorello.Controllers
{
    public class HomeController : Controller
    {

        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        
        public async Task<IActionResult> Index()
        {
            List<Product> products = await _context.Products.Include(n => n.Image).ToListAsync();
            List<Slider> sliders = await _context.Sliders.Include(n => n.Image).ToListAsync();
            List<Category> categories = await _context.Categories.ToListAsync();
            List<Expert> experts = await _context.Experts.Include(n => n.Image).ToListAsync();


            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders,
                Products = products,
                Categories = categories,
                Experts=experts
            };
            return View(model: homeVM);
        }
        
    }
}
