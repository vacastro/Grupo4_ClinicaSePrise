using Grupo4_ClinicaSePrise.Datos;
using Grupo4_ClinicaSePrise.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grupo4_ClinicaSePrise.Formularios
{


    public partial class FormAgendaTurnos : Form
    {
        public FormAgendaTurnos()
        {
            InitializeComponent();
            mostrarEspecialidades();
        }

        public void mostrarEspecialidades()
        {
            EspecialidadesDatos especialidadDatos = new EspecialidadesDatos();
            List<string> especialidades = especialidadDatos.ObtenerEspecialidadesPorTipo("consultorios_externos");

            BoxTrurnos.Items.Add(especialidades);
        }

        public void mostrarListaTurnos(string especialidad)
        {
            TurnoDatos turnoDatos = new TurnoDatos();
            Dictionary<DateTime, List<Turno>> turnosPorFecha = turnoDatos.BuscarTurnosPorEspecialidad(especialidad);

            List<DateTime> listaFechas = new List<DateTime>(turnosPorFecha.Keys);
            List<TurnoFila> listaTurnos = new List<TurnoFila>();

            foreach (var turno in turnosPorFecha)
            {
                DateTime fecha = turno.Key;

                foreach (Turno turnoPaciente in turno.Value)
                {
                    PacienteDatos datosPaciente = new PacienteDatos();
                    var pacienteEncontrado = datosPaciente.BuscarPacienteById(turnoPaciente.PacienteId);

                    listaTurnos.Add(new TurnoFila { Nombre = pacienteEncontrado.Nombre, Apellido = pacienteEncontrado.Apellido, DNI = pacienteEncontrado.Dni, Email = pacienteEncontrado.Email });
                }
            }

            if (listaFechas.Count > 0)
            {
                // Obtener la primera y última clave
                DateTime primeraClave = listaFechas[0];
                DateTime ultimaClave = listaFechas[listaFechas.Count - 1];

                // Configurar el DateTimePicker
                dateAgendaTrunos.MinDate = primeraClave;
                dateAgendaTrunos.MaxDate = ultimaClave;

                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = listaTurnos;
            }
        }

        private void btnTurnosVolver_Click(object sender, EventArgs e)
        {
            FormMenuPpal formPrincipal = new FormMenuPpal();
            formPrincipal.ShowDialog();
        }

        private void BoxTrurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = BoxTrurnos.SelectedItem;
            string selectedText = selectedItem.ToString();

           mostrarListaTurnos(selectedText);
        }

        private void dateAgendaTrunos_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    public class TurnoFila
    {
        public TimeSpan Hora { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public long DNI { get; set; }
        public string Email { get; set; }
        public int Socio { get; set; }
    }
}
