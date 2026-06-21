using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Memento
{
    public class Caretaker
    {
        public List<Memento> Mementos { get; private set; }

        public Caretaker()
        {
            Mementos = new List<Memento>();
        }

        public void AgregarMemento(Memento memento)
        {
            Mementos.Add(memento);
        }
    }
}