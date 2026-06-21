using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Memento
    {
        public string Texto { get; private set; }
        public Memento(string texto)
        {
            Texto = texto;
        }
    }
}