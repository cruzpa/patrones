using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_factory
{
    public class ProcesadorAMD : IProcesador
    {
        public ProcesadorAMD() { }
        public string Modelo()
        {
            return "Procesador AMD";
        }
    }
}