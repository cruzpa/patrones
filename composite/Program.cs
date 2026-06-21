using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace composite
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

            Carpeta raiz = new Carpeta("Documentos");

            Archivo pdf = new Archivo("cv.pdf");
            Archivo txt = new Archivo("notas.txt");

            Carpeta proyectos = new Carpeta("Proyectos");
            proyectos.Agregar(new Archivo("tp1.docx"));
            proyectos.Agregar(new Archivo("tp2.docx"));

            raiz.Agregar(pdf);
            raiz.Agregar(txt);
            raiz.Agregar(proyectos);
            raiz.Agregar(proyectos);

            raiz.Mostrar();

            //El patrón Composite permite tratar objetos individuales y conjuntos de objetos de la misma manera.
            //En este ejemplo, tanto Archivo como Carpeta heredan de Elemento.
            //Gracias a eso, una carpeta puede contener archivos o incluso otras carpetas, formando una estructura jerárquica en árbol.
            //El cliente interactúa siempre con la interfaz Elemento sin preocuparse por si está trabajando con un objeto simple o compuesto.
        }
    }
}
