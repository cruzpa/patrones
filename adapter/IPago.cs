using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adapter
{
    public interface IPago
    {
        void Pagar(decimal monto);
    }
}