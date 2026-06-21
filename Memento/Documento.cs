using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Documento
    {
        public string Texto { get; set; }

        public Documento(string texto)
        {
            Texto = texto;
        }

        public Memento Guardar()
        {
            return new Memento(Texto);
        }

        public void Restaurar(Memento memento)
        {
            Texto = memento.Texto;
        }
    }
}