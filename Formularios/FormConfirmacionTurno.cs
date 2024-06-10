using Grupo4_ClinicaSePrise.Datos;
using Grupo4_ClinicaSePrise.Entidades;
using MySqlX.XDevAPI;
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
    public partial class FormConfirmacionTurno : Form
    {
        internal Paciente? paciente;
        internal Turno? turno;
        public FormConfirmacionTurno()
        {
            InitializeComponent();
        }

        private void ConfirmacionTurno_Load(object sender, EventArgs e)
        {
            if(turno.Sobreturno==true)
            {
                lbSobreTurno.Visible = true;
                lbTurno.Visible = false;
            }
            else
            {
                lbSobreTurno.Visible = false;
                lbTurno.Visible = true;
            }
            lbPaciente.Text = paciente.Nombre + " " + paciente.Apellido;
            lbFecha.Text = turno.Fecha.ToString();
            lbHora.Text = turno.Hora.ToString();
            lbEspecialidad.Text = turno.Especialidad;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            TurnoDatos turnoDatos = new TurnoDatos();
            turnoDatos.InsertarTurno(turno.Fecha, turno.Hora, turno.Especialidad, paciente.PacienteId, turno.Sobreturno);
            MessageBox.Show("Turno agendado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
