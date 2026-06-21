using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_factory
{
    public class ProcesadorIntel : IProcesador
    {
        public ProcesadorIntel() { }
        public string Modelo()
        {
            return "Procesador Intel";
        }
    }
}