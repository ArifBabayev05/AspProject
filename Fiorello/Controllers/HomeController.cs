using DAL.Data;
using DAL.Models;
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
            List<Product> products = await _context.Products.ToListAsync();

            return View(model: products);
        }
        
    }
}
