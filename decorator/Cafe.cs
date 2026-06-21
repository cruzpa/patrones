using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace decorator
{
    public class Cafe : Bebida
    {
        public float Costo()
        {
            return 4.5f;
        }
        public string Descripcion()
        {
            return "Café";
        }
    }
}