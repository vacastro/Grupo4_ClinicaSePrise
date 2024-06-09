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
    public partial class FormSolicitudTurno : Form
    {
        public FormSolicitudTurno()
        {
            InitializeComponent();
        }

        private void buttonConsultoriosExternos_Click(object sender, EventArgs e)
        {
            FormConsultoriosExternos formConsultoriosExternos = new FormConsultoriosExternos();
            formConsultoriosExternos.ShowDialog();
        }

        private void buttonEstudiosMedicos_Click(object sender, EventArgs e)
        {
            FormEstudiosMedicos formEstudiosMedicos = new FormEstudiosMedicos();
            formEstudiosMedicos.ShowDialog();
        }
    }
}
