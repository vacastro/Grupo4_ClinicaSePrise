using Grupo4_ClinicaSePrise.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_ClinicaSePrise.Datos
{
    public class InsumoDatos
    {

        public List<Insumo> GetInsumos()
        {
            List<Insumo> inventario = new List<Insumo>();

            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();

                string query = "SELECT * FROM insumos";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                //command.Parameters.AddWithValue("@insumoID", insumoID);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Insumo insumo = new Insumo
                        {
                            id = reader.GetInt32("insumo_id"),
                            nombre = reader.GetString("nombre"),
                            cantidad = reader.GetInt32("cantidad"),
                        };

                        inventario.Add(insumo);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar los insumos del inventario: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return inventario;
        }

    }
}
