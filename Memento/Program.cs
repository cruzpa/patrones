using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Memento
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

            Caretaker caretaker = new Caretaker();
            Documento doc = new Documento("Texto inicial");
            
            Console.WriteLine("Texto actual: " + doc.Texto);
            caretaker.AgregarMemento(doc.Guardar());

            Console.WriteLine("Modificando el texto...");
            doc.Texto = "Texto modificado";

            Console.WriteLine("Texto actual: " + doc.Texto);
            
            Console.WriteLine("Restaurando el texto al original...");
            doc.Restaurar(caretaker.Mementos[0]);
            Console.WriteLine("Texto actual: " + doc.Texto);


            //Originator: Documento, que tiene el estado que queremos guardar/restaurar.
            //Memento: Memento, que almacena el estado del Documento.
            //Caretaker: Caretaker, que mantiene una lista de Mementos y permite agregar nuevos Mementos.
            //
            //otro ejemplo:
            //Pensemos en un videojuego. El personaje avanza y llega al nivel 10.
            //El juego guarda una partida. Luego el jugador pierde todas sus vidas.
            //
            //Gracias al patrón Memento, el sistema puede restaurar el estado guardado anteriormente
            //y volver al nivel 10 sin que otras clases conozcan los detalles internos del personaje.

        }
    }
}
