using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_factory
{
    public class FabricaAMD : IFabricaPC
    {
        public IProcesador CrearProcesador()
        {
            return new ProcesadorAMD();
        }
        public IMotherboard CrearMotherboard()
        {
            return new MotherboardAMD();
        }
    }
}