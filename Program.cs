using System;
using System.Windows.Forms;

namespace encriptador_ralabe
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Inicialización de estilos e interfaz compatible con .NET Framework 4.8
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lanza la ventana principal del aplicativo MCI-RALABE
            Application.Run(new Form1());
        }
    }
}