using Grupo4_ClinicaSePrise.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupo4_ClinicaSePrise
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Intentar establecer la conexi�n antes de mostrar el formulario principal
            try
            {
                // Intentar obtener la instancia de conexi�n
                var conexion = Conexion.getInstancia();
                var sqlCon = conexion.CrearConexion();

                // Probar la conexi�n
                sqlCon.Open();
                sqlCon.Close();

                MessageBox.Show("Conexi�n a la base de datos establecida correctamente.", "�xito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer la conexi�n: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la aplicaci�n si la conexi�n falla
            }

            // Si la conexi�n fue exitosa, continuar con la aplicaci�n
            Application.Run(new FormLogin()); // Reemplaza FormLogin con el nombre de tu formulario de login
        }
    }
}