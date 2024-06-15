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
    public partial class FormTurnosSolicitados : Form
    {
        internal Paciente? paciente;
        private BindingList<Turno> turnos;
        public FormTurnosSolicitados(Paciente paciente)
        {
            InitializeComponent();
            DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            checkboxColumn.HeaderText = "Seleccionado";
            checkboxColumn.Name = "Seleccionado";
            dgvTurnosSolicitados.Columns.Add(checkboxColumn);
            this.paciente = paciente;
            CargarTurnos();

        }

        private void CargarTurnos()
        {
            TurnoDatos turnoDatos = new TurnoDatos();
            List<Turno> turnosList = turnoDatos.BuscarTurnosPaciente(paciente.PacienteId);
            turnos = new BindingList<Turno>(turnosList);
            dgvTurnosSolicitados.DataSource = turnos;
            dgvTurnosSolicitados.Columns["TurnoId"].Visible = false;
            dgvTurnosSolicitados.Columns["SobreTurno"].Visible = false;
            dgvTurnosSolicitados.Columns["PacienteId"].Visible = false;
        }

        private void FormTurnosSolicitados_Load(object sender, EventArgs e)
        {
            lbPaciente.Text = paciente.Nombre + " " + paciente.Apellido;

        }

        private void btnCancelarTurno_Click(object sender, EventArgs e)
        {
            if (dgvTurnosSolicitados.SelectedCells.Count > 0)
            {
                int rowIndex = dgvTurnosSolicitados.SelectedCells[0].RowIndex;
                Turno turnoSeleccionado = (Turno)dgvTurnosSolicitados.Rows[rowIndex].DataBoundItem;

                DialogResult result = MessageBox.Show("¿Está seguro de que desea cancelar este turno?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        TurnoDatos turnoDatos = new TurnoDatos();
                        turnoDatos.CancelarTurno(turnoSeleccionado.TurnoId);

                        // Eliminar el turno del DataGridView
                        dgvTurnosSolicitados.Rows.RemoveAt(rowIndex);

                        MessageBox.Show("El turno ha sido cancelado exitosamente.", "Turno cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cancelar el turno: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un turno para cancelar.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      
    }
}
