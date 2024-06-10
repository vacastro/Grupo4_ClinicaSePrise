using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo4_ClinicaSePrise.Entidades
{
    internal class Medico
    {

        public int ID {  get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set;}
        public string Especialidad { get; set;}
        public int Telefono { get; set;}
        public int HorarioAtencion { get; set;}

        public Medico(int ID, string nombre, string apellido, string especialidad,int telefono, int horarioAtencion ) {
          this.ID = ID;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Especialidad = especialidad;
            this.Telefono = telefono;
            this.HorarioAtencion = horarioAtencion;
        }

    }
}
