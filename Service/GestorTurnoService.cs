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

        public GestorTurnoService(int intervalo, string especialidad)
        {
            this.intervalo = intervalo;
            this.especialidad = especialidad;
            CalendarioTurnos = new Dictionary<DateTime, List<TimeSpan>>();
            CrearCalendarioTurnos(DateTime.Today, 10, intervalo);
            EliminarTurnosAgendados(especialidad);

        }

        public void EliminarTurnosAgendados(string especialidad)
        {
            Dictionary<DateTime, List<TimeSpan>> turnosAgendados = obtenerTurnosAgendadosPorEspecialidad(especialidad);

            foreach (var fechaHora in turnosAgendados)
            {
                if (CalendarioTurnos.ContainsKey(fechaHora.Key))
                {
                    CalendarioTurnos[fechaHora.Key].RemoveAll(turno => fechaHora.Value.Contains(turno));
                    if (CalendarioTurnos[fechaHora.Key].Count == 0)
                    {
                        CalendarioTurnos.Remove(fechaHora.Key);
                    }
                }
            }
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
                    TimeSpan horaInicio = new TimeSpan(7, 0, 0); // Hora de inicio
                    TimeSpan horaFin = new TimeSpan(17, 0, 0);   // Hora de fin
                    TimeSpan intervaloTiempo = new TimeSpan(0, intervalo, 0); // Intervalo de tiempo

                    // Agregar horas disponibles al Dictionary
                    while (horaInicio < horaFin)
                    {
                        horasDisponibles.Add(horaInicio);
                        horaInicio = horaInicio.Add(intervaloTiempo);
                    }
                    CalendarioTurnos.Add(fecha, horasDisponibles);
                }
            }
        }
    }
}
