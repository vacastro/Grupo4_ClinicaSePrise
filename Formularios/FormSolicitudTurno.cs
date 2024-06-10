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
    public partial class FormSolicitudTurno : Form
    {
        internal Paciente? paciente;
        private List<string> especialidadesConsultorioExterno;
        private List<string> especialidadesEstudiosMedicos;

        public FormSolicitudTurno()
        {
            InitializeComponent();
            especialidadesConsultorioExterno = new List<string>();
            especialidadesEstudiosMedicos = new List<string>();
        }

      


        private void buttonConsultoriosExternos_Click(object sender, EventArgs e)
        {
            EspecialidadesDatos especialidadesDatos = new EspecialidadesDatos();
            especialidadesConsultorioExterno = especialidadesDatos.ObtenerEspecialidadesPorTipo("consultorio_externo");
            FormConsultoriosExternos formConsultoriosExternos = new FormConsultoriosExternos(especialidadesConsultorioExterno);
            formConsultoriosExternos.ShowDialog();
        }

        private void buttonEstudiosMedicos_Click(object sender, EventArgs e)
        {
            EspecialidadesDatos especialidadesDatos = new EspecialidadesDatos();
            especialidadesEstudiosMedicos = especialidadesDatos.ObtenerEspecialidadesPorTipo("estudios_medicos");

            FormEstudiosMedicos formEstudiosMedicos = new FormEstudiosMedicos(especialidadesEstudiosMedicos);
            formEstudiosMedicos.ShowDialog();
        }

        private void FormSolicitudTurno_Load(object sender, EventArgs e)
        {

        }
    }
}
