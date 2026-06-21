using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class PagoLegacy
    {
        public void RealizarPago(decimal monto)
        {
            Console.WriteLine($"Pago legacy realizado por un monto de {monto}");
        }
    }
}