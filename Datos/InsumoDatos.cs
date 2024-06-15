using Grupo4_ClinicaSePrise.Entidades;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Insumo insumo = new Insumo
                        {
                            Id = reader.GetInt32("insumo_id"),
                            Nombre = reader.GetString("nombre"),
                            Cantidad = reader.GetInt32("cantidad"),
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

        public void ActualizarInsumos(List<Insumo> insumosModificados)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                foreach (Insumo insumo in insumosModificados)
                {
                    string sqlUpdate = "UPDATE insumos SET nombre = @Nombre, cantidad = @Cantidad WHERE insumo_id = @Id;";

                    using (MySqlCommand cmd = new MySqlCommand(sqlUpdate, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", insumo.Nombre);
                        cmd.Parameters.AddWithValue("@Cantidad", insumo.Cantidad);
                        cmd.Parameters.AddWithValue("@Id", insumo.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al actualizar los insumos: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
            
        }

        public void InsertarInsumo(Insumo insumoNuevo)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                string sqlUpdate = "INSERT INTO Insumos (nombre, cantidad) VALUES(@Nombre, @Cantidad);";

                using (MySqlCommand cmd = new MySqlCommand(sqlUpdate, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@Nombre", insumoNuevo.Nombre);
                    cmd.Parameters.AddWithValue("@Cantidad", insumoNuevo.Cantidad);
                    cmd.ExecuteNonQuery();
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al agregar insumo" + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }
        public void EliminarInsumo(int insumoID)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();
                string sqlUpdate = "DELETE FROM Insumos WHERE insumo_id = @insumoID;";

                using (MySqlCommand cmd = new MySqlCommand(sqlUpdate, sqlCon))
                {
                    cmd.Parameters.AddWithValue("@insumoID", insumoID);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al eliminar insumo" + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
