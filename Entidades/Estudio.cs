using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo4_ClinicaSePrise.Entidades
{
    internal class Estudio
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string RequiereTurno { get; set;}
        public string RequiereAyuno { get; set;}

        public Estudio(int id, string nombre, string requiereTurno, string requiereAyuno) {
            this.ID = id; 
            this.Nombre = nombre;
            this.RequiereTurno = requiereTurno;
            this.RequiereAyuno = requiereAyuno;
        }

    }
}
