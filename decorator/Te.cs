using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace decorator
{
    public class Te : Bebida
    {
        public float Costo()
        {
            return 3.0f;
        }
        public string Descripcion()
        {
            return "Té";
        }
    }
}