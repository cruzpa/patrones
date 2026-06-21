using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstract_factory
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

            IFabricaPC fabrica = new FabricaIntel();

            IProcesador cpu = fabrica.CrearProcesador();
            IMotherboard mb = fabrica.CrearMotherboard();

            Console.WriteLine(cpu.Modelo());
            Console.WriteLine(mb.Modelo());



            IFabricaPC fabricaAMD = new FabricaAMD();

            IProcesador cpu2 = fabricaAMD.CrearProcesador();
            IMotherboard mb2 = fabricaAMD.CrearMotherboard();

            Console.WriteLine(cpu2.Modelo());
            Console.WriteLine(mb2.Modelo());

            //El patrón Abstract Factory proporciona una interfaz para crear familias de objetos relacionados sin especificar sus clases concretas.
            //En el ejemplo, una fábrica Intel crea un procesador Intel y un motherboard Intel, mientras que una fábrica AMD crea componentes AMD.
            //El cliente utiliza únicamente las interfaces y puede cambiar toda la familia de productos simplemente cambiando la fábrica utilizada.

        }
    }
}
