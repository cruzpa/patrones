using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace observer
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            Subasta subasta = new Subasta();
            Cliente cliente1 = new Cliente("Cliente 1");
            Cliente cliente2 = new Cliente("Cliente 2");

            subasta.AgregarCliente(cliente1);
            subasta.AgregarCliente(cliente2);

            subasta.NotificarClientes("¡Nueva oferta en la subasta!");

        }
    }
}
