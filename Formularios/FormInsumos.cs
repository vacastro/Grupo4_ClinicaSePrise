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
        private List<Insumo> insumosModificados = new List<Insumo>(); // Lista para almacenar los insumos modificados

        public FormInsumos()
        {
            InitializeComponent();
            CargarInsumos();
        }

        public void CargarInsumos()
        {
            // Borrar datos previos del DataGridView
            dtgvInsumos.Rows.Clear();

            InsumoDatos insumoDatos = new InsumoDatos();
            List<Insumo> insumosList = insumoDatos.GetInsumos();
            if (insumosList.Count > 0)
            {
                foreach (var insumo in insumosList)
                {
                    int fila = dtgvInsumos.Rows.Add();
                    dtgvInsumos.Rows[fila].Cells[0].Value = insumo.Id;
                    dtgvInsumos.Rows[fila].Cells[1].Value = insumo.Nombre;
                    dtgvInsumos.Rows[fila].Cells[2].Value = insumo.Cantidad;
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

        private void dtgvInsumos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvInsumos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dtgvInsumos_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            //// obtenermos datos de fila
            //DataGridViewRow nuevaFila = e.Row;

            //Insumo nuevoInsumo = new Insumo
            //{
            //    Nombre = Convert.ToString(nuevaFila.Cells[1].Value),
            //    Cantidad = Convert.ToInt32(nuevaFila.Cells[2].Value)
            //};

            //insumosNuevos.Add(nuevoInsumo);
        }

        private void dtgvInsumos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Capturar el ID y los nuevos valores de la celda editada
            int idInsumo = Convert.ToInt32(dtgvInsumos.Rows[e.RowIndex].Cells[0].Value);
            string nuevoNombre = Convert.ToString(dtgvInsumos.Rows[e.RowIndex].Cells[1].Value) ?? string.Empty;
            int nuevaCantidad = Convert.ToInt32(dtgvInsumos.Rows[e.RowIndex].Cells[2].Value);

            // Buscar si ya existe el insumo modificado en la lista
            Insumo insumoModificado = insumosModificados.Find(i => i.Id == idInsumo);
            if (insumoModificado != null)
            {
                // Actualizar los valores del insumo modificado
                insumoModificado.Nombre = nuevoNombre;
                insumoModificado.Cantidad = nuevaCantidad;
            }
            else
            {
                // Crear un nuevo objeto Insumo y agregarlo a la lista de cambios
                insumoModificado = new Insumo
                {
                    Id = idInsumo,
                    Nombre = nuevoNombre,
                    Cantidad = nuevaCantidad
                };
                insumosModificados.Add(insumoModificado);
            }
        }

        private void guardarBtn_Click(object sender, EventArgs e)
        {
            // Guardar los cambios en la base de datos
            InsumoDatos insumoDatos = new InsumoDatos();

            if (insumosModificados.Count > 0)
            {
                // UPDATE
                insumoDatos.ActualizarInsumos(insumosModificados);
                insumosModificados.Clear();
            }

            CargarInsumos();

            MessageBox.Show("Cambios guardados correctamente.");
        }

        private void agregarInsumoBtn_Click(object sender, EventArgs e)
        {
            FormAgregarInsumo formAgregarInsumo = new FormAgregarInsumo(this);
            formAgregarInsumo.ShowDialog();
        }

        private void dtgvInsumos_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            // Capturar el ID
            int idInsumo = Convert.ToInt32(e.Row.Cells[0].Value);
            InsumoDatos insumoDatos = new InsumoDatos();
            insumoDatos.EliminarInsumo(idInsumo);
            CargarInsumos();
        }
    }
}

