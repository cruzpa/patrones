using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decorator
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

            Bebida te = new Te();

            Console.WriteLine(te.Descripcion() + " $" + te.Costo());

            te = new Edulcorante(te);
            Console.WriteLine(te.Descripcion() + " $" + te.Costo());
            te = new Azucar(te);
            Console.WriteLine(te.Descripcion() + " $" + te.Costo());


            //Bebida(Component): define la interfaz común.
            //Te(ConcreteComponent): objeto base que se quiere decorar.
            //AgregadoDecorator(Decorator): mantiene una referencia a Bebida.
            //Azucar / Edulcorante(ConcreteDecorator): agregan comportamiento(descripción y costo extra).
            //Main(Client): arma la cadena de decoradores

        }
    }
}
