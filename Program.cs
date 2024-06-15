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

            // Intentar establecer la conexión antes de mostrar el formulario principal
            try
            {
                // Intentar obtener la instancia de conexión
                var conexion = Conexion.getInstancia();
                var sqlCon = conexion.CrearConexion();

                // Probar la conexión
                sqlCon.Open();
                sqlCon.Close();

                MessageBox.Show("Conexión a la base de datos establecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al establecer la conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir de la aplicación si la conexión falla
            }

            // Si la conexión fue exitosa, continuar con la aplicación
            Application.Run(new FormLogin()); // Reemplaza FormLogin con el nombre de tu formulario de login
        }
    }
}