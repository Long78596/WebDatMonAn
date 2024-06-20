using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebDatMonAn.Models;

namespace WebDatMonAn.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult detail()
        {
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        public IActionResult category()
        {
            return View();
        }
        public IActionResult login()
        {
            return PartialView();
        }
         
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
