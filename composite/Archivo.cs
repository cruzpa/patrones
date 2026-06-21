using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composite
{
    public class Archivo : Elemento
    {
        public Archivo(string nombre) : base(nombre) { }
        public override void Mostrar(string prefijo = "")
        {
            Console.WriteLine($"{prefijo}Archivo: {Nombre}");
        }
    }
}