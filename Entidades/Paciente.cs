using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo4_ClinicaSePrise.Entidades
{
    internal class Paciente
    {

        public string ID { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaDeNacimeinto { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }

        public Paciente(string ID, int Dni, string Nombre, string Apellido, DateTime FechaDeNacimiento, string Generos, string Email, int Telefono)
        {
            this.ID = ID;
            this.Dni = Dni;
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Telefono = Telefono;
            this.FechaDeNacimeinto = FechaDeNacimiento;
            this.Genero = Generos;
            this.Email = Email;
            this.Telefono = Telefono;
        }
    }
}
