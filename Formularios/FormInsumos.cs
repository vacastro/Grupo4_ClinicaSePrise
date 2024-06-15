using Grupo4_ClinicaSePrise.Datos;
using Grupo4_ClinicaSePrise.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_ClinicaSePrise.Formularios
{
    public partial class FormInsumos : Form
    {
        public FormInsumos()
        {
            InitializeComponent();
            CargarInsumos();
        }

        private void CargarInsumos()
        {
            InsumoDatos insumoDatos = new InsumoDatos();
            List<Insumo> insumosList = insumoDatos.GetInsumos();
            if (insumosList.Count > 0)
            {
                foreach (var insumo in insumosList)
                {
                    int fila = dtgvInsumos.Rows.Add();
                    dtgvInsumos.Rows[fila].Cells[0].Value = insumo.id;
                    dtgvInsumos.Rows[fila].Cells[1].Value = insumo.nombre;
                    dtgvInsumos.Rows[fila].Cells[2].Value = insumo.cantidad;
                }
            }
            else
            {
                MessageBox.Show("No hay datos de insumos");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
