using Grupo4_ClinicaSePrise.Service;
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
    public partial class FormEstudiosMedicos : Form
    {
        private List<string> especialidadesEstudiosMedicos;

        public FormEstudiosMedicos(List<string> especialidadesEstudiosMedicos)
        {
            InitializeComponent();
            this.especialidadesEstudiosMedicos = especialidadesEstudiosMedicos;
            LlenarComboBox();

            dgvListaTurnos.Columns.Add("RadioButtonColumn", "Seleccionar"); // Columna de RadioButton
            dgvListaTurnos.Columns.Add("FechaColumn", "Fecha"); // Columna de Fecha
            dgvListaTurnos.Columns.Add("HoraColumn", "Hora");
        }
        private void LlenarComboBox()
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Análisis Clínicos");
            foreach (string especialidad in especialidadesEstudiosMedicos)
            {
                comboBox1.Items.Add(especialidad);
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = comboBox1.SelectedIndex != -1;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione una especialidad antes de buscar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string especialidadSeleccionada = comboBox1.SelectedItem.ToString();

            GestorTurnoService gestorTurnoService=  new GestorTurnoService(20, especialidadSeleccionada);
            

            Dictionary<DateTime, List<TimeSpan>> calendarioDisponible = gestorTurnoService.CalendarioTurnos;

            // Mostrar los turnos en el DataGridView
            MostrarTurnos(calendarioDisponible);
            dgvListaTurnos.Visible = true;

        }

        private void MostrarTurnos(Dictionary<DateTime, List<TimeSpan>> calendarioTurnos)
        {
            dgvListaTurnos.Rows.Clear();
            dgvListaTurnos.Columns.Clear();

            // Agregar la columna de checkbox
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Seleccionado";
            dgvListaTurnos.Columns.Add(checkboxColumn);

            // Agregar las columnas de fecha y hora
            dgvListaTurnos.Columns.Add("Fecha", "Fecha");
            dgvListaTurnos.Columns.Add("Hora", "Hora");

            foreach (var kvp in calendarioTurnos)
            {
                DateTime fecha = kvp.Key;
                List<TimeSpan> horasDisponibles = kvp.Value;

                foreach (TimeSpan hora in horasDisponibles)
                {
                    dgvListaTurnos.Rows.Add(false, fecha.ToShortDateString(), hora.ToString("hh\\:mm"));
                }
            }
        }
    }
}
