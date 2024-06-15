using Grupo4_ClinicaSePrise.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Grupo4_ClinicaSePrise
{
    public partial class FormMenuPpal : Form
    {
        public FormMenuPpal()
        {
            InitializeComponent();
        }

        private void SolicitudTurnoButton_Click(object sender, EventArgs e)
        {
            FormBuscarPaciente formSolicitudTurno = new FormBuscarPaciente();
            formSolicitudTurno.ShowDialog();
        }

        private void AgendaTurnoButton_Click(object sender, EventArgs e)
        {
            FormAgendaTurnos formAgendaTurnos = new FormAgendaTurnos();
            formAgendaTurnos.ShowDialog();
        }

        private void FormMenuPpal_Load(object sender, EventArgs e)
        {

        }
    }
}
