﻿using Grupo4_ClinicaSePrise.Datos;
using Grupo4_ClinicaSePrise.Entidades;
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
    public partial class FormConsultoriosExternos : Form
    {

        internal Paciente? paciente;
        bool esSobreturno = false;
        private List<string> especialidadesConsultorioExterno;
        public FormConsultoriosExternos(List<string> especialidadesConsultorioExterno)
        {
            InitializeComponent();
            this.especialidadesConsultorioExterno = especialidadesConsultorioExterno;
            LlenarComboBox();

            dgvListaTurnos.Columns.Add("RadioButtonColumn", "Seleccionar"); // Columna de RadioButton
            dgvListaTurnos.Columns.Add("FechaColumn", "Fecha"); // Columna de Fecha
            dgvListaTurnos.Columns.Add("HoraColumn", "Hora");
        }



        private void LlenarComboBox()
        {
            comboBox1.Items.Clear();
            foreach (string especialidad in especialidadesConsultorioExterno)
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

            GestorTurnoService gestorTurnoService;
            if (especialidadSeleccionada.Equals("Fisio-Kinesiologia"))
            {
                gestorTurnoService = new GestorTurnoService(25, especialidadSeleccionada);
            }
            else if (especialidadSeleccionada.Equals("Salud Mental"))
            {
                gestorTurnoService = new GestorTurnoService(30, especialidadSeleccionada);
            }
            else
            {
                gestorTurnoService = new GestorTurnoService(15, especialidadSeleccionada);
            }


            Dictionary<DateTime, List<TimeSpan>> calendarioDisponible = new Dictionary<DateTime, List<TimeSpan>>();
            if (gestorTurnoService.CalendarioTurnos.Count == 0)
            {
                MessageBox.Show("No hay turnos disponibles. Puede agendar un sobre turno. Considere que la sala de espera puede estar demorada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                calendarioDisponible = gestorTurnoService.CalendarioSobreTurnos;
                esSobreturno = true;
                lbSobreTurnos.Visible = true;
                lbProximosTurnos.Visible = false;
            }
            else
            {
                calendarioDisponible = gestorTurnoService.CalendarioTurnos;
                lbProximosTurnos.Visible = true;
                lbSobreTurnos.Visible = false;
            }

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
            checkboxColumn.Name = "Seleccionado";
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

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            int selectedCount = 0;
            DataGridViewRow selectedRow = null;

            foreach (DataGridViewRow row in dgvListaTurnos.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Seleccionado"].Value))
                {
                    selectedCount++;
                    selectedRow = row;
                }
            }

            if (selectedCount == 0)
            {
                MessageBox.Show("Por favor, seleccione un turno para agendar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedCount > 1)
            {
                MessageBox.Show("Solo puede seleccionar un turno a la vez.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (selectedRow != null)
            {
                Turno turnoSeleccionado = new Turno();
                turnoSeleccionado.Fecha = DateTime.Parse(selectedRow.Cells["Fecha"].Value.ToString());
                turnoSeleccionado.Hora = TimeSpan.Parse(selectedRow.Cells["Hora"].Value.ToString());
                turnoSeleccionado.Especialidad = comboBox1.SelectedItem.ToString();
                turnoSeleccionado.Sobreturno = esSobreturno;
                turnoSeleccionado.PacienteId = paciente.PacienteId;
                FormConfirmacionTurno formConfirmacionTurno = new FormConfirmacionTurno();
                formConfirmacionTurno.paciente = paciente;
                formConfirmacionTurno.turno = turnoSeleccionado;
                formConfirmacionTurno.ShowDialog();

            }
        }

        private void FormConsultoriosExternos_Load(object sender, EventArgs e)
        {

        }
    }
}
