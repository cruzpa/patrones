using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace observer
{
    public interface ICliente
    {
        void Actualizar(string mensaje);
    }
}