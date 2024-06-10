using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Grupo4_ClinicaSePrise.Entidades
{
    internal class Insumos
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }

        public Insumos(int id, string nombre, string cantidad) {
         this.ID = id;
         this.Nombre = nombre;
         this.Cantidad = cantidad;
        }
    }
}
