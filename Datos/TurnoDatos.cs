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
    internal class TurnoDatos
    {

        public Dictionary<DateTime, List<TimeSpan>> BuscarTurnosAgendadosPorEspecialidad(string especialidad)
        {
            Dictionary<DateTime, List<TimeSpan>> calendarioTurnos = new Dictionary<DateTime, List<TimeSpan>>();

            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                DateTime fechaInicio = DateTime.Today;
                DateTime fechaFin = DateTime.Today.AddDays(10);

                string query = "SELECT fecha, hora FROM turno WHERE especialidad = @especialidad AND fecha BETWEEN @fechaInicio AND @fechaFin";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@especialidad", especialidad);
                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                command.Parameters.AddWithValue("@fechaFin", fechaFin);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime fechaTurno = reader.GetDateTime("fecha");
                        TimeSpan horaTurno = reader.GetTimeSpan("hora");

                        if (!calendarioTurnos.ContainsKey(fechaTurno))
                        {
                            calendarioTurnos[fechaTurno] = new List<TimeSpan>();
                        }

                        calendarioTurnos[fechaTurno].Add(horaTurno);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar los turnos agendados por especialidad: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return calendarioTurnos;
        }

        public void InsertarTurno(DateTime fecha, TimeSpan hora, string especialidad, long pacienteId, bool sobreturno)
        {
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                sqlCon.Open();

                MySqlCommand cmd = new MySqlCommand("InsertarTurno", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("p_fecha", fecha);
                cmd.Parameters.AddWithValue("p_hora", hora);
                cmd.Parameters.AddWithValue("p_especialidad", especialidad);
                cmd.Parameters.AddWithValue("p_pacienteId", pacienteId);
                cmd.Parameters.AddWithValue("p_sobreturno", sobreturno);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar el turno: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }

        public Dictionary<DateTime, List<TimeSpan>> BuscarSobreTurnosAgendadosPorEspecialidad(string especialidad)
        {
            Dictionary<DateTime, List<TimeSpan>> calendarioSobreTurnos = new Dictionary<DateTime, List<TimeSpan>>();

            using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
            {
                try
                {
                    sqlCon.Open();

                    DateTime fechaInicio = DateTime.Today;
                    DateTime fechaFin = DateTime.Today.AddDays(10);

                    string query = "SELECT fecha, hora FROM turno WHERE especialidad = @especialidad AND sobreturno = 1 AND fecha BETWEEN @fechaInicio AND @fechaFin";

                    using (MySqlCommand command = new MySqlCommand(query, sqlCon))
                    {
                        command.Parameters.AddWithValue("@especialidad", especialidad);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DateTime fechaTurno = reader.GetDateTime("fecha");
                                TimeSpan horaTurno = reader.GetTimeSpan("hora");

                                if (!calendarioSobreTurnos.ContainsKey(fechaTurno))
                                {
                                    calendarioSobreTurnos[fechaTurno] = new List<TimeSpan>();
                                }

                                calendarioSobreTurnos[fechaTurno].Add(horaTurno);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al buscar los sobreturnos agendados por especialidad: " + ex.Message);
                    throw;
                }
            }

            return calendarioSobreTurnos;
        }


        public List<Turno> BuscarTurnosPaciente(long pacienteId)
        {
            List<Turno> turnosPaciente = new List<Turno>();

            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();

                DateTime fechaHoraActual = DateTime.Now; // Obtener la fecha y hora actual

                string query = "SELECT TurnoId, fecha, hora, especialidad FROM turno WHERE pacienteId = @pacienteId AND (fecha > @fechaActual OR (fecha = @fechaActual AND hora > @horaActual))";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@pacienteId", pacienteId);
                command.Parameters.AddWithValue("@fechaActual", fechaHoraActual.Date); // Solo la fecha sin la hora
                command.Parameters.AddWithValue("@horaActual", fechaHoraActual.TimeOfDay); // Solo la hora sin la fecha

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Turno turno = new Turno
                        {
                            TurnoId = reader.GetInt64("TurnoId"),
                            Fecha = reader.GetDateTime("fecha"),
                            Hora = reader.GetTimeSpan("hora"),
                            Especialidad = reader.GetString("especialidad"),
                            PacienteId = pacienteId
                        };

                        turnosPaciente.Add(turno);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al buscar los turnos del paciente: " + ex.Message);
                throw;
            }
            finally
            {
                if (sqlCon.State == System.Data.ConnectionState.Open)
                    sqlCon.Close();
            }

            return turnosPaciente;
        }


        public void CancelarTurno(long turnoId)
        {
            MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion();
            try
            {
                sqlCon.Open();

                string query = "DELETE FROM turno WHERE TurnoId = @turnoId";

                MySqlCommand command = new MySqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@turnoId", turnoId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("El turno no existe o ya ha sido cancelado.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cancelar el turno: " + ex.Message);
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
