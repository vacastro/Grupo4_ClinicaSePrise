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
    internal class PacienteDatos
    {

        public Paciente IdentificarPaciente(long dni)
        {
            Paciente? pac = null;

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // instanciar conexion
                sqlCon = Conexion.getInstancia().CrearConexion();
                // crear comando de tipo storeProcedure
                MySqlCommand cmd = new MySqlCommand("IdentificarPaciente", sqlCon);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                // Agregar parámetros IN
                cmd.Parameters.Add("pacienteDni", MySqlDbType.VarChar, 40).Value = dni;
                // Agregar parámetros OUT
                cmd.Parameters.Add("pPacienteId", MySqlDbType.VarChar, 40).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("pNombre", MySqlDbType.VarChar, 40).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("pApellido", MySqlDbType.VarChar, 40).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("pFecNacimiento", MySqlDbType.Date).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("pDomicilio", MySqlDbType.VarChar, 40).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("pEmail", MySqlDbType.VarChar, 40).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("pTelefono", MySqlDbType.VarChar, 20).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("pDni", MySqlDbType.Int64).Direction = System.Data.ParameterDirection.Output;

                // conectar y almacenar respuesta
                sqlCon.Open();
                cmd.ExecuteNonQuery();
                pac = new Paciente(
                    cmd.Parameters["pNombre"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["pNombre"].Value) : string.Empty,
                    cmd.Parameters["pApellido"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["pApellido"].Value) : string.Empty,
                    cmd.Parameters["pFecNacimiento"].Value != DBNull.Value ? Convert.ToDateTime(cmd.Parameters["pFecNacimiento"].Value) : DateTime.MinValue,
                    cmd.Parameters["pDomicilio"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["pDomicilio"].Value) : string.Empty,
                    cmd.Parameters["pEmail"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["pEmail"].Value) : string.Empty,
                    cmd.Parameters["pTelefono"].Value != DBNull.Value ? Convert.ToString(cmd.Parameters["pTelefono"].Value) : string.Empty,
                    cmd.Parameters["pDni"].Value != DBNull.Value ? Convert.ToInt64(cmd.Parameters["pDni"].Value) : 0
                );

                pac.PacienteId = cmd.Parameters["pPacienteId"].Value != DBNull.Value ? Convert.ToInt64(cmd.Parameters["pPacienteId"].Value) : 0;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return pac;
        }

        public void InsertarPaciente(Paciente paciente)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("InsertarPaciente", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("pNombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("pApellido", paciente.Apellido);
                cmd.Parameters.AddWithValue("pFecNacimiento", paciente.FecNacimiento);
                cmd.Parameters.AddWithValue("pDomicilio", paciente.Domicilio);
                cmd.Parameters.AddWithValue("pEmail", paciente.Email);
                cmd.Parameters.AddWithValue("pTelefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("pDni", paciente.Dni);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("ActualizarPaciente", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("pPacienteId", paciente.PacienteId);
                cmd.Parameters.AddWithValue("pNombre", paciente.Nombre);
                cmd.Parameters.AddWithValue("pApellido", paciente.Apellido);
                cmd.Parameters.AddWithValue("pFecNacimiento", paciente.FecNacimiento);
                cmd.Parameters.AddWithValue("pDomicilio", paciente.Domicilio);
                cmd.Parameters.AddWithValue("pEmail", paciente.Email);
                cmd.Parameters.AddWithValue("pTelefono", paciente.Telefono);
                cmd.Parameters.AddWithValue("pDni", paciente.Dni);

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public Paciente BuscarPacienteById(long pacienteId)
        {
            Paciente? pac = null;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                string query = "SELECT nombre, apellido,dni, email FROM paciente WHERE pacienteId = @pacienteId";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@pacienteId", pacienteId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        pac = new Paciente
                        {

                            Nombre = reader.GetString("nombre"),
                            Apellido = reader.GetString("apellido"),
                            Dni = reader.GetInt64("dni"),
                            Email = reader.GetString("email"),
                            PacienteId = pacienteId
                        };


                    }
                }

            }
            catch
            {
                throw;
            }

            return pac;



        }
    }
}
