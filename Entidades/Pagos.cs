using System;
using System.Collections.Generic;
using System.Text;

namespace Grupo4_ClinicaSePrise.Entidades
{
    internal class Pagos
    {
        public int ID { get; set; }
        public string ObraSocial { get; set; }
        public string Particular { get; set; }

        public Pagos(int id, string obraSocial, string particular) { 
            this.ID = id;
            this.ObraSocial = obraSocial;
            this.Particular = particular;
        }
    }
}
