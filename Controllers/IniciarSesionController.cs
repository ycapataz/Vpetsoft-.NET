using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using VpetsofttNet.Datos;
using VpetsofttNet.Models;
using System;

namespace VpetsofttNet.Controllers
{
    public class IniciarSesionController : Controller
    {
        private readonly string _connectionString;

        [HttpGet]
        public IActionResult InicioSesion()
        {
            return View("~/Views/Home/InicioSesion.cshtml");
        }

        [HttpPost] 
        public IActionResult Login(String email, String password)
        {
            bool checkUser = false;
            ConexionBD conexionBD = new ConexionBD();
            String query = "SELECT * FROM empleado WHERE corempleado='"+email+"' AND password='"+password+"' ";

            MySqlCommand cmd = new MySqlCommand(query, conexionBD.AbrirConexion());

            using (MySqlDataReader lector =cmd.ExecuteReader())
            {
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        checkUser = true;
                    }
                }
            }
            if (checkUser == true)
            {
                return RedirectToAction("Avg_Tabla_Ingresos", "Home");
            }else
            {
                // Autenticación fallida
                // Aquí puedes mostrar un mensaje de error al usuario
                ViewBag.ErrorMessage = "Correo electrónico o contraseña incorrectos";
                return View("~/Views/Home/InicioSesion.cshtml");
            }
        }
    }
}