using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace abstract_factory
{
    public interface IFabricaPC
    {
        IProcesador CrearProcesador();
        IMotherboard CrearMotherboard();
    }
}