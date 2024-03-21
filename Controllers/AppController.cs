using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace VpetsofttNet.Controllers
{
    public class AppController
    {
        private string connectionString = "Server=localhost;Database=vpetsoft_1;Uid=root;Pwd=;";

        public DataTable EjecutarSelect(string consulta)
        {
            DataTable dataTable = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(consulta, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al ejecutar la consulta: " + ex.Message);
                }
            }
            return dataTable;
        }

        public string ObtenerOpcionesMascotas()
        {
            DataTable resultado = EjecutarSelect("SELECT id, nombre FROM mascota");

            // Construir las opciones del select
            string opciones = "<option selected disabled>Seleccione mascota</option>";
            foreach (DataRow fila in resultado.Rows)
            {
                string idMascota = fila["id"].ToString();
                string nombreMascota = fila["nombre"].ToString();
                opciones += $"<option value='{idMascota}'>{nombreMascota}</option>";
            }
            return opciones;
        }

        public void GuardarDatos(int idMascotaSeleccionada)
        {
            // Aquí puedes escribir la lógica para guardar el ID de la mascota seleccionada en la base de datos
            // Por ejemplo, podrías ejecutar una consulta INSERT INTO para agregar el ID a una tabla específica.
            // No olvides validar y sanitizar los datos antes de ejecutar la consulta para evitar ataques de inyección SQL.
        }
    }
}