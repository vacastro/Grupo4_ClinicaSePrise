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
    public partial class FormBuscarPaciente : Form
    {
        public FormBuscarPaciente()
        {
            InitializeComponent();
        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            MensajeLabel1.Visible = false;
            string dni;
            long dniNum = 0;

            dni = txtDni.Text.Trim();

            validarDatos(dni);


            if (!EsNumero(dni))
            {
                MensajeLabel1.Visible = true;
            }
            else
            {
                dniNum = long.Parse(dni);
            }

            if (dniNum > 0)
            {
                // buscar al cliente en la base de datos
                Datos.PacienteDatos pac = new Datos.PacienteDatos();
                Paciente paciente = pac.IdentificarPaciente(dniNum);


                if (dniNum == paciente.Dni)
                {
                    MenuPaciente menuPaciente = new MenuPaciente();
                    menuPaciente.paciente = paciente;
                    this.Hide();
                    menuPaciente.ShowDialog();
                    
                    
                }
                else
                {
                    SinLocalizarPaciente sinLocalizarPaciente = new SinLocalizarPaciente();
                    sinLocalizarPaciente.Show();

                }
            }
        }

        public void validarDatos(String dni)
        {
            if (string.IsNullOrEmpty(dni))
            {
                AsteriscoLabel1.Visible = true;
                MensajeLabel1.Visible = true;

            }
        }


        private bool EsNumero(string dni)
        {
            foreach (char c in dni)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            AsteriscoLabel1.Visible = false;
            MensajeLabel1.Visible = false;
        }
    }
}
