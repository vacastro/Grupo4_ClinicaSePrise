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
    public partial class MenuPaciente : Form
    {
        public MenuPaciente()
        {
            InitializeComponent();
        }
        internal Paciente? paciente;

        private void button3_Click(object sender, EventArgs e)
        {
            FormSolicitudTurno formSolicitudTurno = new FormSolicitudTurno();
            formSolicitudTurno.ShowDialog();
        }
    }
}
