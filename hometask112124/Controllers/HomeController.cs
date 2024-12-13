using hometask112124.DataAccess;
using hometask112124.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace hometask112124.Controllers
{
    public class HomeController(UniqloDbContext _context) : Controller
    {
       

        public async Task<IActionResult> Index()
        {
            return View(await _context.Sliders.ToListAsync());
        }
        public IActionResult About()
        {
            return View();
        }
    }
        
}
