using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factory_method
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

            Pizzeria pizzeria = new PizzeriaArgentina();

            Pizza pizza = pizzeria.CrearPizza();

            pizza.Preparar();


            //El patrón Factory Method define un método para crear objetos, pero deja que las subclases decidan qué objeto concreto instanciar.
            //El cliente trabaja con la abstracción Pizza y no necesita conocer las clases concretas.
            //Esto reduce el acoplamiento y facilita agregar nuevos tipos de productos sin modificar el código cliente.
        }
    }
}
