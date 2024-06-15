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
    public partial class SinLocalizarPaciente : Form
    {
        public SinLocalizarPaciente()
        {
            InitializeComponent();
        }

        private void btnCensar_Click_1(object sender, EventArgs e)
        {
            FormAltaPaciente formAltaPaciente = new FormAltaPaciente();
            formAltaPaciente.ShowDialog();
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
