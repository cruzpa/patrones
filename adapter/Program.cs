using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Adapter
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
            
            IPago pago = new PagoAdapter(new PagoLegacy());

            pago.Pagar(1000);

        //El cliente espera trabajar con la interfaz IPago, que tiene el método Pagar().
        //Sin embargo, existe una clase antigua PagoLegacy que utiliza RealizarPago().
        //Para evitar modificar el código existente, creamos PagoAdapter,
        //que implementa IPago y traduce la llamada Pagar() hacia RealizarPago().
        //
        //De esta forma ambas interfaces son compatibles.


        //Roles del patrón:

        //Target: IPago
        //Adaptee: PagoLegacy
        //Adapter: PagoAdapter
        //Client: quien trabaja contra IPago sin conocer PagoLegacy
        }
    }
}
