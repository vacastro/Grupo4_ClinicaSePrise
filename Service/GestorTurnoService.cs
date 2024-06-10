using Grupo4_ClinicaSePrise.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_ClinicaSePrise.Service
{
    internal class GestorTurnoService
    {
        public int intervalo;
        public string especialidad;
        public Dictionary<DateTime, List<TimeSpan>> CalendarioTurnos;
        public Dictionary<DateTime, List<TimeSpan>> CalendarioSobreTurnos;


        public GestorTurnoService(int intervalo, string especialidad)
        {
            this.intervalo = intervalo;
            this.especialidad = especialidad;
            CalendarioTurnos = new Dictionary<DateTime, List<TimeSpan>>();
            CalendarioSobreTurnos = new Dictionary<DateTime, List<TimeSpan>>();
            CrearCalendarioTurnos(DateTime.Today, 10, intervalo);
            EliminarTurnosAgendados(especialidad);
            CrearCalendarioSobreTurnos(DateTime.Today, 10);
            EliminarSobreTurnosAgendados(especialidad);
            

        }

        private void CrearCalendarioSobreTurnos(DateTime fechaInicio, int dias)
        {
            for (int i = 0; i < dias; i++)
            {
                DateTime fecha = fechaInicio.AddDays(i);
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    List<TimeSpan> horasDisponibles = new List<TimeSpan>();
                    TimeSpan horaInicio;

                    if (fecha.Date == DateTime.Today)
                    {
                        horaInicio = DateTime.Now.TimeOfDay;
                        int minutosParaSiguienteIntervalo = 60 - (horaInicio.Minutes % 60);
                        horaInicio = horaInicio.Add(new TimeSpan(0, minutosParaSiguienteIntervalo, 0));
                    }
                    else
                    {
                        horaInicio = new TimeSpan(7, 0, 0);
                    }

                    TimeSpan horaFin = new TimeSpan(17, 0, 0);
                    TimeSpan intervaloTiempo = new TimeSpan(1, 0, 0);

                    while (horaInicio < horaFin)
                    {
                        horasDisponibles.Add(horaInicio);
                        horaInicio = horaInicio.Add(intervaloTiempo);
                    }

                    if (horasDisponibles.Count > 0)
                    {
                        CalendarioSobreTurnos.Add(fecha, horasDisponibles);
                    }
                }
            }
        }

        public void EliminarSobreTurnosAgendados(string especialidad)
        {
            Dictionary<DateTime, List<TimeSpan>> sobreTurnosAgendados = obtenerSobreTurnosAgendadosPorEspecialidad(especialidad);

            foreach (var fechaHora in sobreTurnosAgendados)
            {
                if (CalendarioSobreTurnos.ContainsKey(fechaHora.Key))
                {
                    // Filtrar los turnos que coinciden con fecha y hora
                    CalendarioSobreTurnos[fechaHora.Key].RemoveAll(sobreturno =>
                        fechaHora.Value.Any(sobreturnoEnBD =>
                            sobreturnoEnBD.Hours == sobreturno.Hours &&
                            sobreturnoEnBD.Minutes == sobreturno.Minutes
                        )
                    );

                    if (CalendarioSobreTurnos[fechaHora.Key].Count == 0)
                    {
                        CalendarioSobreTurnos.Remove(fechaHora.Key);
                    }
                }
            }
        }

        public void EliminarTurnosAgendados(string especialidad)
        {
            Dictionary<DateTime, List<TimeSpan>> turnosAgendados = obtenerTurnosAgendadosPorEspecialidad(especialidad);

            foreach (var fechaHora in turnosAgendados)
            {
                if (CalendarioTurnos.ContainsKey(fechaHora.Key))
                {
                    CalendarioTurnos[fechaHora.Key].RemoveAll(turno =>
                        fechaHora.Value.Any(turnoEnBD =>
                            turnoEnBD.Hours == turno.Hours &&
                            turnoEnBD.Minutes == turno.Minutes
                        )
                    );

                    if (CalendarioTurnos[fechaHora.Key].Count == 0)
                    {
                        CalendarioTurnos.Remove(fechaHora.Key);
                    }
                }
            }
        }




        public Dictionary<DateTime, List<TimeSpan>> obtenerSobreTurnosAgendadosPorEspecialidad(string especialidad)
        {
            TurnoDatos turnoDatos = new TurnoDatos();
            Dictionary<DateTime, List<TimeSpan>> turnosAgendados = turnoDatos.BuscarSobreTurnosAgendadosPorEspecialidad(especialidad);

            return turnosAgendados;
        }

        public Dictionary<DateTime, List<TimeSpan>> obtenerTurnosAgendadosPorEspecialidad(string especialidad)
        {
            TurnoDatos turnoDatos = new TurnoDatos();
            Dictionary<DateTime, List<TimeSpan>>  turnosAgendados = turnoDatos.BuscarTurnosAgendadosPorEspecialidad(especialidad);

            return turnosAgendados;
        }

        private void CrearCalendarioTurnos(DateTime fechaInicio, int dias, int intervalo)
        {
            for (int i = 0; i < dias; i++)
            {
                DateTime fecha = fechaInicio.AddDays(i);
                if (fecha.DayOfWeek != DayOfWeek.Saturday && fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    List<TimeSpan> horasDisponibles = new List<TimeSpan>();
                    TimeSpan horaInicio;

                    if (fecha.Date == DateTime.Today)
                    {
                        horaInicio = DateTime.Now.TimeOfDay;
                        int minutosParaSiguienteIntervalo = intervalo - (horaInicio.Minutes % intervalo);
                        horaInicio = horaInicio.Add(new TimeSpan(0, minutosParaSiguienteIntervalo, 0));
                    }
                    else
                    {
                        horaInicio = new TimeSpan(7, 0, 0); 
                    }

                    TimeSpan horaFin = new TimeSpan(17, 0, 0);   
                    TimeSpan intervaloTiempo = new TimeSpan(0, intervalo, 0); 

                    while (horaInicio < horaFin)
                    {
                        horasDisponibles.Add(horaInicio);
                        horaInicio = horaInicio.Add(intervaloTiempo);
                    }

                    if (horasDisponibles.Count > 0) 
                    {
                        CalendarioTurnos.Add(fecha, horasDisponibles);
                    }
                }
            }
        }

    }
}
