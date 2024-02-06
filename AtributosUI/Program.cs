using EditorAtributos;
using EditorAtributos.Properties;
using System.Diagnostics;

namespace AtributosUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Debug.WriteLine(Settings.Default.PathDirectorioCanciones);

            if ( Settings.Default.PathDirectorioCanciones.Equals(string.Empty) )
            {
                var frmSugerenciaAutores = new frmCambioDirectorio();
                frmSugerenciaAutores.ShowDialog();
                frmSugerenciaAutores.Dispose();
                Application.Run(new frmAdminArchivos());
            }
            else
            {
                Application.Run(new frmAdminArchivos());
            }

        }
    }
}