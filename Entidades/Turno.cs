using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_ClinicaSePrise.Entidades
{
    internal class Turno
    {
        public long TurnoId { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public string Especialidad { get; set; }
        public long PacienteId { get; set; } // FK de Paciente
        public bool Sobreturno { get; set; }
    }


}
