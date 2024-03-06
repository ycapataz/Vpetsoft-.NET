using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VpetsofttNet.Models;

namespace VpetsofttNet.Controllers
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

        public IActionResult Nosotros()
        {
            return View();
        }

        public IActionResult Modulos()
        {
            return View();
        }

        public IActionResult Error_404()
        {
            return View();
        }

        public IActionResult Contactenos()
        {
            return View();
        }
        
    }
}