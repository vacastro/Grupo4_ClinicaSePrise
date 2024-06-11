using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_ClinicaSePrise.Datos
{
    internal class EspecialidadesDatos
    {
        public List<string> ObtenerEspecialidadesPorTipo(string tipoEspecialidad)
        {
            List<string> especialidades = new List<string>();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // Obtener conexión
                sqlCon = Conexion.getInstancia().CrearConexion();

                // Crear comando de tipo storeProcedure
                MySqlCommand cmd = new MySqlCommand("ObtenerEspecialidadesPorTipo", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Agregar parámetro tipoEspecialidad
                cmd.Parameters.Add("tipoEspecialidad", MySqlDbType.VarChar, 50).Value = tipoEspecialidad;

                // Conectar y ejecutar comando
                sqlCon.Open();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string nombreEspecialidad = reader.GetString("nombre_especialidad");
                        especialidades.Add(nombreEspecialidad);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener las especialidades por tipo: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return especialidades;
        }
    }
}
