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

        public IActionResult InicioSesion()
        {
            return View();
        }
        public IActionResult Registrarse()
        {
            return View();
        }
        public IActionResult Olvcon()
        {
            return View();
        }
        public IActionResult Avg_Tabla_Ingresos()
        {
            return View();
        }
        public IActionResult avg_Formulario_perfil_recep()
        {
            return View();
        }
        public IActionResult avg_tabla_notif_recepcion()
        {
            return View();
        }
        public IActionResult avg_Formulario_mascota()
        {
            return View();
        }
        public IActionResult avg_Formulario_empleados()
        {
            return View();
        }
        public IActionResult avg_Formulario_cliente()
        {
            return View();
        }
        public IActionResult avg_Formulario_citas()
        {
            return View();
        }
        
    }
}