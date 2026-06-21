using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public class PagoAdapter : IPago
    {
        public PagoLegacy PagoLegacy { get; set; }

        public PagoAdapter(PagoLegacy pagoLegacy)
        {
            PagoLegacy = pagoLegacy;
        }
        public void Pagar(decimal monto)
        {
            PagoLegacy.RealizarPago(monto);
        }

    }
}