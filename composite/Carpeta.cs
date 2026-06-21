using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composite
{
    public class Carpeta : Elemento
    {
        public List<Elemento> Elementos { get; set; } = new List<Elemento>();

        public Carpeta(string nombre) : base(nombre) { }

        public override void Mostrar(string prefijo = "")
        {
            Console.WriteLine($"{ prefijo}Carpeta: " + Nombre);

            foreach (Elemento elemento in Elementos)
            {
                elemento.Mostrar(prefijo +"    ");
            }
        }

        public void Agregar(Elemento elemento)
        {
            Elementos.Add(elemento);
        }

        public void Eliminar(Elemento elemento)
        {
            Elementos.Remove(elemento);
        }
    }
}