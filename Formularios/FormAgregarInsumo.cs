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
    public partial class FormAgregarInsumo : Form
    {
        private FormInsumos formInsumosRef; 

        public FormAgregarInsumo(FormInsumos formInsumos)
        {
            InitializeComponent();
            this.formInsumosRef = formInsumos; 
        }

        private void confirmarAgregarInsumo_Click(object sender, EventArgs e)
        {
            // Guardar los cambios en la base de datos
            InsumoDatos insumoDatos = new InsumoDatos();
            Insumo nuevoInsumo = new Insumo();

            if (nuevoInsumo != null) 
            {
                if (TextBoxEsNumero())
                {
                    nuevoInsumo.Nombre = nombreTxt.Text;
                    nuevoInsumo.Cantidad = Convert.ToInt32(cantidadTxt.Text);
                    insumoDatos.InsertarInsumo(nuevoInsumo);
                    formInsumosRef.CargarInsumos();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cambios no guardados");
                }
            }
        }

        private bool TextBoxEsNumero()
        {
            string textoUsuario = cantidadTxt.Text;

            try
            {
                int numero = Convert.ToInt32(textoUsuario);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show("Debe ingresar un número válido.");
                cantidadTxt.Focus(); 
            }
            return false;
        }

    }
}
