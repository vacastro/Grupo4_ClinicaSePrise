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
    public partial class FormActualizarPaciente : Form
    {
        internal Paciente paciente;
        public FormActualizarPaciente(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            CargarDatosPaciente();
        }

        private void CargarDatosPaciente()
        {
            txtNombre.Text = paciente.Nombre;
            txtApellido.Text = paciente.Apellido;
            txtDni.Text = paciente.Dni.ToString();
            txtFechaNac.Text = paciente.FecNacimiento.ToString("dd-MM-yyyy");
            txtDomicilio.Text = paciente.Domicilio;
            txtEmail.Text = paciente.Email;
            txtTelefono.Text = paciente.Telefono;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            paciente.Nombre = txtNombre.Text.Trim();
            paciente.Apellido = txtApellido.Text.Trim();
            paciente.Dni = long.Parse(txtDni.Text.Trim());
            paciente.FecNacimiento = DateTime.Parse(txtFechaNac.Text.Trim());
            paciente.Domicilio = txtDomicilio.Text.Trim();
            paciente.Email = txtEmail.Text.Trim();
            paciente.Telefono = txtTelefono.Text.Trim();

            try
            {
                PacienteDatos pac = new PacienteDatos();
                pac.ActualizarPaciente(paciente);
                MessageBox.Show("Paciente actualizado con éxito.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el paciente: " + ex.Message);
            }
        }
    }
}
