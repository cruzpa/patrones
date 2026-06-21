using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class PagoModerno
    {
        public void Pagar(decimal monto)
        {
            Console.WriteLine($"Pago moderno realizado por un monto de {monto}");
        }
    }
}