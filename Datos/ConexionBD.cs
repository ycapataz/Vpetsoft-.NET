using System;
using MySql.Data.MySqlClient;

namespace VpetsofttNet.Datos
{
    public class ConexionBD : IDisposable
    {
        private MySqlConnection conn;

        public ConexionBD()
        {
            string connectionString = "Server=localhost;Database=vpetsoft_1;Uid=root;Pwd=;";
            conn = new MySqlConnection(connectionString);
        }

        public MySqlConnection AbrirConexion()
        {
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception e)
            {
                // Aquí podrías registrar el error en algún lugar o lanzar una excepción personalizada
                Console.WriteLine("Error al abrir la conexión: " + e.Message);
                return null;
            }
        }

        public void CerrarConexion()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void Dispose()
        {
            CerrarConexion();
            conn.Dispose();
        }
    }
}