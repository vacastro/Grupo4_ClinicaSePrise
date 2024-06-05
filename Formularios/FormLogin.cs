using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_ClinicaSePrise
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string user;
            string pass;

            user = UsuarioTextBox.Text;
            pass = ContrasenaTextBox.Text;

            validarDatos(user, pass);

            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.UsuariosLogin dato = new Datos.UsuariosLogin(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(user, pass);
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                //MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                FormMenuPpal formMenuPpal = new FormMenuPpal();
                // formMenuPpal.rol = "Hola, " + tablaLogin.Rows[0][0];
                formMenuPpal.ShowDialog();


                this.Close(); // para que no quede la ventana escondida. Sin esto el sistema sigue en ejecucion hasta que se lo termine desde consola.
            }
            else
            {
                //MessageBox.Show("Usuario y/o clave incorrecta. Vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ErrorPanel.Visible = true;
                UsuarioTextBox.Clear();
                ContrasenaTextBox.Clear();
            }
        }

        public void validarDatos(String user, String pass)
        {
            if (string.IsNullOrEmpty(user) && string.IsNullOrEmpty(pass))
            {
                AsteriscoLabel1.Visible = true;
                MensajeLabel1.Visible = true;
                AsteriscoLabel2.Visible = true;
                MensajeLabel2.Visible = true;

            }

            else if (string.IsNullOrEmpty(user))
            {
                AsteriscoLabel1.Visible = true;
                MensajeLabel1.Visible = true;
            }

            else if (string.IsNullOrEmpty(pass))
            {
                AsteriscoLabel2.Visible = true;
                MensajeLabel2.Visible = true;
            }

        }

        private void UsuarioTextBox_TextChanged(object sender, EventArgs e)
        {
            AsteriscoLabel1.Visible = false;
            MensajeLabel1.Visible = false;
        }

        private void ContrasenaTextBox_TextChanged(object sender, EventArgs e)
        {
            AsteriscoLabel2.Visible = false;
            MensajeLabel2.Visible = false;
        }
    }
}
