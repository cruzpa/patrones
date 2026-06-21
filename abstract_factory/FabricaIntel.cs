using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_factory
{
    public class FabricaIntel : IFabricaPC
    {
        public IProcesador CrearProcesador()
        {
            return new ProcesadorIntel();
        }
        public IMotherboard CrearMotherboard()
        {
            return new MotherboardIntel();
        }
    }
}