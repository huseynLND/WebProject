using hometask112124.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hometask112124.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
        
}
