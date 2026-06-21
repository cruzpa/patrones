using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace composite
{
    public abstract class Elemento
    {
        public Elemento(string nombre)
        {
            Nombre = nombre;
        }
        public string Nombre { get; set; }
        public abstract void Mostrar(string prefijo = "");
    }
}