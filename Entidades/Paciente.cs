using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupo4_ClinicaSePrise.Entidades
{
    internal class Paciente
    {

        private long pacienteId;
        private string nombre;
        private string apellido;
        private DateTime fecNacimiento;
        private string domicilio;
        private string email;
        private string telefono;
        private long dni;

        public long PacienteId
        {
            get { return pacienteId; }
            set { pacienteId = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FecNacimiento
        {
            get { return fecNacimiento; }
            set { fecNacimiento = value; }
        }

        public string Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public Paciente()
        {
        }

        public Paciente(long pacienteId, string nombre, string apellido, DateTime fecNacimiento, string domicilio, string email, string telefono, long dni)
        {
            this.pacienteId = pacienteId;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecNacimiento = fecNacimiento;
            this.domicilio = domicilio;
            this.email = email;
            this.telefono = telefono;
            this.dni = dni;
        }

        // Constructor con parámetros obligatorios (puedes agregar más si lo deseas)
        public Paciente(string nombre, string apellido, DateTime fecNacimiento, string domicilio, string email, string telefono, long dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecNacimiento = fecNacimiento;
            this.domicilio = domicilio;
            this.email = email;
            this.telefono = telefono;
            this.dni = dni;
        }
    }
}
