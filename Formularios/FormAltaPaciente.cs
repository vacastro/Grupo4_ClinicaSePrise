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
    public partial class FormAltaPaciente : Form
    {
        public FormAltaPaciente()
        {
            InitializeComponent();
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtFechaNac.Text = "";
            txtDomicilio.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }

        private void btnInscribir_Click_1(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente
            {
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Dni = long.Parse(txtDni.Text.Trim()),
                FecNacimiento = DateTime.Parse(txtFechaNac.Text.Trim()),
                Domicilio = txtDomicilio.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Telefono = txtTelefono.Text.Trim()
            };

            Datos.PacienteDatos pac = new Datos.PacienteDatos();
            pac.InsertarPaciente(paciente);
            MessageBox.Show("Paciente registrado con éxito.");
            MenuPaciente menuPaciente = new MenuPaciente();
            menuPaciente.paciente = paciente;

            this.Close();
            menuPaciente.ShowDialog();
        }
    }
}
